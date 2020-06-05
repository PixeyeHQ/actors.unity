//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;

namespace Pixeye.Actors
{
  [Serializable]
  public class SettingsActors
  {
    public int Vsync = 0;
    public int Fps = -1;
    public int FpsPhysics = 50;
    public int SizeEntities = 1024;
    public int SizeComponents = 128;
    public int SizeGenerations = 4;
    public int SizeGroups = 512;
    public bool DebugNames = false;
    public string Namespace = "";
    public string[] Plugins = new string[0];
    public bool PauseOnFocusLost = true;
  }
}