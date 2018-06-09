/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       5/14/2018  6:32 PM
================================================================*/

using System;
using System.Collections.Generic;

namespace Homebrew
{
	public class Group : IDisposable
	{
		private HashSet<int> actorsHashSet = new HashSet<int>();
		public List<Actor> actors = new List<Actor>();
		public Action OnGroupChanged = delegate { };
		public FilterMask mask;
		public int length;

		public void HandleActor(Actor actor)
		{
			var signalActor = actor;
			var cachedAmount = length;


			if (!actorsHashSet.Contains(actor.hashCode))
			{
				TryAddToGroup(signalActor);
			}
			else
			{
				TryRemoveFromGroup(signalActor);
			}

			if (length != cachedAmount)
			{
				OnGroupChanged();
			}
		}

		public void HandleRemoveActor(Actor actor)
		{
			var cachedAmount = length;

			if (actorsHashSet.Contains(actor.hashCode) == false) return;
			length--;
			actors.Remove(actor);
			actorsHashSet.Remove(actor.hashCode);

			if (length != cachedAmount)
			{
				OnGroupChanged();
			}
		}


		void TryAddToGroup(Actor actor)
		{
			if (actor.tags.ContainAny(mask.groupFilterExclude)) return;
			if (!actor.tags.ContainAll(mask.groupFilter)) return;

			actors.Add(actor);
			actorsHashSet.Add(actor.hashCode);

			length++;
		}

		void TryRemoveFromGroup(Actor actor)
		{
			if (!actor.tags.ContainAll(mask.groupFilter) || actor.tags.ContainAny(mask.groupFilterExclude))
			{
				actors.Remove(actor);
				actorsHashSet.Remove(actor.hashCode);

				length--;
			}
		}

		public void Dispose()
		{
			OnGroupChanged = delegate { };
		}
	}
}