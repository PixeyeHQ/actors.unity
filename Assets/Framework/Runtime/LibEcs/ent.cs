//  Project : ecs
// Contacts : Pix - info@pixeye.games
//     Date : 3/16/2019 

using System;

namespace Pixeye
{
	public readonly struct ent : IComparable
	{
		public readonly int id;
		readonly int hash;

		public ent(int id = -1, int hash = -1)
		{
			this.id = id;
			this.hash = hash;
		}

		static public implicit operator int(ent value)
		{
			return value.id;
		}

		static public implicit operator ent(int value)
		{
			return new ent(value);
		}


		public static ent operator +(ent a, int b)
		{
			return new ent(a.id + b, a.hash);
		}

		public static ent operator -(ent a, int b)
		{
			return new ent(a.id - b, a.hash);
		}


		public int CompareTo(object value)
		{
			if (value == null)
				return 1;
			if (!(value is int)) { }

			int num = (int) value;
			if (id < num)
				return -1;
			return id > num ? 1 : 0;
		}

		public int CompareTo(int value)
		{
			if (id < value)
				return -1;
			return id > value ? 1 : 0;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is int))
				return false;
			return id == (int) obj;
		}

		public bool Equals(int obj)
		{
			return id == obj;
		}

		public override int GetHashCode()
		{
			return hash;
		}

		public bool Has<T>() where T : new()
		{
			return RefEntity.generations[id, Storage<T>.generation].BitCheck(Storage<T>.id);
		}

		public void Release()
		{
			var composer = new EntityComposer(id, 1);
			composer.Add<ComponentRelease>();
			composer.Deploy();
		}

		public bool Exist()
		{
			return id > -1 && RefEntity.isAlive[id] && RefEntity.transforms[id].GetHashCode() == hash;
		}

		#region GET

		/// <summary>
		/// <para>Safely gets the component by type from the entity.</para>
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="arg0"></param>
		/// <typeparam name="T"></typeparam>
		/// <returns>Returns true if the entity has this component.</returns>
		public bool Get<T>(out T arg0) where T : IComponent, new()
		{
			arg0 = default;
			return (arg0 = Storage<T>.Instance.TryGet(id)) != null;
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
		public bool Get<T, Y>(out T arg0, out Y arg1) where T : new() where Y : new()
		{
			arg0 = default;
			arg1 = default;
			if ((arg0 = Storage<T>.Instance.TryGet(id)) == null) return false;
			if ((arg1 = Storage<Y>.Instance.TryGet(id)) == null) return false;


			return true;
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
		public bool Get<T, Y, U>(out T arg0, out Y arg1, out U arg2) where T : new() where Y : new() where U : new()
		{
			arg0 = default;
			arg1 = default;
			arg2 = default;
			if ((arg0 = Storage<T>.Instance.TryGet(id)) == null) return false;
			if ((arg1 = Storage<Y>.Instance.TryGet(id)) == null) return false;
			if ((arg2 = Storage<U>.Instance.TryGet(id)) == null) return false;

			return true;
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
		public bool Get<T, Y, U, I>(out T arg0, out Y arg1, out U arg2, out I arg3) where T : new() where Y : new() where U : new() where I : new()
		{
			arg0 = default;
			arg1 = default;
			arg2 = default;
			arg3 = default;
			if ((arg0 = Storage<T>.Instance.TryGet(id)) == null) return false;
			if ((arg1 = Storage<Y>.Instance.TryGet(id)) == null) return false;
			if ((arg2 = Storage<U>.Instance.TryGet(id)) == null) return false;
			if ((arg3 = Storage<I>.Instance.TryGet(id)) == null) return false;
			return true;
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
		public bool Get<T, Y, U, I, O>(out T arg0, out Y arg1, out U arg2, out I arg3, out O arg4) where T : new() where Y : new() where U : new() where I : new() where O : new()
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
			if ((arg4 = Storage<O>.Instance.TryGet(id)) == null) return false;
			return true;
		}

		#endregion

		#region ADD

		public void AddNoCheck<T>(T component) where T : new()
		{
			Storage<T>.Instance.AddNoCheck(component, this);
		}

		public T AddNoCheck<T>() where T : new()
		{
			return Storage<T>.Instance.AddNoCheck(this);
		}

		public void Add<T>(T component) where T : new()
		{
			Storage<T>.Instance.Add(component, this);
		}

		public T Add<T>() where T : new()
		{
			return Storage<T>.Instance.Add(this);
		}

		#endregion
	}
}