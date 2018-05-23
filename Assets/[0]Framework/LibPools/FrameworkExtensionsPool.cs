/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/23/2018 12:33 PM
================================================================*/


using UnityEngine;

namespace Homebrew
{
	public static partial class FrameworkExtensions
	{
		#region CREATE

		public static Transform Populate(this object o, Pool poolID, GameObject prefab,
			Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion), Transform parent = null,
			WorldParenters parenters = WorldParenters.Level)
		{
			var parenter = parent ?? Toolbox.Get<ProcessingScene>().Get(parenters);

			var go = poolID == Pool.None
				? Object.Instantiate(prefab, startPosition, startRotation, parenter).transform
				: ProcessingGoPool.HandleSpawn(poolID, prefab, startPosition, startRotation, parenter).transform;
			go.position = startPosition;
			return go;
		}

		public static T Populate<T>(this Object o, Pool poolID, GameObject prefab, Vector3 startPosition = default(Vector3),
			Quaternion startRotation = default(Quaternion), Transform parent = null,
			WorldParenters parenters = WorldParenters.Level) where T : class
		{
			var tr = o.Populate(poolID, prefab, startPosition, startRotation, parent, parenters);
			return tr.GetComponent<T>();
		}

		public static Transform Populate(this object o, Pool poolID, string prefabID,
			Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion), Transform parent = null,
			WorldParenters parenters = WorldParenters.Level)
		{
			var parenter = parent ?? ProcessingScene.Default.Get(parenters);
			var prefab = ProcessingResources.GetPrefab<GameObject>(prefabID);

			var go = poolID == Pool.None
				? Object.Instantiate(prefab, startPosition, startRotation, parenter).transform
				: ProcessingGoPool.HandleSpawn(poolID, prefab, startPosition, startRotation, parenter).transform;
			go.localPosition = startPosition;
			go.position = startPosition;
			return go;
		}

		public static T Populate<T>(this object o, Pool poolID, string prefabID, Vector3 startPosition = default(Vector3),
			Quaternion startRotation = default(Quaternion), Transform parent = null,
			WorldParenters parenters = WorldParenters.Level) where T : class
		{
			var tr = o.Populate(poolID, prefabID, startPosition, startRotation, parent, parenters);
			return tr.GetComponent<T>();
		}

		public static T Populate<T>(this object o, Pool poolID, GameObject prefabID, string parentID,
			Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion)) where T : class
		{
			var parent = Toolbox.Get<ProcessingScene>().Get(parentID);
			var tr = o.Populate(poolID, prefabID, startPosition, startRotation, parent);

			return tr.GetComponent<T>();
		}

		public static T Populate<T>(this object o, Pool poolID, string prefabID, string parentID,
			Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion)) where T : class
		{
			var parent = Toolbox.Get<ProcessingScene>().Get(parentID);
			var tr = o.Populate(poolID, prefabID, startPosition, startRotation, parent);

			return tr.GetComponent<T>();
		}

		#endregion
	}
}