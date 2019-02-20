/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       12/09/2017 16:10
================================================================*/


using System.Collections.Generic;
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


		[FoldoutGroup("Setup")] public List<FactoryBase> factories;
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
		public void CheckNodes() { nodes.RemoveAll(n => n.prefab == null); }

		public int AddToNode(GameObject prefab, GameObject instance, int pool)
		{
			var id = prefab.GetInstanceID();
		 
			var node = nodes.Find(n => n.id == id);
			if (node == null)
			{
				node = new PoolNode();
				node.id = id;
				node.prefab = prefab;
				node.pool = pool;
				node.createdObjs = new List<GameObject>();
				node.createdObjs.Add(instance.gameObject);
				nodes.Add(node);
			}
			else
			{
				node.createdObjs.Add(instance.gameObject);
			}

			return id;
		}

		public void RemoveFromNode(int id, GameObject instance)
		{
			var node = nodes.Find(n => n.id == id);
			if (node == null)
			{
			}
			else
			{
				node.createdObjs.Remove(instance);
			}
		}
		#endif

		public void BindScene()
		{
			for (int i = 0; i < nodes.Count; i++)
			{
				nodes[i].Populate();
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