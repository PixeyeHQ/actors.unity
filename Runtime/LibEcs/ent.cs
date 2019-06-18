//  Project : ecs
// Contacts : Pix - info@pixeye.games
//     Date : 3/16/2019 

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
	public unsafe readonly struct ent
	{
		internal static Queue<ent> entityStack = new Queue<ent>(SettingsEngine.SizeEntities);
		internal static int entityStackLength;
		internal static int lastID;

		public readonly int id;
		internal readonly byte age;

		public ref readonly Transform transform
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ref Entity.transforms[id];
		}

		public override string ToString()
		{
			return id.ToString();
		}

		#region ENTITY

		public ent(int id = -1, byte age = 0)
		{
			this.id  = id;
			this.age = age;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public implicit operator int(ent value)
		{
			return value.id;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public implicit operator ent(int value)
		{
			return new ent(value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ent operator +(ent a, int b)
		{
			return new ent(a.id + b, a.age);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ent operator -(ent a, int b)
		{
			return new ent(a.id - b, a.age);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int CompareTo(int value)
		{
			if (id < value)
				return -1;
			return id > value ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			return obj is ent other && Equals(other);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(int other)
		{
			return id == other;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return age;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int CompareTo(object obj)
		{
			ent other = (ent) obj;
			return id.CompareTo(other.id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Has<T>()
		{
			var mask = Storage<T>.componentMask;

			return (Entity.generations[id, Storage<T>.generation] & mask) == mask;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Unbind()
		{
			Entity.cache[id].isAlive = false;
			EntityOperations.Set(this, 0, EntityOperations.Action.Unbind);
			Entity.Count--;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Release()
		{
			#if UNITY_EDITOR
			if (!Entity.cache[id].isAlive)
			{
				Debug.LogError($"Entity with id [{id}]  already destroyed.");
				return;
			}
			#endif

			Entity.cache[id].isAlive = false;
			EntityOperations.Set(this, 0, EntityOperations.Action.Kill);
			Entity.Count--;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool EqualsAndExist(ent other)
		{
			return id > -1 && Entity.cache[id].isAlive && this.id == other.id && this.age == other.age;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(ent other)
		{
			return id == other.id && age == other.age;
		}

		public bool Exist
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get { return id > -1 && Entity.cache[id].isAlive && Entity.cache[id].age == age; }
		}

		#endregion

		#region GET

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Get<T>()
		{
			return Storage<T>.Instance.components[id];
			//(arg0 = (Entity.generations[id, Storage<T>.generation] & Storage<T>.componentMask) == Storage<T>.componentMask ? Storage<T>.Instance.components[id] : default) != null;
		}

		/// <summary>
		/// <para>Safely gets the component by type from the entity.</para>
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="arg0"></param>
		/// <typeparam name="T"></typeparam>
		/// <returns>Returns true if the entity has this component.</returns>
		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Get<T>(out T arg0)
		{
			return (arg0 = (Entity.generations[id, Storage<T>.generation] & Storage<T>.componentMask) == Storage<T>.componentMask ? Storage<T>.Instance.components[id] : default) != null;
		}

		/// <summary>
		/// <para>Safely gets the components by type from the entity.</para>
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="arg0"></param>
		/// <param name="arg1"></param>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="Y"></typeparam>
		/// <returns>Returns true if the entity has these components.</returns>
		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		public bool Get<T, Y>(out T arg0, out Y arg1)
		{
			arg0 = default;
			arg1 = default;
			if ((arg0 = Storage<T>.Instance.TryGet(id)) == null) return false;
			return (arg1 = Storage<Y>.Instance.TryGet(id)) != null;
		}

		/// <summary>
		/// <para>Safely gets the components by type from the entity.</para>
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="arg0"></param>
		/// <param name="arg1"></param>
		/// <param name="arg2"></param>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="Y"></typeparam>
		/// <typeparam name="U"></typeparam>
		/// <returns>Returns true if the entity has these components.</returns>
		[Il2CppSetOption(Option.NullChecks, false)]
		public bool Get<T, Y, U>(out T arg0, out Y arg1, out U arg2)
		{
			arg0 = default;
			arg1 = default;
			arg2 = default;
			if ((arg0 = Storage<T>.Instance.TryGet(id)) == null) return false;
			if ((arg1 = Storage<Y>.Instance.TryGet(id)) == null) return false;
			return (arg2 = Storage<U>.Instance.TryGet(id)) != null;
		}

		/// <summary>
		/// <para>Safely gets the components by type from the entity.</para>
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="arg0"></param>
		/// <param name="arg1"></param>
		/// <param name="arg2"></param>
		/// <param name="arg3"></param>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="Y"></typeparam>
		/// <typeparam name="U"></typeparam>
		/// <typeparam name="I"></typeparam>
		/// <returns>Returns true if the entity has these components.</returns>
		[Il2CppSetOption(Option.NullChecks, false)]
		public bool Get<T, Y, U, I>(out T arg0, out Y arg1, out U arg2, out I arg3)
		{
			arg0 = default;
			arg1 = default;
			arg2 = default;
			arg3 = default;
			if ((arg0 = Storage<T>.Instance.TryGet(id)) == null) return false;
			if ((arg1 = Storage<Y>.Instance.TryGet(id)) == null) return false;
			if ((arg2 = Storage<U>.Instance.TryGet(id)) == null) return false;
			return (arg3 = Storage<I>.Instance.TryGet(id)) != null;
		}

		/// <summary>
		/// Safely gets the components by type from the entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="arg0"></param>
		/// <param name="arg1"></param>
		/// <param name="arg2"></param>
		/// <param name="arg3"></param>
		/// <param name="arg4"></param>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="Y"></typeparam>
		/// <typeparam name="U"></typeparam>
		/// <typeparam name="I"></typeparam>
		/// <typeparam name="O"></typeparam>
		/// <returns>Returns true if the entity has these components.</returns>
		[Il2CppSetOption(Option.NullChecks, false)]
		public bool Get<T, Y, U, I, O>(out T arg0, out Y arg1, out U arg2, out I arg3, out O arg4)
		{
			arg0 = default;
			arg1 = default;
			arg2 = default;
			arg3 = default;
			arg4 = default;
			if ((arg0 = Storage<T>.Instance.TryGet(id)) == null) return false;
			if ((arg1 = Storage<Y>.Instance.TryGet(id)) == null) return false;
			if ((arg2 = Storage<U>.Instance.TryGet(id)) == null) return false;
			if ((arg3 = Storage<I>.Instance.TryGet(id)) == null) return false;
			return (arg4 = Storage<O>.Instance.TryGet(id)) != null;
		}

		#endregion
	}
}