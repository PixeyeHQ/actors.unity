//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	public static partial class HelperFramework
	{

		#region MATH


	 
		
		
		public static bool Every(this float step, float time)
		{
			if (step % time == 0)
			{
				return true;
			}

			return false;
		}

		public static bool Every(this int step, float time)
		{
			if (step % time == 0)
			{
				return true;
			}

			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool PlusCheck(ref this float arg0_pl, float val_pl, float clamp_pl = 1f)
		{
			arg0_pl = Math.Min(clamp_pl, arg0_pl + val_pl);
			return arg0_pl == clamp_pl;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool MinusCheck(ref this float arg0_mn, float val_mn, float clamp_mn = 0f)
		{
			arg0_mn = Math.Max(clamp_mn, arg0_mn - val_mn);
			return arg0_mn == clamp_mn;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool PlusCheck(ref this int arg0_pl, int val_pl, int clamp_pl = 1)
		{
			arg0_pl = Math.Min(clamp_pl, arg0_pl + val_pl);
			return arg0_pl == clamp_pl;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool MinusCheck(ref this int arg0_mn, int val_mn, int clamp_mn = 0)
		{
			arg0_mn = Math.Max(clamp_mn, arg0_mn - val_mn);
			return arg0_mn == clamp_mn;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Plus(ref this float arg0_pl, float val_pl, float clamp_pl = 1f)
		{
			arg0_pl = Math.Min(clamp_pl, arg0_pl + val_pl);
			;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Minus(ref this float arg0_mn, float val_mn, float clamp_mn = 0f)
		{
			arg0_mn = Math.Max(clamp_mn, arg0_mn - val_mn);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Plus(ref this int arg0_pl, int val_pl, int clamp_pl = 1)
		{
			arg0_pl = Math.Min(clamp_pl, arg0_pl + val_pl);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Minus(ref this int arg0_mn, int val_mn, int clamp_mn = 0)
		{
			arg0_mn = Math.Max(clamp_mn, arg0_mn - val_mn);
			;
		}

		#endregion

		#region BITS

		public static void BitOn(this ref int bitToTurnOn, int value)
		{
			bitToTurnOn |= value;
		}

		public static void BitOff(this ref int bitToTurnOff, int value)
		{
			bitToTurnOff &= ~value;
		}

		public static void BitFlip(this ref int bitToFlip, int value)
		{
			bitToFlip = value ^ bitToFlip;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool BitCheck(int bits, int value)
		{
			return (bits & value) == value;
		}

		#endregion

		#region SIGNALS

		/// <summary>
		/// <para>Send a signal to the Frameworks default Signal processor.</para>
		/// </summary>
		/// <param name="signal"></param>
		/// <typeparam name="T"></typeparam>
		public static void Send<T>(ref T signal) where T : struct
		{
			ProcessorSignals.Send(in signal);
		}

		#endregion

		#region ACTORS

		public static List<int> FindValidNodes(this List<PoolNode> list, int id)
		{
			var l = new List<int>();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].id == id)
					l.Add(i);
			}

			return l;
		}

		public static int FindValidNode(this List<PoolNode> list, int id, int pool)
		{
			for (int i = 0; i < list.Count; i++)
			{
				var l = list[i];
				if (l.id == id && l.pool == pool)
					return i;
			}

			return -1;
		}

		public static int FindInstanceID<T>(this List<T> list, T target) where T : UnityEngine.Object
		{
			int targetID = target.GetInstanceID();

			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].GetInstanceID() == targetID)
					return i;
			}

			return -1;
		}

		public static void Destroy(this GameObject obj)
		{
			GameObject.Destroy(obj);
		}

		public static void Destroy(this Transform tr)
		{
			GameObject.Destroy(tr.gameObject);
		}

		// /// <summary>
		// /// Must have actor component.
		// /// </summary>
		// /// <param name="e"></param>
		// public static void ForceDeploy(this in ent e)
		// {
		// 	Entity.Delayed.Set(e, 0, EntityOperations.Action.Activate);
		// }

		#endregion

		#region ARRAYS

		public static T[,] ResizeArray<T>(this T[,] original, in int rows, in int cols)
		{
			var newArray = new T[rows, cols];
			int minRows = Math.Min(rows, original.GetLength(0));
			int minCols = Math.Min(cols, original.GetLength(1));
			for (int i = 0; i < minRows; i++)
			for (int j = 0; j < minCols; j++)
				newArray[i, j] = original[i, j];
			return newArray;
		}

		public static void InsertCheck(this int[] a, int id, ref int length, ref int indexLast)
		{
			if (length == 0)
			{
				indexLast = 0;
				length++;
				return;
			}

			if (id > a[0])
			{
				length++;
				indexLast = 0;
			}
			else if (id < a[length - 1])
			{
				indexLast = length;
				length++;
			}
			else
			{
				if (id < a[indexLast])
				{
					length++;

					if (id > a[indexLast + 1])
					{
						indexLast = indexLast + 1;
					}
					else
					{
						int indexNext = indexLast;
						while (true)
						{
							if (id > a[indexNext])
							{
								indexLast = indexNext;

								break;
							}

							indexNext += 1;
						}
					}
				}
				else if (id > a[indexLast])
				{
					length++;

					if (id < a[indexLast - 1])
					{
					}
					else
					{
						int indexPrev = indexLast;
						while (true)
						{
							if (id < a[indexPrev])
							{
								indexLast = indexPrev + 1;
								break;
							}

							indexPrev -= 1;
						}
					}
				}
			}
		}

		public static void Insert<T>(ref T[] a, T val, int length, int indexLast)
		{
			Array.Copy(a, indexLast, a, indexLast + 1, length - indexLast - 1);
			a[indexLast] = val;
		}

		public static void Insert(this int[] a, ref int length, ref int idLast, ref int indexLast, int id)
		{
			if (id < a[0])
			{
				if (length == a.Length)
					Array.Resize(ref a, (length << 1) + 1);

				length++;
				Array.Copy(a, 0, a, 1, length - 1);
				a[0] = id;
				idLast = id;
				indexLast = 0;
			}
			else if (id > a[length - 1])
			{
				if (length == a.Length)
					Array.Resize(ref a, (length << 1) + 1);

				idLast = id;
				indexLast = length;
				a[length++] = id;
			}
			else
			{
				if (id > a[indexLast])
				{
					if (length == a.Length)
						Array.Resize(ref a, (length << 1) + 1);

					length++;

					if (id < a[indexLast + 1])
					{
						Array.Copy(a, indexLast + 1, a, indexLast + 2, length - indexLast - 1);
						idLast = id;
						indexLast = indexLast + 1;
						a[indexLast] = id;
					}
					else
					{
						int indexNext = indexLast + 2;
						while (true)
						{
							if (id < a[indexNext])
							{
								Array.Copy(a, indexNext, a, indexNext + 1, length - indexNext - 1);
								idLast = id;
								indexLast = indexNext;
								a[indexLast] = id;
								break;
							}

							indexNext += 1;
						}
					}
				}
				else if (id < a[indexLast])
				{
					if (length == a.Length)
						Array.Resize(ref a, (length << 1) + 1);

					length++;

					if (id > a[indexLast - 1])
					{
						Array.Copy(a, indexLast, a, indexLast + 1, length - indexLast - 1);
						idLast = id;
						indexLast = indexLast - 1;
						a[indexLast] = id;
					}
					else
					{
						int indexPrev = indexLast - 2;
						while (true)
						{
							if (id > a[indexPrev])
							{
								Array.Copy(a, indexPrev, a, indexPrev + 1, length - indexPrev - 1);
								idLast = id;
								indexLast = indexPrev;
								a[indexLast] = id;
								break;
							}

							indexPrev -= 1;
						}
					}
				}
			}
		}

		public static void Add<T>(this T[] a, T element, ref int length) where T : class
		{
			int index = 0;
			int len = a.Length;
			for (int i = 0; i < len; i++)
			{
				if (a[i] != null) index++;
				else break;
			}

			if (index >= len)
			{
				len = index << 1;
				Array.Resize(ref a, len);
			}

			a[length++] = element;
		}

		public static void Remove<T>(this T[] a, T element, ref int length) where T : class
		{
			for (int i = 0; i < length; i++)
			{
				if (a[i] != element) continue;
				--length;
				Array.Copy(a, i + 1, a, i, length - i);
				break;
			}
		}

		public static void InsertionSort(int[] array)
		{
			for (int i = 0; i < array.Length - 1; i++)
			{
				int j = i + 1;
				int tmp = array[j];
				while (j > 0 && tmp < array[j - 1])
				{
					array[j] = array[j - 1];
					j--;
				}

				array[j] = tmp;
			}
		}

		public static void Quicksort(int[] array, int left, int right)
		{
			while (true)
			{
				if (left < right)
				{
					int boundary = left;
					for (int i = left + 1; i < right; i++)
					{
						if (array[i] > array[left])
						{
							PerformSwap(i, ++boundary);
						}
					}

					PerformSwap(left, boundary);
					Quicksort(array, left, boundary);
					left = boundary + 1;
					continue;
				}

				break;
			}

			void PerformSwap(int l, int r)
			{
				int tmp = array[right];
				array[r] = array[l];
				array[l] = tmp;
			}
		}

		private static void Swap(int[] array, int left, int right)
		{
			int tmp = array[right];
			array[right] = array[left];
			array[left] = tmp;
		}

		public static int SearchLinear(this int[] array, int value)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == value)
					return i;
			}

			return -1;
		}

		public static int SearchBinary(this int[] array, int rightIndex, int value, int prev)
		{
			int leftIndex = 0;

			if (array[leftIndex] == value) return 0;
			if (array[rightIndex - 1] == value) return rightIndex - 1;

			while (true)
			{
				if (leftIndex == rightIndex && array[leftIndex] != value) return -1;
				int middleIndex = (rightIndex + leftIndex) / 2;

				if (array[middleIndex] == value) return middleIndex;
				if (middleIndex == prev) return -1;

				if (array[middleIndex] > value)
				{
					leftIndex = middleIndex + 1;
					prev = middleIndex;
					continue;
				}

				rightIndex = middleIndex - 1;
				prev = middleIndex;
			}
		}

		#endregion

		#region RANDOM

		public static int Select(this float[] vals)
		{
			var total = 0f;
			var probs = new float[vals.Length];

			for (int i = 0; i < probs.Length; i++)
			{
				probs[i] = vals[i];
				total += probs[i];
			}

			var randomPoint = (float) Rand.Source.NextDouble() * total;

			for (int i = 0; i < probs.Length; i++)
			{
				if (randomPoint < probs[i])
					return i;
				randomPoint -= probs[i];
			}

			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Between(this Vector2 v)
		{
			return Rand.Source.Next(2) > 0 ? v.x : v.y;
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Or(this float arg0, float arg1, float chance = 0.5f)
		{
			return Rand.Source.NextDouble() > chance ? arg0 : arg1;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Or(this int arg0, int arg1, float chance = 0.5f)
		{
			return Rand.Source.NextDouble() > chance ? arg0 : arg1;
		}


	 

		public static int Between(this object o, int a, int b, float chance = 0.5f)
		{
			return UnityEngine.Random.value > chance ? a : b;
		}

		public static float Between(this object o, float a, float b, float chance = 0.5f)
		{
			return UnityEngine.Random.value > chance ? a : b;
		}

		public static T RandomExcept<T>(this T[] list, T exceptVal)
		{
			var val = list[UnityEngine.Random.Range(0, list.Length)];

			while (val.Equals(exceptVal))
				val = list[UnityEngine.Random.Range(0, list.Length)];

			return val;
		}

		public static T RandomExcept<T>(this List<T> list, T exceptVal)
		{
			var val = list[UnityEngine.Random.Range(0, list.Count)];

			while (val.Equals(exceptVal))
				val = list[UnityEngine.Random.Range(0, list.Count)];

			return val;
		}

		public static T Random<T>(this List<T> list, T[] itemsToExclude)
		{
			var val = list[UnityEngine.Random.Range(0, list.Count)];

			while (itemsToExclude.Contains(val))
				val = list[UnityEngine.Random.Range(0, list.Count)];

			return val;
		}

		public static T Random<T>(this List<T> list)
		{
			var val = list[UnityEngine.Random.Range(0, list.Count)];
			return val;
		}

		public static T Select<T>(this List<T> vals) where T : IRandom
		{
			float total = 0f;

			var probs = new float[vals.Count];

			for (int i = 0; i < probs.Length; i++)
			{
				probs[i] = vals[i].returnChance;
				total += probs[i];
			}

			float randomPoint = (float) Rand.Source.NextDouble() * total;

			for (int i = 0; i < probs.Length; i++)
			{
				if (randomPoint < probs[i])
					return vals[i];
				randomPoint -= probs[i];
			}

			return vals[0];
		}

		public static T Select<T>(this T[] vals) where T : IRandom
		{
			var total = 0f;
			var probs = new float[vals.Length];

			for (int i = 0; i < probs.Length; i++)
			{
				probs[i] = vals[i].returnChance;
				total += probs[i];
			}

			var randomPoint = (float) Rand.Source.NextDouble() * total;

			for (int i = 0; i < probs.Length; i++)
			{
				if (randomPoint < probs[i])
					return vals[i];
				randomPoint -= probs[i];
			}

			return vals[0];
		}

		public static T Select<T>(this T[] vals, out int index) where T : IRandom
		{
			index = -1;

			if (vals == null || vals.Length == 0) return default(T);

			float total = 0f;

			float[] probs = new float[vals.Length];

			for (int i = 0; i < probs.Length; i++)
			{
				probs[i] = vals[i].returnChance;
				total += probs[i];
			}

			float randomPoint = (float) Rand.Source.NextDouble() * total;

			for (int i = 0; i < probs.Length; i++)
			{
				if (randomPoint < probs[i])
				{
					index = i;
					return vals[i];
				}

				randomPoint -= probs[i];
			}

			return vals[0];
		}

		public static T Random<T>(this T[] vals)
		{
			return vals[UnityEngine.Random.Range(0, vals.Length)];
		}

		public static T RandomDequeue<T>(this List<T> vals)
		{
			var index = UnityEngine.Random.Range(0, vals.Count);
			var val = vals[index];
			vals.RemoveAt(index);
			return val;
		}

		#endregion

		#region TRANSFORMS

		static FastString strPath = new FastString(256);

		public static string GetGameObjectPath(Transform transform)
		{
			string path = transform.name;
			if (transform.parent == null) return path;
			while (transform.parent.parent != null)
			{
				transform.GetSiblingIndex();
				transform = transform.parent;
				path = transform.name + "/" + path;
			}

			return path;
		}

		static internal string GetGameObjectPath(Transform transform, ref int[] sibligs)
		{
			string path = transform.name;
			if (transform.parent == null) return path;
			var sibls = new List<int>();
			var tr = transform;
			while (tr.parent != null)
			{
				sibls.Add(tr.GetSiblingIndex());
				tr = tr.parent;
			}

			sibls.Reverse();
			sibligs = sibls.ToArray();

			while (transform.parent.parent != null)
			{
				transform = transform.parent;
				path = transform.name + "/" + path;
			}

			return path;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Actor AddGetActor(this Transform co)
		{
			var c = co.GetComponent<Actor>();
			if (c == null)
				c = co.gameObject.AddComponent<Actor>();
			return c;
		}

		public static T AddGet<T>(this GameObject co) where T : Component
		{
			var c = co.GetComponent<T>();
			if (c == null)
				c = co.AddComponent<T>();

			return c;
		}

		public static T AddGet<T>(this Transform co) where T : Component
		{
			var c = co.GetComponent<T>();
			if (c == null)
				c = co.gameObject.AddComponent<T>();

			return c;
		}

		public static T Find<T>(this GameObject go, string path)
		{
			return go.transform.Find(path).GetComponent<T>();
		}

		public static Transform FindDeep(this Transform obj, string id)
		{
			if (obj.name == id)
			{
				return obj;
			}

			int count = obj.childCount;
			for (int i = 0; i < count; ++i)
			{
				var posObj = obj.GetChild(i).FindDeep(id);
				if (posObj != null)
				{
					return posObj;
				}
			}

			return null;
		}

		public static List<T> GetAll<T>(this Transform obj)
		{
			var results = new List<T>();
			obj.GetComponentsInChildren(results);
			return results;
		}

		#endregion

		#region EASE

//		public static float CalculateEase(float time, float duration, Ease ease)
//		{
//			var overshootOrAmplitude = 1.70158f;
//			switch (ease)
//			{
//				case Ease.InSine:
//					return (float) (-Math.Cos(time / (double) duration * 1.57079637050629f) + 1.0);
//				case Ease.OutSine:
//					return (float) Math.Sin(time / (double) duration * 1.57079637050629);
//				case Ease.InBack:
//					return (float) ((time /= duration) * (double) time *
//					                ((overshootOrAmplitude + 1.0) * time - overshootOrAmplitude));
//				case Ease.OutBack:
//					return (float) ((time = (float) (time / (double) duration - 1.0)) * (double) time *
//					                ((overshootOrAmplitude + 1.0) * time + overshootOrAmplitude) + 1.0);
//				case Ease.InOutBack:
//					if ((time /= duration * 0.5f) < 1.0)
//						return (float) (0.5 * (time * (double) time *
//						                       (((overshootOrAmplitude *= 1.525f) + 1.0) * time - overshootOrAmplitude)));
//					return (float) (0.5 * ((time -= 2f) * (double) time *
//					                       (((overshootOrAmplitude *= 1.525f) + 1.0) * time + overshootOrAmplitude) + 2.0));
//				case Ease.InCirc:
//					return (float) -(Math.Sqrt(1.0 - (time /= duration) * (double) time) - 1.0);
//				case Ease.OutCirc:
//					return (float) Math.Sqrt(1.0 - (time = (float) (time / (double) duration - 1.0)) * (double) time);
//				default:
//					return time / duration;
//			}
//		}

		#endregion

		#region MISC

		public static string GetPathLibrary()
		{
			var path = Application.dataPath;
			path = String.Format($"{path.Remove(path.LastIndexOf("/"))}/Library/PackageCache");
			var dir = Directory.GetDirectories(path).Where(s => s.Contains("com.pixeye.ecs")).ToArray();

			return dir.Length == 0 ? string.Empty : dir[0];
		}

		#endregion

	}
}