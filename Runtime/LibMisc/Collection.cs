//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.DivideByZeroChecks | Option.ArrayBoundsChecks, false)]
	public sealed class Collection<T> : IBind
	{

		private const int Capacity = 24;

		public T[] container = new T[Capacity];
		public int length;

		public Func<T> Creator;

		public ref T this[int index]
		{
			get => ref container[index];
		}

		public void SetCapacity(int val)
		{
			container = new T[val];
		}

		public Collection(Func<T> Creator)
		{
			this.Creator = Creator;
		}

		public Collection()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Add()
		{
			if (length == container.Length)
			{
				Array.Resize(ref container, length << 2);
			}

			return container[length++] = Creator();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Add(T val)
		{
			if (length == container.Length)
			{
				Array.Resize(ref container, length << 2);
			}

			container[length++] = val;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void RemoveAt(int index)
		{
			for (int i = index; i < length - 1; ++i)
				SetElement(i, container[i + 1]);

			length--;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetElement(int index, T arg)
		{
			container[index] = arg;
		}

	}
}