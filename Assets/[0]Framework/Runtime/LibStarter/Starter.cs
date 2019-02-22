/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       12/09/2017 16:10
================================================================*/


using System.Collections.Generic;
using System.Linq;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;

#endif


namespace Homebrew
{
// Start any game  

	public class Starter : MonoBehaviour
	{
		public static bool initialized;


		[FoldoutGroup("Setup")] public List<Factory> factories;
		[FoldoutGroup("Setup")] public List<SceneField> ScenesToKeep;
		[FoldoutGroup("Setup")] public List<SceneField> SceneDependsOn;

		[FoldoutGroup("Actors Pool Cache")]
		public List<PoolNode> nodes = new List<PoolNode>();

		void Awake()
		{
			ProcessingScene.Dynamic = GameObject.Find("Dynamic").transform;

			if (ProcessingUpdate.Default == null)
			{
				ProcessingUpdate.Create();
			}

			if (ProcessingSceneLoad.Default == null)
				ProcessingSceneLoad.Default = Toolbox.Create<ProcessingSceneLoad>();

			ProcessingSceneLoad.Default.Setup(ScenesToKeep, SceneDependsOn, this);
		}

		#if UNITY_EDITOR

		public void ClearNodes()
		{
			for (int i = 0; i < nodes.Count; i++)
			{
				var n = nodes[i];
				n.createdObjs.Clear();
				n.prefab = null;
			}

			nodes.Clear();
		}


		public void AddToNode(GameObject prefab, GameObject instance, int pool)
		{
			var       id                  = prefab.GetInstanceID();
			var       nodesValid          = nodes.FindValidNodes(id);
			var       conditionNodeCreate = true;
			List<int> nodesToKill         = new List<int>();


			for (int i = 0; i < nodesValid.Count; i++)
			{
				var node = nodes[nodesValid[i]];

				var index = node.createdObjs.FindInstanceID(instance);
				if (index != -1 && pool != node.pool)
				{
					node.createdObjs.RemoveAt(index);
				}
				else if (index == -1 && pool == node.pool)
				{
					conditionNodeCreate = false;
					node.createdObjs.Add(instance);
				}

				if (index != -1 && pool == node.pool)
				{
					conditionNodeCreate = false;
				}


				if (node.createdObjs.Count == 0)
				{
					node.prefab = null;
					nodesToKill.Add(nodesValid[i]);
				}
			}

			for (int i = 0; i < nodesToKill.Count; i++)
			{
				nodes.RemoveAt(nodesToKill[i]);
			}

			if (conditionNodeCreate)
			{
				var node = new PoolNode();
				node.id = id;
				node.prefab = prefab;
				node.pool = pool;
				node.createdObjs = new List<GameObject>();
				node.createdObjs.Add(instance);
				nodes.Add(node);
			}
		}

		public void RemoveFromNode(GameObject instance, int pool)
		{
			GameObject prefab;
			#if UNITY_2018_3_OR_NEWER
			prefab = PrefabUtility.GetCorrespondingObjectFromSource(instance);
			#else
			prefab = PrefabUtility.GetPrefabObject(instance);
		    #endif

			if (prefab == null) return;
			var id    = prefab.GetInstanceID();
			var index = nodes.FindValidNode(id, pool);
			if (index != -1)
			{
				var n = nodes[index];

				n.createdObjs.Remove(instance);
				if (n.createdObjs.Count == 0)
				{
					n.prefab = null;
					nodes.RemoveAt(index);
				}
			}
		}


		#endif

		public void BindScene()
		{
			for (int i = 0; i < nodes.Count; i++)
			{
				nodes[i].Populate();
			}

			foreach (var factory in factories)
			{
				Toolbox.Add(factory);
			}

			Setup();

			initialized = true;

			var objs = FindObjectsOfType<MonoBehaviour>();

			for (var i = 0; i < objs.Length; i++)
			{
				var obj  = objs[i];
				var ireq = obj as IRequireStarter;
				if (ireq != null)
				{
					ireq.SetupAfterStarter();
				}
			}


			Timer.Add(Time.deltaFixed * 2, () =>
			{
				PostSetup();
				Add<ProcessingRelease>();
			});
		}

		protected static T Add<T>() where T : new() { return Toolbox.Add<T>(); }


		protected virtual void Setup() { }

		protected virtual void PostSetup() { }

		protected virtual void OnDestroy() { initialized = false; }
	}
}