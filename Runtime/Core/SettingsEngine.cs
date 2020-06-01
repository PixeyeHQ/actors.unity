//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;

namespace Pixeye.Actors
{
  [Serializable]
  public class SettingsEngine
  {
    public int SizeEntities = 1024;
    public int SizeComponents = 128;
    public int SizeGenerations = 4;
    public int SizeGroups = 256;
    public bool DebugNames = false;
    public string Namespace = "";
    public string[] Plugins = new string[0];
    public bool PauseOnFocusLost = true;
  }
}