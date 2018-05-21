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
//		public bool HandleAddToGroup(Actor actor)
//		{
//			if (!actorsHashSet.Contains(actor))
//				if (actor.tags.DontHave(groupFilterExclude))
//					if (actor.tags.Contain(groupFilter))
//					{
//						actors.Add(actor);
//						actorsHashSet.Add(actor);
//
//						length++;
//						return true;
//					}
//
//			return false;
//		}
//
//		public void HandleRemoveFromGroup(Actor actor)
//		{
//			if (actorsHashSet.Contains(actor) == false) return;
//		
//			if (actor.tags.Contain(Tag.GroupEnemy))
//           
//				Debug.Log(actor.tags.Contain(groupFilter)+"_"+actor.tags.CheckExclude(groupFilterExclude));
//			if (!actor.tags.Contain(groupFilter) || actor.tags.CheckExclude(groupFilterExclude))
//			{
//				actors.Remove(actor);
//				actorsHashSet.Remove(actor);
//
//				length--;
//			}
//		}
//
//		public void HandleActor(Actor actor, int type)
//		{
//			var signalActor = actor;
//			//	var hash = signalActor.GetType().GetHashCode();
//			var cachedAmount = length;
//			switch (type)
//
//			{
//				case 0: // actor added
//					HandleAddToGroup(signalActor);
//					break;
//
//				case 1: // actor removed
//					HandleRemoveFromGroup(signalActor);
//					break;
//
//				case 2: // actor changed
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