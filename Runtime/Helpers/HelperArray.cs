//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public static class HelperArray
	{
		public static void ResizeInt(ref int[,] original, int newLength, int cols)
		{
			var newArray = new int[newLength, cols];
			int minRows  = Math.Min(newLength, original.GetLength(0));
			int minCols  = Math.Min(cols, original.GetLength(1));
			for (int i = 0; i < minRows; i++)
			for (int j = 0; j < minCols; j++)
				newArray[i, j] = original[i, j];
			original = newArray;
		}

		public static void Resize<T>(ref T[,] original, int newLength, int cols)
		{
			var newArray = new T[newLength, cols];
			int minRows  = Math.Min(newLength, original.GetLength(0));
			int minCols  = Math.Min(cols, original.GetLength(1));
			for (int i = 0; i < minRows; i++)
			for (int j = 0; j < minCols; j++)
				newArray[i, j] = original[i, j];
			original = newArray;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ResizeTags<Tag>(ref Tag[][] original, int newLength)
		{
			var newArray = new Tag[newLength][];

			var min = Math.Min(newLength, original.GetLength(0));

			for (int i = 0; i < min; i++)
				newArray[i] = original[i];

			original = newArray;
		}

		public static void Resize<T>(ref T[][] original, int newLength)
		{
			var newArray = new T[newLength][];

			var min = Math.Min(newLength, original.GetLength(0));

			for (int i = 0; i < min; i++)
				newArray[i] = original[i];

			original = newArray;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int BinarySearch(ref int[] entries, int value, int left, int right)
		{
			while (left <= right)
			{
				var m = (left + right) / 2;
				if (entries[m] == value) return m;
				if (entries[m] < value) left = m + 1;
				else right                   = m - 1;
			}

			return -1;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int BinarySearch(ent* entries, int value, int left, int right)
		{
			while (left <= right)
			{
				var m = (left + right) / 2;
				if (entries[m].id == value) return m;
				if (entries[m].id < value) left = m + 1;
				else right                      = m - 1;
			}

			return -1;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int BinarySearch(ref ent[] entries, int value, int left, int right)
		{
			while (left <= right)
			{
				var m = (left + right) / 2;
				if (entries[m].id == value) return m;
				if (entries[m].id < value) left = m + 1;
				else right                      = m - 1;
			}

			return -1;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FindIndex<T>(this T[] array, Predicate<T> predicate)
		{
			return Array.FindIndex(array, predicate);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FindIndexFast<T>(this T[] array, Predicate<T> predicate)
		{
			for (int i = 0; i < array.Length; i++)
			{
				ref var val = ref array[i];
				if (predicate(val)) return i;
			}

			return -1;
		}


		internal class ArrayTraverse
		{
			public int[] Position;
			int[] maxLengths;

			public ArrayTraverse(Array array)
			{
				maxLengths = new int[array.Rank];
				for (int i = 0; i < array.Rank; ++i)
				{
					maxLengths[i] = array.GetLength(i) - 1;
				}

				Position = new int[array.Rank];
			}

			public bool Step()
			{
				for (int i = 0; i < Position.Length; ++i)
				{
					if (Position[i] >= maxLengths[i]) continue;

					Position[i]++;
					for (int j = 0; j < i; j++)
					{
						Position[j] = 0;
					}

					return true;
				}

				return false;
			}
		}
	}
}