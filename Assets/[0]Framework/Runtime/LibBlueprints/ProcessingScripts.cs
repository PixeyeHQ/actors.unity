//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 10/23/2018


using System;
using System.Collections.Generic;
using UnityEngine;


namespace Homebrew
{
    public class ProcessingScripts : IKernel
    {
        internal static Dictionary<int, CompositionScript> scripts = new Dictionary<int, CompositionScript>();

        public static T Get<T>() where T : class
        {
            return scripts[typeof(T).GetHashCode()] as T;
        }

        public static CompositionScript Get<T>(T component) where T : class
        {
            return scripts[component.GetType().GetHashCode()];
        }
    }

    [Serializable]
    public class CompositionScript
    {
        internal List<Storage> storages = new List<Storage>(5);
        internal int[] tags;

        public bool Contain(int entity)
        {
            if (tags != null && !entity.Has(tags)) return false;

            var len = storages.Count;
            for (int i = 0; i < len; i++)
            {
                
                if (!storages[i].HasComponent(entity)) return false;
            }


            return true;
        }
    }
}