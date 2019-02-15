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
        public static void Release(this GameObject o, int poolID = -1)
        {
            if (poolID == -1)
            {
                UnityEngine.GameObject.Destroy(o);
            }
            else ProcessingPool.Despawn(poolID, o);
        }

        #region CREATE

        #region POPULATE ACTOR
        public static int PopulateActor(this object o, Actor prefab, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion), bool manualDeploy = true, string group = null)
        {
            var parent = ProcessingScene.Dynamic;
            if (group != null)
            {
                Transform goParent = ProcessingScene.Default.Get(group);
                if (goParent == null)
                    goParent = new GameObject(group).transform;
                goParent.SetParent(parent);
                parent = goParent;
            }
            var go = Object.Instantiate(prefab, parent).transform;
            go.localPosition = startPosition;
            go.localRotation = startRotation;
            var actor = go.GetComponentInChildren<Actor>();
            actor?.Init(manualDeploy);
            return actor == null ? actor.entity : -1;
        }

        ///<summary>
        /// Создает объект из префаба по имени префаба. Если это актор, то вызывает
        /// инициализацию и возвращает сущность, иначе вернет -1
        ///</summary>
        public static int PopulateActor(this object o, int poolID, string prefabID,
                                 Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion),
                                 string parent = null, bool manualDeploy = true)
        {
            var parenter = ProcessingScene.Default.Get(parent);
            if (parenter == null && parent == null)
            {
                parenter = new GameObject(parent).transform;
                parenter.SetParent(ProcessingScene.Dynamic);
            }
            else parenter = ProcessingScene.Dynamic;
            var prefab = Box.GetPrefab<GameObject>(prefabID);

            var go = poolID == Pool.None
                    ? Object.Instantiate(prefab, parenter).transform
                    : ProcessingPool.pools[poolID].Spawn(prefab, parenter).transform;
            go.localPosition = startPosition;
            go.localRotation = startRotation;
            var actor = go.GetComponentInChildren<Actor>();
            actor?.Init(manualDeploy);
            return actor == null ? actor.entity : -1;
        }

        #endregion

        public static Transform Populate(this object o, GameObject prefab, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))

        {
            var go = Object.Instantiate(prefab, ProcessingScene.Dynamic).transform;
            go.localPosition = startPosition;
            go.localRotation = startRotation;
            return go;
        }

        public static T Populate<T>(this object o, GameObject prefab, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))

        {
            var go = Object.Instantiate(prefab, ProcessingScene.Dynamic).transform;
            go.localPosition = startPosition;
            go.localRotation = startRotation;
            return go.GetComponentInChildren<T>();
        }


        public static T Populate<T>(this object o, GameObject prefab, string name, Vector3 startPosition, Quaternion startRotation)

        {
            var go = Object.Instantiate(prefab, ProcessingScene.Dynamic).transform;
            go.name = name;
            go.localPosition = startPosition;
            go.localRotation = startRotation;
            return go.GetComponent<T>();
        }

        public static Transform Populate(this object o, string prefabID, Vector3 startPosition, Quaternion startRotation)

        {
            var prefab = Box.GetPrefab<GameObject>(prefabID);
            var go = Object.Instantiate(prefab, ProcessingScene.Dynamic).transform;
            go.localPosition = startPosition;
            go.localRotation = startRotation;
            return go;
        }

        public static T Populate<T>(this object o, string prefabID, Vector3 startPosition, Quaternion startRotation)

        {
            var prefab = Box.GetPrefab<GameObject>(prefabID);
            var go = Object.Instantiate(prefab, ProcessingScene.Dynamic).transform;
            go.localPosition = startPosition;
            go.localRotation = startRotation;
            return go.GetComponent<T>();
        }

        public static Transform Populate(this object o, int poolID, GameObject prefab, Vector3 startPosition, Quaternion startRotation)
        {
            var go = ProcessingPool.pools[poolID].Spawn(prefab, ProcessingScene.Dynamic).transform;
            go.localPosition = startPosition;
            go.localRotation = startRotation;
            return go;
        }

        public static Transform Populate(this object o, int poolID, string prefabID, Vector3 startPosition, Quaternion startRotation)
        {
            var prefab = Box.GetPrefab<GameObject>(prefabID);
            var go = ProcessingPool.pools[poolID].Spawn(prefab, ProcessingScene.Dynamic).transform;
            go.localPosition = startPosition;
            go.localRotation = startRotation;
            return go;
        }

        public static T Populate<T>(this object o, int poolID, string prefabID, Vector3 startPosition, Quaternion startRotation)
        {
            var prefab = Box.GetPrefab<GameObject>(prefabID);
            var go = ProcessingPool.pools[poolID].Spawn(prefab, ProcessingScene.Dynamic).transform;
            go.localPosition = startPosition;
            go.localRotation = startRotation;
            return go.GetComponent<T>();
        }


        public static Transform Populate(this int o, int poolID, GameObject prefab,
                                         Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion),
                                         Transform parent = null,
                                         WorldParenters parenters = WorldParenters.Level)
        {
            var parenter = parent ?? ProcessingScene.Default.Get(parenters);


            var go = poolID == Pool.None
                    ? Object.Instantiate(prefab, parenter).transform
                    : ProcessingPool.pools[poolID].Spawn(prefab, parenter).transform;
            go.localPosition = startPosition;
            go.localRotation = startRotation;
            return go;
        }

        public static Transform Populate(this object o, int poolID, GameObject prefab,
                                         Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion),
                                         Transform parent = null,
                                         WorldParenters parenters = WorldParenters.Level)
        {
            var parenter = parent ?? ProcessingScene.Default.Get(parenters);


            var go = poolID == Pool.None
                    ? Object.Instantiate(prefab, parenter).transform
                    : ProcessingPool.pools[poolID].Spawn(prefab, parenter).transform;
            go.localPosition = startPosition;
            go.localRotation = startRotation;
            return go;
        }

        public static T Populate<T>(this int o, int poolID, GameObject prefab,
                                    Vector3 startPosition = default(Vector3),
                                    Quaternion startRotation = default(Quaternion), Transform parent = null,
                                    WorldParenters parenters = WorldParenters.Level) where T : class
        {
            var tr = o.Populate(poolID, prefab, startPosition, startRotation, parent, parenters);
            return tr.GetComponent<T>();
        }

        public static T Populate<T>(this Object o, int poolID, GameObject prefab,
                                    Vector3 startPosition = default(Vector3),
                                    Quaternion startRotation = default(Quaternion), Transform parent = null,
                                    WorldParenters parenters = WorldParenters.Level) where T : class
        {
            var tr = o.Populate(poolID, prefab, startPosition, startRotation, parent, parenters);
            return tr.GetComponent<T>();
        }

        public static Transform Populate(this object o, int poolID, string prefabID,
                                         Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion),
                                         Transform parent = null,
                                         WorldParenters parenters = WorldParenters.Level)
        {
            var parenter = parent ?? ProcessingScene.Default.Get(parenters);
            var prefab = Box.GetPrefab<GameObject>(prefabID);

            var go = poolID == Pool.None
                    ? Object.Instantiate(prefab, parenter).transform
                    : ProcessingPool.pools[poolID].Spawn(prefab, parenter).transform;
            go.localPosition = startPosition;
            go.localRotation = startRotation;
            return go;
        }



        public static T Populate<T>(this int o, int poolID, string prefabID,
                                    Vector3 startPosition = default(Vector3),
                                    Quaternion startRotation = default(Quaternion), Transform parent = null,
                                    WorldParenters parenters = WorldParenters.Level) where T : class
        {
            var tr = o.Populate(poolID, prefabID, startPosition, startRotation, parent, parenters);
            return tr.GetComponentInChildren<T>();
        }


        public static T Populate<T>(this object o, int poolID, string prefabID,
                                    Vector3 startPosition = default(Vector3),
                                    Quaternion startRotation = default(Quaternion), Transform parent = null,
                                    WorldParenters parenters = WorldParenters.Level) where T : class
        {
            var tr = o.Populate(poolID, prefabID, startPosition, startRotation, parent, parenters);
            return tr.GetComponentInChildren<T>();
        }


        public static T Populate<T>(this object o, int poolID, GameObject prefabID, string parentID,
                                    Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion)) where T : class
        {
            var parent = ProcessingScene.Default.Get(parentID);
            var tr = o.Populate(poolID, prefabID, startPosition, startRotation, parent);

            return tr.GetComponent<T>();
        }

        public static T Populate<T>(this object o, int poolID, string prefabID, string parentID,
                                    Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion)) where T : class
        {
            var parent = ProcessingScene.Default.Get(parentID);
            var tr = o.Populate(poolID, prefabID, startPosition, startRotation, parent);

            return tr.GetComponent<T>();
        }

        #endregion

        #region BY HASH

        public static Transform Populate(this object o, int poolID, int prefabID,
                                         Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion),
                                         Transform parent = null,
                                         WorldParenters parenters = WorldParenters.Level)
        {
            var parenter = parent ?? ProcessingScene.Default.Get(parenters);
            var prefab = Box.GetPrefab<GameObject>(prefabID);

            var go = poolID == Pool.None
                    ? Object.Instantiate(prefab, parenter).transform
                    : ProcessingPool.pools[poolID].Spawn(prefab, parenter).transform;
            go.localPosition = startPosition;
            go.localRotation = startRotation;
            return go;
        }


        public static T Populate<T>(this object o, int poolID, int prefabID, Vector3 startPosition = default(Vector3),
                                    Quaternion startRotation = default(Quaternion), Transform parent = null,
                                    WorldParenters parenters = WorldParenters.Level) where T : class
        {
            var tr = o.Populate(poolID, prefabID, startPosition, startRotation, parent, parenters);
            return tr.GetComponentInChildren<T>();
        }


        public static T Populate<T>(this object o, int poolID, int prefabID, string parentID,
                                    Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion)) where T : class
        {
            var parent = Toolbox.Get<ProcessingScene>().Get(parentID);
            var tr = o.Populate(poolID, prefabID, startPosition, startRotation, parent);
            return tr.GetComponent<T>();
        }

        #endregion
    }
}