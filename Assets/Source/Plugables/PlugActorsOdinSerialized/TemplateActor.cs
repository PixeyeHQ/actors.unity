//   Project : Actors
//  Contacts : Pixeye - ask@pixeye.games 

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
using UnityEngine;

namespace Pixeye
{
	public delegate void State(int entity);

	public delegate void StateTick(int entity, float delta);

	[CreateAssetMenu(fileName = "Template Actor", menuName = "Actors/Templates/Actor")]
	public class TemplateActor : SerializedScriptableObject
	{
		public GameObject model;
		public bool manualDeploy;
    public bool autoReference;
		public IComponentClone[] components = new IComponentClone[0];

		[TagFilter(typeof(Tag))]
		public int[] tags = new int[0];

		public State[] actions = new State[0];

		public Transform Spawn()
		{
			var transform = this.Populate(model);
			var cMono     = transform.AddGet<MonoEntity>();

			EntityComposer entityComposer = new EntityComposer(1 + components.Length);
			cMono.entity = entityComposer.entity;

			var _cObject = entityComposer.Add<ComponentObject>();

			_cObject.transform = transform;
			_cObject.poolType = -1;


			for (int i = 0; i < components.Length; i++)
			{
				components[i].AsClone(ref entityComposer);
			}

			entityComposer.Deploy(tags);
			
			foreach (var action in actions)
			{
				action(entityComposer.entity);
			}
			
			return transform;
		}

		public void Add(Actor actor)
		{
			actor.conditionManualDeploy = manualDeploy;
			EntityComposer entityComposer = new EntityComposer(actor.entity, components.Length);
			for (int i = 0; i < components.Length; i++)
			{
				components[i].AsClone(ref entityComposer);
			}

			Tags.Add(actor.entity, tags);

			foreach (var action in actions)
			{
				action(actor.entity);
			}
		}

		public void Setup(Actor actor)
		{
      EntityComposer entityComposer = new EntityComposer(actor.entity, components.Length);
     
			for (int i = 0; i < components.Length; i++)
			{
				components[i].AsClone(ref entityComposer);
			}

			Tags.Clear(actor.entity);
			Tags.AddTagsRaw(actor.entity, tags);


			foreach (var action in actions)
			{
				action(actor.entity);
			}
		}
	}
}
#endif