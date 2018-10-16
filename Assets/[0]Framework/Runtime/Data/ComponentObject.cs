//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 10/13/2018


using UnityEngine;

namespace Homebrew
{
    public class ComponentObject : IComponent
    {
        public Transform transform;
        public GameObject obj;
        public int entityID;
    }
}