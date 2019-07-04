//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

#if UNITY_EDITOR
using UnityEditor;
#endif
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Pixeye.Framework
{
	/// <summary>
	/// <para>A scene point of entry. The developer defines here scene dependencies and processing that will work on the scene.</para> 
	/// </summary>
	public class Starter : MonoBehaviour
	{
		public static bool initialized;

		#if ODIN_INSPECTOR
		[FoldoutGroup("Setup")]
		#else
		[FoldoutGroup("Setup"), Reorderable]
		#endif
		public List<SceneReference> ScenesToKeep;

		#if ODIN_INSPECTOR
		[FoldoutGroup("Setup")]
		#else
		[FoldoutGroup("Setup"), Reorderable]
		#endif
		public List<SceneReference> SceneDependsOn;

		[FoldoutGroup("Pool Cache")]
		public List<PoolNode> nodes = new List<PoolNode>();

		void Awake()
		{
			if (ProcessorUpdate.Default == null)
				ProcessorUpdate.Create();

			ProcessorScene.Default.Setup(ScenesToKeep, SceneDependsOn, this);
		}

		#if UNITY_EDITOR
		public void ClearNodes()
		{
			for (int i = 0; i < nodes.Count; i++)
			{
				var n = nodes[i];
				n.createdObjs.Clear();
				n.prefab = null;
			}

			nodes.Clear();
		}
		public void AddToNode(GameObject prefab, GameObject instance, int pool)
		{
			var id                  = prefab.GetInstanceID();
			var nodesValid          = nodes.FindValidNodes(id);
			var conditionNodeCreate = true;
			var nodesToKill         = new List<int>();

			for (int i = 0; i < nodesValid.Count; i++)
			{
				var node = nodes[nodesValid[i]];

				var index = node.createdObjs.FindInstanceID(instance);
				if (index != -1 && pool != node.pool)
				{
					node.createdObjs.RemoveAt(index);
				}
				else if (index == -1 && pool == node.pool)
				{
					conditionNodeCreate = false;
					node.createdObjs.Add(instance);
				}

				if (index != -1 && pool == node.pool)
				{
					conditionNodeCreate = false;
				}

				if (node.createdObjs.Count == 0)
				{
					node.prefab = null;
					nodesToKill.Add(nodesValid[i]);
				}
			}

			for (int i = 0; i < nodesToKill.Count; i++)
			{
				nodes.RemoveAt(nodesToKill[i]);
			}

			if (conditionNodeCreate)
			{
				var node = new PoolNode();
				node.id          = id;
				node.prefab      = prefab;
				node.pool        = pool;
				node.createdObjs = new List<GameObject>();
				node.createdObjs.Add(instance);
				nodes.Add(node);
			}
		}
		public void RemoveFromNode(GameObject instance, int pool)
		{
			GameObject prefab;
			#if UNITY_2018_3_OR_NEWER
			prefab = PrefabUtility.GetCorrespondingObjectFromSource(instance);
			#else
			prefab = (GameObject)PrefabUtility.GetPrefabObject(instance);
			#endif

			if (prefab == null) return;
			var id    = prefab.GetInstanceID();
			var index = nodes.FindValidNode(id, pool);
			if (index != -1)
			{
				var n = nodes[index];

				n.createdObjs.Remove(instance);
				if (n.createdObjs.Count == 0)
				{
					n.prefab = null;
					nodes.RemoveAt(index);
				}
			}
		}
		#endif

		public void BindScene()
		{
			for (int i = 0; i < nodes.Count; i++)
				nodes[i].Populate();

			Add<ProcessorEntities>();
			Add<ProcessorObserver>();

			Setup();

			for (int i = 0; i < ProcessorGroups.container.len; i++)
				ProcessorGroups.container.storage[i].AddCallbacks();


			initialized = true;

			var objs = FindObjectsOfType<MonoBehaviour>().OfType<IRequireStarter>();
			foreach (var obj in objs)
				obj.Launch();


			Timer.Add(Time.deltaFixed, PostSetup);
		}

		/// <summary>
		/// <para>Adds an object to the toolbox by type. It is mainly used to add processing scripts.</para>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		protected static T Add<T>() where T : new()
		{
			return Toolbox.Add<T>();
		}

		protected virtual void Setup()
		{
		}

		protected virtual void PostSetup()
		{
		}

		protected virtual void OnDestroy()
		{
			initialized = false;
		}
	}


	//===============================//
	// FEATURES
	//===============================//

	public abstract class Feature : IAwake
	{
		public void Add<T>() where T : new()
		{
			Toolbox.Add<T>();
		}

		public abstract void OnAwake();
	}
}