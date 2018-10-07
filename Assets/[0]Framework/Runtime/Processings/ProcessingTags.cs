/*===============================================================
Product:    Shoot off their lumps
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       19/12/2017 19:44
================================================================*/


using System;
using System.Collections.Generic;
 
using UnityEngine;


namespace Homebrew
{
	public class ProcessingTags : IDisposable
	{
		private Dictionary<int, int> tags = new Dictionary<int, int>();
		private Action actionChanged;


		public void Initialize(Action actionChanged)
		{
			this.actionChanged = actionChanged;
		}


		public bool ContainAny(params int[] filter)
		{
			for (int i = 0; i < filter.Length; i++)
			{
				if (tags.ContainsKey(filter[i])) return true;
			}

			return false;
		}

		public bool ContainAll(params int[] filter)
		{
			
			for (int i = 0; i < filter.Length; i++)
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
			foreach (int index in ids)
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
			actionChanged();
		}

		public void Remove(int id, bool all = false)
		{
			int val;
			if (tags.TryGetValue(id, out val))
			{
				val = all ? 0 : Mathf.Max(0, val - 1);

				if (val == 0)
				{
					tags.Remove(id);
					actionChanged();
				}
				else tags[id] = val;
			}
		}

		

		public void Add(params int[] ids)
		{
			bool c = false;
			foreach (int index in ids)
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
 
			actionChanged();
		}

		public void Add(int id)
		{
			if (tags.ContainsKey(id))
			{
				tags[id] += 1;

				return;
			}

			tags.Add(id, 1);
			actionChanged();
		}

		public void Dispose()
		{
			tags.Clear();
			actionChanged = null;
		}
	}
}