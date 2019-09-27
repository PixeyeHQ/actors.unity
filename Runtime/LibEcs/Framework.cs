//  Project : ecs.unity
// Contacts : Pix - ask@pixeye.games


using UnityEngine;
using static Pixeye.Actors.LogType;

namespace Pixeye.Actors
{
	public static class Framework
	{
		public static class Groups
		{
			internal static CacheGroup All = new CacheGroup();
			internal static FamilyGroupTags ByTag = new FamilyGroupTags();
			internal static FamilyGroupTags ByType = new FamilyGroupTags();
		}

		public static class Processors
		{
			internal static Processor[] storage = new Processor[64];
			internal static int length;
		}


		public static void Cleanup()
		{
			Groups.All.Dispose();
		}

		public static class Debugger
		{
			public static void Log(int logID, params object[] contenxt)
			{
				switch (logID)
				{
					case NOT_ACTIVE:
						Debug.LogError($"Entity <b>{contenxt[0]}</b> is not active. You should not add components to an inactive entity. <b> {contenxt[1]}</b> ");
						break;
					case ALREADY_HAVE:
						Debug.LogError($"Entity <b>{contenxt[0]}</b> already have this component: <b>{contenxt[1]}</b> ");
						break;
					case REMOVE_NON_EXISTANT:
						Debug.LogError($"Entity <b>{contenxt[0]}</b> is deleted. You can't remove a component from a deleted entity. <b>{contenxt[1]}</b> ");
						break;
					case NULL_ENTITY:
						Debug.LogError($"Entity <b>{contenxt[0]}</b> is null. Use <color=#ff0000ff>Entity.Create</color> to register a new entity first. <b>{contenxt[1]}</b> ");
						break;
					case TAGS_LIMIT_REACHED:
						Debug.LogError($"Entity <b>{contenxt[0]}</b> has reached tag capacity. Go to Tools->Actors->Tags->Size to increase cap. Current cap: <b>{contenxt[1]}</b> ");
						break;
					case DESTROYED:
						Debug.LogError($"You are trying to release already destroyed entity with ID <b>{contenxt[0]}</b>");
						break;
				}
			}
		}

		public static SettingsEngine Settings = new SettingsEngine();
	}

	struct LogType
	{
		public const int NOT_ACTIVE = 0;
		public const int ALREADY_HAVE = 1;
		public const int REMOVE_NON_EXISTANT = 2;
		public const int NULL_ENTITY = 3;
		public const int TAGS_LIMIT_REACHED = 4;
		public const int DESTROYED = 5;
	}
}