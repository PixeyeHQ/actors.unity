//  Project : ecs
// Contacts : Pix - info@pixeye.games
//     Date : 3/16/2019 


using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
	public unsafe struct ent
	{
		//===============================//
		// Released entities
		//===============================//

		internal static ents entStack = new ents(Framework.Settings.SizeEntities);
		internal static int size = sizeof(ent);
		internal static int lastID;

		//===============================//
		// Entity
		//===============================//

		public int id;
		internal byte age;

		public ref readonly Transform transform
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ref Entity.Transforms[id];
		}

		public bool exist
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get { return id > 0 && Entity.entities[id].age == age && Entity.entities[id].componentsAmount > 0; }
		}

		public ent(int value)
		{
			id  = value;
			age = 0;
		}

		public override int GetHashCode()
		{
			return ((id << 5) + id) ^ age;
		}
		public override string ToString()
		{
			return id.ToString();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Release()
		{
			#if UNITY_EDITOR
			if (!Exist)
			{
				Framework.Debugger.Log(LogType.DESTROYED, this);
				return;
			}
			#endif
		 
			EntityOperations.Set(this, 0, EntityOperations.Action.Kill);
		  //id = 0; todo: think how to set id to zero from release.
	
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(ent other)
		{
			return id == other.id && age == other.age;
		}
		public override bool Equals(object obj)
		{
			return obj is ent other && Equals(other);
		}

		//===============================//
		// Operators
		//===============================//
		static public implicit operator int(ent value)
		{
			return value.id;
		}
		static public implicit operator ent(int value)
		{
			ent e = new ent(value);
			return e;
		}
		static public bool operator ==(ent arg1, ent arg2)
		{
			return arg1.id == arg2.id && arg1.age == arg2.age;
		}
		public static bool operator !=(ent arg1, ent arg2)
		{
			return !(arg1 == arg2);
		}

		//===============================//
		// Utils
		//===============================//

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Has<T>()
		{
			return (Entity.Generations[id, Storage<T>.Generation] & Storage<T>.ComponentMask) == Storage<T>.ComponentMask;
		}

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Has<T, Y>()
		{
			var mask  = Storage<T>.ComponentMask;
			var mask2 = Storage<Y>.ComponentMask;

			return (Entity.Generations[id, Storage<T>.Generation] & mask) == mask &&
			       (Entity.Generations[id, Storage<Y>.Generation] & mask2) == mask2;
		}

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Has<T, Y, U>()
		{
			var mask  = Storage<T>.ComponentMask;
			var mask2 = Storage<Y>.ComponentMask;
			var mask3 = Storage<U>.ComponentMask;

			return (Entity.Generations[id, Storage<T>.Generation] & mask) == mask &&
			       (Entity.Generations[id, Storage<Y>.Generation] & mask2) == mask2 &&
			       (Entity.Generations[id, Storage<U>.Generation] & mask3) == mask3;
		}


		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Has<T, Y, U, I>()
		{
			var mask  = Storage<T>.ComponentMask;
			var mask2 = Storage<Y>.ComponentMask;
			var mask3 = Storage<U>.ComponentMask;
			var mask4 = Storage<I>.ComponentMask;

			return (Entity.Generations[id, Storage<T>.Generation] & mask) == mask &&
			       (Entity.Generations[id, Storage<Y>.Generation] & mask2) == mask2 &&
			       (Entity.Generations[id, Storage<U>.Generation] & mask3) == mask3 &&
			       (Entity.Generations[id, Storage<I>.Generation] & mask4) == mask4;
		}


		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Has<T, Y, U, I, O>()
		{
			var mask  = Storage<T>.ComponentMask;
			var mask2 = Storage<Y>.ComponentMask;
			var mask3 = Storage<U>.ComponentMask;
			var mask4 = Storage<I>.ComponentMask;
			var mask5 = Storage<O>.ComponentMask;

			return (Entity.Generations[id, Storage<T>.Generation] & mask) == mask &&
			       (Entity.Generations[id, Storage<Y>.Generation] & mask2) == mask2 &&
			       (Entity.Generations[id, Storage<U>.Generation] & mask3) == mask3 &&
			       (Entity.Generations[id, Storage<I>.Generation] & mask4) == mask4 &&
			       (Entity.Generations[id, Storage<O>.Generation] & mask5) == mask5;
		}
		#if !ACTORS_COMPONENTS_STRUCTS
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
			return (arg0 = (Entity.Generations[id, Storage<T>.Generation] & Storage<T>.ComponentMask) == Storage<T>.ComponentMask ? Storage<T>.components[id] : default) != null;
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


		#endif
	}
}