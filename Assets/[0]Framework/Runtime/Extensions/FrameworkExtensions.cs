/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       12/09/2017 23:42
================================================================*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Homebrew
{
	public static partial class FrameworkExtensions
	{
		static System.Random _r = new System.Random();

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

		public static float Plus(this float arg0, float val, float clamp = 1f) { return Math.Min(clamp, arg0 + val); }
		public static float Minus(this float arg0, float val, float clamp = 0f) { return Math.Max(clamp, arg0 - val); }
		public static int Plus(this int arg0, int val, int clamp = 1) { return Math.Min(clamp, arg0 + val); }
		public static int Minus(this int arg0, int val, int clamp = 0) { return Math.Max(clamp, arg0 - val); }


		#region SIGNALS

		public static void Send<T>(ref T signal) where T : struct { ProcessingSignals.Send(ref signal); }

		#endregion

		#region ENTITIES

		public static T Get<T>(this int entity) where T : IComponent, new() { return Storage<T>.Instance.TryGet(entity); }

		public static bool Get<T>(this int entity, out T arg0) where T : IComponent, new()
		{
			arg0 = default(T);
			return (arg0 = Storage<T>.Instance.TryGet(entity)) != null;
		}

		public static bool Get<T, Y>(this int entity, out T arg0, out Y arg1) where T : new() where Y : new()
		{
			arg0 = default(T);
			arg1 = default(Y);
			if ((arg0 = Storage<T>.Instance.TryGet(entity)) == null) return false;
			if ((arg1 = Storage<Y>.Instance.TryGet(entity)) == null) return false;


			return true;
		}

		public static bool Get<T, Y, U>(this int entity, out T arg0, out Y arg1, out U arg2) where T : new() where Y : new() where U : new()
		{
			arg0 = default(T);
			arg1 = default(Y);
			arg2 = default(U);
			if ((arg0 = Storage<T>.Instance.TryGet(entity)) == null) return false;
			if ((arg1 = Storage<Y>.Instance.TryGet(entity)) == null) return false;
			if ((arg2 = Storage<U>.Instance.TryGet(entity)) == null) return false;

			return true;
		}

		public static bool Get<T, Y, U, I>(this int entity, out T arg0, out Y arg1, out U arg2, out I arg3) where T : new() where Y : new() where U : new() where I : new()
		{
			arg0 = default(T);
			arg1 = default(Y);
			arg2 = default(U);
			arg3 = default(I);
			if ((arg0 = Storage<T>.Instance.TryGet(entity)) == null) return false;
			if ((arg1 = Storage<Y>.Instance.TryGet(entity)) == null) return false;
			if ((arg2 = Storage<U>.Instance.TryGet(entity)) == null) return false;
			if ((arg3 = Storage<I>.Instance.TryGet(entity)) == null) return false;
			return true;
		}

		public static bool Get<T, Y, U, I, O>(this int entity, out T arg0, out Y arg1, out U arg2, out I arg3, out O arg4) where T : new() where Y : new() where U : new() where I : new() where O : new()
		{
			arg0 = default(T);
			arg1 = default(Y);
			arg2 = default(U);
			arg3 = default(I);
			arg4 = default(O);
			if ((arg0 = Storage<T>.Instance.TryGet(entity)) == null) return false;
			if ((arg1 = Storage<Y>.Instance.TryGet(entity)) == null) return false;
			if ((arg2 = Storage<U>.Instance.TryGet(entity)) == null) return false;
			if ((arg3 = Storage<I>.Instance.TryGet(entity)) == null) return false;
			if ((arg4 = Storage<O>.Instance.TryGet(entity)) == null) return false;
			return true;
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

		public static void Release(this int entity)
		{
			var composer = new EntityComposer(entity, 1);
			composer.Add<ComponentRelease>();
			composer.Deploy();
		}


		public static void ReleaseFinal(this int entity, bool isActor)
		{
			if (isActor)
			{
				ProcessingEntities.storageActor[entity].Release();
				return;
			}

			int len = Storage.all.Count;
			for (int j = 0; j < len; j++)
			{
				Storage.all[j].Remove(entity, true);
			}

			Tags.Clear(entity);
			ProcessingEntities.prevID.Push(entity);
		}

		public static MonoEntity GetMonoEntity(this int entity) { return entity.ComponentObject().transform.GetComponent<MonoEntity>(); }

		public static GameObject GameObject(this int entity) { return entity.ComponentObject().transform.gameObject; }

		public static Transform Transform(this int entity) { return entity.ComponentObject().transform; }

		public static T Create<T>(this int entity) where T : IComponent, new() { return Storage<T>.Instance.GetOrCreate(entity); }

		public static T Get<T>(this ComponentObject component) { return component.transform.gameObject.GetComponent<T>(); }

		public static T Get<T>(this ComponentObject component, string path) { return component.transform.Find(path).GetComponent<T>(); }

		public static T Get<T>(this int entity, string path) { return entity.ComponentObject().transform.Find(path).GetComponent<T>(); }

		public static bool Has<T>(this int entity) where T : IComponent, new() { return Storage<T>.Instance.HasComponent(entity); }

		public static void Add<T>(this int entity, T component) where T : new() { Storage<T>.Instance.Add(component, entity); }

		public static T Add<T>(this int entity) where T : new() { return entity.CheckMonoConditions() ? Storage<T>.Instance.Add(entity) : Storage<T>.Instance.GetOrCreate(entity); }


		public static bool CheckMonoConditions(this int entity)
		{
			var storage = ProcessingEntities.storageActor;
			var mono    = storage.Length > entity ? storage[entity] : null;
			return mono != null ? mono.conditionEnabled : true;
		}

		public static void ForceDeploy(this Actor a)
		{
			a.conditionManualDeploy = false;
			a.conditionEnabled = true;
			ProcessingEntities.Default.CheckGroups(a.entity, true);
		}

		public static void Remove<T>(this Actor a) where T : new() { Storage<T>.Instance.Remove(a.entity, false); }

		public static void Remove<T>(this int entity) where T : new() { Storage<T>.Instance.Remove(entity, false); }

		public static void Remove(this int entity, Type t)
		{
			var storage = Storage.allDict[t.GetHashCode()];
			storage.Remove(entity, false);
		}

		public static T DeepClone<T>(this T obj)
		{
			using (var ms = new MemoryStream())
			{
				var formatter = new BinaryFormatter();
				formatter.Serialize(ms, obj);
				ms.Position = 0;

				return (T) formatter.Deserialize(ms);
			}
		}

		#endregion

		#region ARRAYS

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

		public static void Insert<T>(this T[] a, T val, int length, int indexLast)
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
			int len   = a.Length;
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
				int j   = i + 1;
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
							Swap(array, i, ++boundary);
						}
					}

					Swap(array, left, boundary);
					Quicksort(array, left, boundary);
					left = boundary + 1;
					continue;
				}

				break;
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

		public static float Between(this Vector2 v) { return UnityEngine.Random.value > 0.5f ? v.x : v.y; }


		public static int Between(this object o, int a, int b, float chance = 0.5f) { return UnityEngine.Random.value > chance ? a : b; }

		public static float Between(this object o, float a, float b, float chance = 0.5f) { return UnityEngine.Random.value > chance ? a : b; }

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


			float randomPoint = (float) _r.NextDouble() * total;


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


			var randomPoint = (float) _r.NextDouble() * total;


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


			float randomPoint = (float) _r.NextDouble() * total;


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

		public static T Random<T>(this T[] vals) { return vals[UnityEngine.Random.Range(0, vals.Length)]; }

		public static T RandomDequeue<T>(this List<T> vals)
		{
			var index = UnityEngine.Random.Range(0, vals.Count);
			var val   = vals[index];
			vals.RemoveAt(index);
			return val;
		}

		#endregion

		#region TRANSFORMS

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

		public static T Find<T>(this GameObject go, string path) { return go.transform.Find(path).GetComponent<T>(); }

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
	}
}