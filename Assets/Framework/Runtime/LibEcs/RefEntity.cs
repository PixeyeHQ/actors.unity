//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections.Generic;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using Object = System.Object;

namespace Pixeye
{
	public static class RefEntity
	{

		public static Dictionary<int, Dictionary<int, object>>[] cacheMono = {new Dictionary<int, Dictionary<int, object>>(new FastComparable()), new Dictionary<int, Dictionary<int, object>>(new FastComparable())};
		public static Dictionary<int, int> blueprintID = new Dictionary<int, int>(EngineSettings.SizeComponents, new FastComparable());
		public static int[,] generations = new int[EngineSettings.SizeComponents, EngineSettings.SizeGenerations];
		public static bool[] isAlive = new bool[EngineSettings.SizeComponents];
		public static int[] poolIDS = new int[EngineSettings.SizeComponents];
		public static Transform[] transforms = new Transform[EngineSettings.SizeComponents];

		#region REFERENCES

		public static void AddReference(this ref ent entity, Transform transform)
		{
			entity = new ent(entity.id, transform.GetHashCode());
			if (entity >= isAlive.Length)
			{
				var l = entity << 1;
				generations = generations.ResizeArray(l, EngineSettings.SizeGenerations);
				Array.Resize(ref transforms, l);
				Array.Resize(ref isAlive, l);
			}

			transforms[entity] = transform;
			if (cacheMono.Length > entity)
			{
				if (cacheMono[entity] != null)
					cacheMono[entity].Clear();
			}

			entity.AddNoCheck<ComponentObject>();
		}
		public static void AddReferenceMono(this ref ent entity, Transform transform)
		{
			entity.AddReference(transform);
			var mono = transform.AddGet<MonoEntity>();
			mono.entity = entity;
			#if UNITY_EDITOR
			mono._entity = entity;
			#endif
		}
		public static void AddPool(this in ent entity, int poolID)
		{
			if (entity >= poolIDS.Length)
			{
				var l = entity << 1;
				Array.Resize(ref poolIDS, l);
			}

			poolIDS[entity] = poolID;
		}

		#endregion

		#region GET

		public static T Get<T>(this Transform tr)
		{
			return tr.GetComponentInChildren<T>();
		}
		public static T Get<T>(this in ent entity, int path)
		{
			return (T) cacheMono[entity][path][typeof(T).GetHashCode()];
		}
		public static T Get<T>(this in ent entity)
		{
			return transforms[entity].GetComponentInChildren<T>();
		}
		public static void RefComponentsAll(this in ent entity)
		{
			if (entity >= cacheMono.Length)
			{
				var l = entity << 1;
				Array.Resize(ref cacheMono, l);
				cacheMono[entity] = new Dictionary<int, Dictionary<int, object>>(new FastComparable());
			}
			else if (cacheMono[entity] is null) cacheMono[entity] = new Dictionary<int, Dictionary<int, object>>(new FastComparable());

			var components  = transforms[entity].GetComponentsInChildren<Transform>();
			var key         = "base".GetHashCode();
			var child       = components[0];
			var _components = child.GetComponents<Component>();
			cacheMono[entity].Add(key, new Dictionary<int, object>(new FastComparable()));
			foreach ( var component in _components )
			{
				if (component.GetType() != typeof(Transform))
				{
					cacheMono[entity][key].Add(component.GetType().GetHashCode(), component);
				}
			}

			for ( int i = 1; i < components.Length; i++ )
			{
				child = components[i];
				_components = child.GetComponents<Component>();
				key = child.name.GetHashCode();
				cacheMono[entity].Add(key, new Dictionary<int, object>(new FastComparable()));
				foreach ( var component in _components )
				{
					if (component.GetType() != typeof(Transform))
					{
						cacheMono[entity][key].Add(component.GetType().GetHashCode(), component);
					}
				}
			}
		}
		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		public static void RefComponent<T>(this in ent entity, T obj, string path = "base") where T : Component
		{
			if (entity >= cacheMono.Length)
			{
				var l = entity << 1;
				Array.Resize(ref cacheMono, l);
				cacheMono[entity] = new Dictionary<int, Dictionary<int, object>>(new FastComparable());
			}
			else if (cacheMono[entity] is null) cacheMono[entity] = new Dictionary<int, Dictionary<int, object>>(new FastComparable());

			var                     key = path.GetHashCode();
			var                     k   = typeof(T).GetHashCode();
			Dictionary<int, object> components;
			if (cacheMono[entity].TryGetValue(key, out components))
			{
				Object o;
				if (components.TryGetValue(k, out o))
				{
					components[k] = obj;
				}
				else components.Add(k, obj);
			}
			else
			{
				components = new Dictionary<int, object>();
				cacheMono[entity].Add(key, components);
				components[k] = obj;
			}
		}

		#endregion

		#region TRANSFORMS

		/// <summary>
		/// <para>Returns the transform linked to the entity.</para>
		/// </summary>
		/// <param name="entity"></param>
		/// <returns>Returns the transform linked to the entity.</returns>
		public static Transform transform(this in ent entity)
		{
			return transforms[entity];
		}
		public static Transform transform(this in ent entity, int index)
		{
			return transforms[entity].GetChild(index);
		}
		public static Transform transform(this in ent entity, int index1, int index2)
		{
			return transforms[entity].GetChild(index1).GetChild(index2);
		}
		public static Transform transform(this in ent entity, int index1, int index2, int index3)
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetChild(index3);
		}
		public static Transform transform(this in ent entity, int index1, int index2, int index3, int index4)
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetChild(index3).GetChild(index4);
		}

		#endregion

		#region COMPONENTS

		/// <summary>
		/// <para>Returns the transform linked to the entity.</para>
		/// </summary>
		/// <param name="entity"></param>
		/// <returns>Returns the transform linked to the entity.</returns>
		public static T GetComponent<T>(this in ent entity)
		{
			return transforms[entity].GetComponent<T>();
		}
		public static T GetComponent<T>(this in ent entity, int index)
		{
			return transforms[entity].GetChild(index).GetComponent<T>();
			;
		}
		public static T GetComponent<T>(this in ent entity, int index1, int index2)
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetComponent<T>();
			;
		}
		public static T GetComponent<T>(this in ent entity, int index1, int index2, int index3)
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetChild(index3).GetComponent<T>();
			;
		}
		public static T GetComponent<T>(this in ent entity, int index1, int index2, int index3, int index4)
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetChild(index3).GetChild(index4).GetComponent<T>();
			;
		}

		#endregion

	}
}