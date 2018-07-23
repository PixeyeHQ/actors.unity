/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       5/10/2018  1:08 PM
================================================================*/


using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
//	public class GroupFilter
//	{
//		public int[] groupFilter = new int[0];
//		public int[] groupFilterExclude = new int[0];
//		public List<Actor> actors = new List<Actor>();
//		public HashSet<Actor> actorsHashSet = new HashSet<Actor>();
//		public Action OnActorsChanged = delegate {  };
//		protected int length;
//
//		public bool HandleAddToGroup(Actor entity)
//		{
//			if (!actorsHashSet.Contains(entity))
//				if (entity.Tags.DontHave(groupFilterExclude))
//					if (entity.Tags.Contain(groupFilter))
//					{
//						actors.Add(entity);
//						actorsHashSet.Add(entity);
//
//						length++;
//						return true;
//					}
//
//			return false;
//		}
//
//		public void HandleRemoveFromGroup(Actor entity)
//		{
//			if (actorsHashSet.Contains(entity) == false) return;
//		
//			if (entity.Tags.Contain(Tag.GroupEnemy))
//           
//				Debug.Log(entity.Tags.Contain(groupFilter)+"_"+entity.Tags.CheckExclude(groupFilterExclude));
//			if (!entity.Tags.Contain(groupFilter) || entity.Tags.CheckExclude(groupFilterExclude))
//			{
//				actors.Remove(entity);
//				actorsHashSet.Remove(entity);
//
//				length--;
//			}
//		}
//
//		public void HandleActor(Actor entity, int type)
//		{
//			var signalActor = entity;
//			//	var hash = signalActor.GetType().GetHashCode();
//			var cachedAmount = length;
//			switch (type)
//
//			{
//				case 0: // entity added
//					HandleAddToGroup(signalActor);
//					break;
//
//				case 1: // entity removed
//					HandleRemoveFromGroup(signalActor);
//					break;
//
//				case 2: // entity changed
//
//
//					if (!HandleAddToGroup(signalActor))
//						HandleRemoveFromGroup(signalActor);
//
//					break;
//			}
//
//		 	if (length != cachedAmount && length > 0)
//			 	OnActorsChanged();
//		}
//
//		public void HandleFirstPopulate()
//		{
//			var actors = Toolbox.Get<ProcessingEntities>().actorsAll;
//			for (int i = 0; i < actors.Count; i++)
//			{
//				HandleActor(actors[i], 0);
//			}
//		}
//
//
//		public void Dispose()
//		{
//			groupFilter = null;
//			groupFilterExclude = null;
//			actors = null;
//			actorsHashSet = null;
//		}
//	}
}