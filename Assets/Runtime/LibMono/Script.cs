//   Project : Battlecruiser3.0
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 8/19/2018

 
using UnityEngine;

namespace Pixeye
{
    public abstract class Script : ScriptableObject
    {
        public abstract void Handle(int arg);
    }
}