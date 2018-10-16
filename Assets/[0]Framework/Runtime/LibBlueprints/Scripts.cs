//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 10/5/2018

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
    [Serializable]
    [CreateAssetMenu]
    public class Scripts : ScriptableObject, IAwake, IKernel
    {
        public List<ScriptableObject> container;

        private List<IDisposable> disposable;

        public void OnAwake()
        {
            disposable = new List<IDisposable>();
            var len = container.Count;
            for (int i = 0; i < len; i++)
            {
                var c = container[i];
                var d = c as IDisposable;
                if (d != null) disposable.Add(d);
            }
        }

        public void Clear()
        {
            if (disposable != null)
            {
                var len = disposable.Count;
                for (int i = 0; i < len; i++)
                {
                    disposable[i].Dispose();
                }
            }
        }
    }
}