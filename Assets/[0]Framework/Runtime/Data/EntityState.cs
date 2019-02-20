//   Project : Actors-Example
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 8/25/2018


using System;
using Homebrew;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;

#endif


[System.Serializable]
public struct EntityState
{
	[InfoBox("Object states. Do not touch if you don't know what exactly you want. Toggle RequireActorParent if you're sure that this script should initialize after a parent.", InfoMessageType.Info)]
	public bool enabled;

	// public bool released;
	//  public bool requireStarter;
	//   public bool initialized;
}

 