#if ODIN_INSPECTOR
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	public partial class Actor
	{
 
	 	public static Actor Create(string prefabID, BlueprintEntity bp, bool pooled = false)
		{
			var tr = pooled ? Obj.Spawn(Pool.Entities, prefabID) : Obj.Spawn(prefabID);
			var actor = tr.AddGetActor();
			actor.buildFrom = bp;
			actor.isPooled = pooled;
			actor.Launch();
			return actor;
		}
 
		public static Actor Create(GameObject prefab, BlueprintEntity bp, bool pooled = false)
		{
			var tr = pooled ? Obj.Spawn(Pool.Entities, prefab) : Obj.Spawn(prefab);
			var actor = tr.AddGetActor();
			actor.buildFrom = bp;
			actor.isPooled = pooled;
			actor.Launch();
			return actor;
		}
 
	}

}
#endif