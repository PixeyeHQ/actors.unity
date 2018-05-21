/*===============================================================
Product:    Shoot off their lumps
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       19/12/2017 19:44
================================================================*/


using System.Collections.Generic;
using UnityEngine;


namespace Homebrew
{
	[System.Serializable]
	public class ProcessingTags : IComponent
	{
		private Dictionary<int, int> tags = new Dictionary<int, int>();

		private Actor actor;

		public void SetActor(Actor actor)
		{
			this.actor = actor;
		}


		public bool ContainAny(params int[] filter)
		{
			for (var i = 0; i < filter.Length; i++)
			{
				if (tags.ContainsKey(filter[i])) return true;
			}

			return false;
		}

		public bool ContainAll(params int[] filter)
		{
			for (var i = 0; i < filter.Length; i++)
			{
				if (!tags.ContainsKey(filter[i])) return false;
			}

			return true;
		}

		public bool Contain(int val)
		{
			return tags.ContainsKey(val);
		}


		public void Remove(params int[] ids)
		{
			bool tagsChanged = false;
			foreach (var index in ids)
			{
				int val;
				if (tags.TryGetValue(index, out val))
				{
					val = Mathf.Max(0, val - 1);

					if (val == 0)
					{
				 
						tags.Remove(index);
						tagsChanged = true;
					}
					else tags[index] = val;
				}
			}

			if (tagsChanged == false) return;
			actor.HandleTagsChanged();
		}

		public void Remove(int id)
		{
			int val;
			if (tags.TryGetValue(id, out val))
			{
				val = Mathf.Max(0, val - 1);

				if (val == 0)
				{
				 
					tags.Remove(id);
					actor.HandleTagsChanged();
				}
				else tags[id] = val;
			}
		}

		public void RemovAll(int id)
		{
			if (tags.ContainsKey(id))
				tags.Remove(id);
	 
			actor.HandleTagsChanged();
		}

		public void Add(params int[] ids)
		{
			var c = false;
			foreach (var index in ids)
			{
				if (tags.ContainsKey(index))
				{
					tags[index] += 1;
					continue;
				}

 
				tags.Add(index, 1);
				c = true;
			}

			if (!c) return;
			actor.HandleTagsChanged();
		}

		public void Add(int id)
		{
			if (tags.ContainsKey(id))
			{
				tags[id] += 1;

				return;
			}
 
			tags.Add(id, 1);
			actor.HandleTagsChanged();
		}

		public void Dispose()
		{
 
			tags.Clear();
			actor = null;
		}
	}
}