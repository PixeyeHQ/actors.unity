/*===============================================================
Product:    Unity3dTools
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       4/27/2018 7:58 PM
================================================================*/

using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
	public static partial class FrameworkExtensions
	{
		private static System.Random _r = new System.Random();

		public static void SetAlpha(this SpriteRenderer r, float alpha)
		{
			var c = r.color;
			r.color = new Color(c.r, c.g, c.b, alpha);
		}

		public static Color SetAlpha(this Color c, float alpha)
		{
			return new Color(c.r, c.g, c.b, alpha);
		}

		public static Vector3 AppendZ(this Transform obj, float zVal = 0.0f)
		{
			var pos = new Vector3(obj.position.x, obj.position.y, zVal);
			obj.position = pos;
			return pos;
		}

		public static Vector3 AppendZ(this Vector3 obj, float zVal = 0.0f)
		{
			return new Vector3(obj.x, obj.y, zVal);
		}


		public static T Random<T>(this List<T> list)
		{
			var val = list[UnityEngine.Random.Range(0, list.Count)];
			return val;
		}

		public static T RandomByChance<T>(this List<T> vals) where T : IRandom
		{
			var total = 0f;

			var probs = new float[vals.Count];


			for (var i = 0; i < probs.Length; i++)
			{
				probs[i] = vals[i].returnChance;
				total += probs[i];
			}


			var randomPoint = (float) _r.NextDouble() * total;


			for (var i = 0; i < probs.Length; i++)
			{
				if (randomPoint < probs[i])
					return vals[i];
				randomPoint -= probs[i];
			}

			return vals[0];
		}


		public static int ReturnNearestIndex(this Vector3[] nodes, Vector3 destination)
		{
			var nearestDistance = -Mathf.Infinity;
			var index = 0;
			var length = nodes.Length;
			for (var i = 0; i < length; i++)
			{
				var distanceToNode = (destination + nodes[i]).sqrMagnitude;
				if (!(nearestDistance > distanceToNode)) continue;
				nearestDistance = distanceToNode;
				index = i;
			}

			return index;
		}

		public static Vector3 ReturnNearestPosition(this Transform[] nodes, Vector3 destination)
		{
			var nearestDistance = -Mathf.Infinity;
			var index = 0;
			var length = nodes.Length;
			
			for (var i = 0; i < length; i++)
			{
				var distanceToNode = (destination + nodes[i].position).sqrMagnitude;
				if (nearestDistance > distanceToNode) continue;
				nearestDistance = distanceToNode;
				index = i;
			}
			return nodes[index].position;
		}

		public static Vector3 Center(this Transform[] points)
		{
			Vector3 finalPos = Vector3.zero;
			for (var i = 0; i < points.Length; i++)
			{
				finalPos += points[i].position;
			}

			finalPos /= points.Length;
			return finalPos;
		}


		public static Transform FindDeep(this Transform root, string id)
		{
			if (root.name == id)
			{
				return root;
			}

			Transform final = root.Find(id);

			if (final != null) return final;

			var count = root.childCount;
			for (var i = 0; i < count; ++i)
			{
				var posObj = root.GetChild(i).FindDeep(id);
				if (posObj != null)
				{
					return posObj;
				}
			}

			return null;
		}

		public static bool IsInLayerMask(this GameObject gameObject, LayerMask mask)
		{
			return (mask.value & (1 << gameObject.layer)) > 0;
		}


		public static void SetLayer(this GameObject root, int layer)
		{
			SetLayerInternal(root.transform, layer);
		}

		private static void SetLayerInternal(Transform root, int layer)
		{
			root.gameObject.layer = layer;
			var count = root.childCount;
			for (var i = 0; i < count; ++i)
			{
				SetLayerInternal(root.GetChild(i), layer);
			}
		}
	}
}