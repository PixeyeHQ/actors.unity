//  Project : game.metro
// Contacts : Pix - ask@pixeye.games

namespace Pixeye.Framework
{
	public class ProcessorView : Processor, ITick
	{

		private Group<ComponentView> group_views;

		public ProcessorView()
		{
			group_views.onAdd += (in ent entity) =>
			{
				var cView = entity.ComponentView();
				cView.source = entity.Get<IView>();
				cView.source.OnAdd(entity);
			};
			group_views.onRemove += (in ent entity) => { entity.ComponentView().source.OnRemove(); };
		}

		public void Tick()
		{
			var delta = Time.delta;
			for (int i = 0; i < group_views.length; i++)
			{
				var entity = group_views.entities[i];
				entity.ComponentView().source.Tick(delta);
			}
		}

	}
}