//  Project : Battlecruiser
// Contacts : Pixeye - info@pixeye.games
//     Date : 2/17/2019 

#if ODIN_INSPECTOR
using UnityEngine;

namespace Homebrew
{
	[CreateAssetMenu(fileName = "Template Module", menuName = "Actors/Templates/Module")]
	public class TemplateActor : TemplateSerialized
	{
		public GameObject model;
		public bool manualDeploy;
		public IPopulate[] components = new IPopulate[0];

		[TagFilter(typeof(Tag))]
		public int[] tags = new int[0];


		protected override void OnEnable()
		{
			base.OnEnable();

			for (int i = 0; i < components.Length; i++)
			{
				var component = components[i];
				var type      = component.GetType();

				Add(type, component);
			}
		}


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
			return transform;
		}

		public void Add(Actor me)
		{
			me.conditionManualDeploy = manualDeploy;
			EntityComposer entityComposer = new EntityComposer(me.entity, components.Length);
			for (int i = 0; i < components.Length; i++)
			{
				components[i].AsClone(ref entityComposer);
			}

			Tags.AddTagsRaw(me.entity, tags);
		}

		public void Setup(Actor me)
		{
			EntityComposer entityComposer = new EntityComposer(me.entity, components.Length);
			for (int i = 0; i < components.Length; i++)
			{
				components[i].AsClone(ref entityComposer);
			}

			Tags.Clear(me.entity);
			Tags.AddTagsRaw(me.entity, tags);
		}
	}
}
#endif