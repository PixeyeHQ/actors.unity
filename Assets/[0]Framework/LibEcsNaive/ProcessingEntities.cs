/*===============================================================
         Product:    Cryoshock
         Developer:  Dimitry Pixeye - pixeye@hbrew.store
         Company:    Homebrew - http://hbrew.store
         Date:       25/01/2018 00:05
         ================================================================*/

using System;
using System.Collections.Generic;
 

namespace Homebrew
{
	public class ProcessingEntities : IDisposable
	{
		public static ProcessingEntities Default;


		public readonly List<Actor> listActors = new List<Actor>(50);
		private readonly List<Group> listGroups = new List<Group>(10);

		private readonly Dictionary<FilterMask, Group> groups = new Dictionary<FilterMask, Group>();

		private int lengthGroups;

		public Group AddGetgroup(FilterMask m)
		{
			Group g;
			if (!groups.TryGetValue(m, out g))
			{
				g = new Group();
				g.mask = m;
				groups.Add(m, g);
				listGroups.Add(g);
				lengthGroups++;
			}

			return g;
		}

		public T Get<T>() where T : class
		{
			return listActors.Find(a => a.GetType() == typeof(T)) as T;
		}

	 
		public void Add(Actor actor)
		{
			listActors.Add(actor);
			Changed(actor);
		}

		public void Remove(Actor actor)
		{
 
			for (var i = 0; i < lengthGroups; i++)
			{
				var group = listGroups[i];
				group.HandleRemoveActor(actor);
			}

			listActors.Remove(actor);
		}

		public void Changed(Actor actor)
		{
	
			for (var i = 0; i < lengthGroups; i++)
			{
				var group = listGroups[i];
				group.HandleActor(actor);
			}
		}

		public void Dispose()
		{
			listActors.Clear();

			for (int i = 0; i < lengthGroups; i++)
			{
				listGroups[i].Dispose();	
			}
			listGroups.Clear();
			groups.Clear();
			lengthGroups = 0;
		}


	 
	}
}