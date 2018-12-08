//   Project : Battlecruiser3.0
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 8/19/2018

 
using UnityEngine;

namespace Homebrew
{
    public abstract class Scriptable : ScriptableObject
    {
        public abstract void Handle(int arg);
    }
}