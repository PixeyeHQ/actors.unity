//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 10/16/2018

using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace Homebrew
{
	public abstract class ActorExtended : Actor
	{
		bool conditionSignals;

	 
		protected override void Awake()
		{
			#if UNITY_EDITOR
			if (!Application.isPlaying)
			{
				bool isPrefabInstance = PrefabUtility.GetCorrespondingObjectFromSource(gameObject) == null;
				if (isPrefabInstance) return;
				if (prefabID != -1) return;
				var starter = FindObjectOfType<Starter>();
				var o       = Resources.Load<GameObject>("Prefabs/" + gameObject.name);


				prefabID = starter.AddToNode(o, gameObject, pool);
				return;
			}
			#endif

			conditionSignals = ProcessingSignals.Check(this);
			conditionManualDeploy = this is IManualDeploy;
			
			ProcessingEntities.Create(this);

			var cObject = Add<ComponentObject>();
			cObject.transform = transform;
			Setup();
		}

		public override void OnEnable()
		{
			#if UNITY_EDITOR
			if (!Application.isPlaying)
			{
				return;
			}
			#endif

			if (Starter.initialized == false)
			if (conditionManualDeploy) return;
			
				ProcessingUpdate.Default.Add(this);

			if (conditionSignals)
				ProcessingSignals.Default.Add(this);
 
			ProcessingEntities.Default.CheckGroups(entity, true);
		}

		public override void OnDisable()
		{
			#if UNITY_EDITOR
			if (!Application.isPlaying)
			{
				return;
			}
			#endif

			if (conditionSignals)
				ProcessingSignals.Default.Remove(this);
			
		 
			
			ProcessingUpdate.Default.Remove(this);
			ProcessingEntities.Default.CheckGroups(entity, false);
		}
	}
}