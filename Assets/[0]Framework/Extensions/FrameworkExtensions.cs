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
        private static System.Random _r = new System.Random();


        public static T Add<T>(this int entity) where T : new()
        {
            return Storage<T>.Instance.AddVirtual(entity);
        }


        public static void Add<T>(this MonoCached mono) where T : class, new()
        {
            mono.actorParent.Add<T>();
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


        #region 2dRaycasts

        public static Actor GetActor(this RaycastHit2D hit, params int[] tags)
        {
            var actor = hit.collider.GetComponentInParent<Actor>();
            if (actor == null) return null;
            return actor.TagsHave(tags) ? actor : null;
        }

        #endregion


        #region ARRAYS

// public static void InsertCheck(this int[] a, int id,  ref int length, ref int indexLast)
//        {
//            if (length == 0)
//            {
//                indexLast = 0;
//                length++;
//                return;
//            }
//            
//            if (id > a[0])
//            {
//                length++;
//                indexLast = 0;
//            }
//            else if (id < a[length - 1])
//            {
//                indexLast = length;
//                length++;
//            }
//            else
//            {
//           
//           
//                if (id < a[indexLast])
//                {
//                    length++;
//
//                    if (id > a[indexLast + 1])
//                    {
//                        indexLast = indexLast + 1;
//                  
//                    }
//                    else
//                    {
//                        int indexNext = indexLast;
//                        while (true)
//                        {
//                            if (id > a[indexNext])
//                            {
//                                indexLast = indexNext;
//                        
//                                break;
//                            }
//
//                            indexNext += 1;
//                        }
//                    }
//                }
//                else if (id > a[indexLast])
//                {
//                    
//                    length++;
//                    
//                    if (id< a[indexLast - 1])
//                    {
//                
//                    }
//                    else
//                    {
//                        int indexPrev = indexLast;
//                        while (true)
//                        {
//                            if (id < a[indexPrev])
//                            {
//                          
//                                indexLast = indexPrev+1;
//                                break;
//                            }
//
//                            indexPrev -= 1;
//                        }
//                    }
//                }
//            }
//        }
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
                length--;
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

        public static int Between(this object o, int a, int b, float chance = 0.5f)
        {
            return UnityEngine.Random.value > chance ? a : b;
        }

        public static float Between(this object o, float a, float b, float chance = 0.5f)
        {
            return UnityEngine.Random.value > chance ? a : b;
        }


        public static int ReturnNearestIndex(this Vector3[] nodes, Vector3 destination)
        {
            float nearestDistance = Mathf.Infinity;
            int index = 0;
            int length = nodes.Length;
            for (int i = 0; i < length; i++)
            {
                float distanceToNode = (destination + nodes[i]).sqrMagnitude;
                if (!(nearestDistance > distanceToNode)) continue;
                nearestDistance = distanceToNode;
                index = i;
            }

            return index;
        }

        public static T ReturnRandom<T>(this List<T> list, T[] itemsToExclude)
        {
            var val = list[UnityEngine.Random.Range(0, list.Count)];

            while (itemsToExclude.Contains(val))
                val = list[UnityEngine.Random.Range(0, list.Count)];

            return val;
        }

        public static T ReturnRandom<T>(this List<T> list)
        {
            var val = list[UnityEngine.Random.Range(0, list.Count)];
            return val;
        }

        public static T GetRandom<T>(this List<T> vals) where T : IRandom
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

        public static T GetRandom<T>(this T[] vals) where T : IRandom
        {
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
                    return vals[i];
                else randomPoint -= probs[i];
            }

            return vals[0];
        }

        public static float GetRandomArg(this float[] vals)
        {
            if (vals == null || vals.Length == 0) return -1;


            float total = 0f;

            var probs = new float[vals.Length];


            for (int i = 0; i < probs.Length; i++)
            {
                probs[i] = vals[i];
                total += probs[i];
            }


            var randomPoint = (float) _r.NextDouble() * total;


            for (int i = 0; i < probs.Length; i++)
            {
                if (randomPoint < probs[i])
                    return probs[i];
                randomPoint -= probs[i];
            }

            return 0;
        }


        public static int GetRandom(this float[] vals)
        {
            if (vals == null || vals.Length == 0) return -1;


            float total = 0f;

            var probs = new float[vals.Length];


            for (int i = 0; i < probs.Length; i++)
            {
                probs[i] = vals[i];
                total += probs[i];
            }


            float randomPoint = (float) _r.NextDouble() * total;


            for (int i = 0; i < probs.Length; i++)
            {
                if (randomPoint < probs[i])
                    return i;
                randomPoint -= probs[i];
            }

            return 0;
        }

        public static T Random<T>(this T[] vals)
        {
            return vals[UnityEngine.Random.Range(0, vals.Length)];
        }

        public static T RandomList<T>(this List<T> vals)
        {
            return vals[UnityEngine.Random.Range(0, vals.Count)];
        }

        public static T RandomWithRemove<T>(this List<T> vals)
        {
            int index = UnityEngine.Random.Range(0, vals.Count);
            var val = vals[index];
            vals.RemoveAt(index);
            return val;
        }


        public static T GetRandom<T>(this T[] vals, out int index) where T : IRandom
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

        public static T GetRandom<T>(this T[] vals, float[] probs) where T : IRandom
        {
            if (vals == null || vals.Length == 0) return default(T);


            float total = probs.Sum();


            float randomPoint = (float) _r.NextDouble() * total;


            for (int i = 0; i < probs.Length; i++)
            {
                if (randomPoint < probs[i])
                    return vals[i];
                randomPoint -= probs[i];
            }

            return vals[0];
        }


        public static float GetRandom(this Vector2 v)
        {
            return UnityEngine.Random.Range(v.x, v.y);
        }

        public static float GetRandomChoice(this Vector2 v)
        {
            return UnityEngine.Random.value >= 0.5f ? v.x : v.y;
        }


        public static Vector3 MixRandom(this Vector3 me, Vector3 v1, Vector3 v2)
        {
            var v = new Vector3(
                UnityEngine.Random.Range(v1.x, v2.x),
                UnityEngine.Random.Range(v1.y, v2.y),
                UnityEngine.Random.Range(v1.z, v2.z)
            );
            return v;
        }

        #endregion


        #region TRANSFORMS

        public static float ClampAngle(this float angle, float min, float max)
        {
            if (min < 0 && max > 0 && (angle > max || angle < min))
            {
                angle -= 360;
                if (angle > max || angle < min)
                {
                    return Mathf.Abs(Mathf.DeltaAngle(angle, min)) < Mathf.Abs(Mathf.DeltaAngle(angle, max))
                        ? min
                        : max;
                }
            }
            else if (min > 0 && (angle > max || angle < min))
            {
                angle += 360;
                if (angle > max || angle < min)
                {
                    return Mathf.Abs(Mathf.DeltaAngle(angle, min)) < Mathf.Abs(Mathf.DeltaAngle(angle, max))
                        ? min
                        : max;
                }
            }

            if (angle < min) return min;
            else if (angle > max)
                return max;
            else
                return angle;
        }

        public static Vector3 MultiplyX(this Vector3 v, float val)
        {
            v = new Vector3(val * v.x, v.y, v.z);
            return v;
        }

        public static Vector3 MultiplyY(this Vector3 v, float val)
        {
            v = new Vector3(v.x, val * v.y, v.z);
            return v;
        }

        public static Vector3 MultiplyZ(this Vector3 v, float val)
        {
            v = new Vector3(v.x, v.y, val * v.z);
            return v;
        }


        public static Transform[] GetChildTransfroms(this Transform t)
        {
            int size = t.childCount;
            var array = new Transform[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = t.GetChild(i);
            }

            return array;
        }

        public static Vector3[] GetChildTransfromsPos(this Transform t)
        {
            int size = t.childCount;
            var array = new Vector3[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = t.GetChild(i).position;
            }

            return array;
        }


        public static Vector3 AppendZ(this Transform obj, float zVal = 0.0f)
        {
            return new Vector3(obj.position.x, obj.position.y, zVal);
        }

        public static Vector3 AppendZ(this Vector3 obj, float zVal = 0.0f)
        {
            return new Vector3(obj.x, obj.y, zVal);
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

        #region COLORS

        public static Color SetColorAlpha(this Color c, float alpha)
        {
            return new Color(c.r, c.g, c.b, alpha);
        }

        #endregion
    }
}