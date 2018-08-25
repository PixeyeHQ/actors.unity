/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       12/09/2017 16:10
================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;

#endif


namespace Homebrew
{
// Start any game    
    public class Starter : MonoBehaviour
    {
        public static bool initialized;
 
        [FoldoutGroup("SetupData")] public List<Factory> factories;
        [FoldoutGroup("SetupData")] public List<Scenes> ScenesToKeep;
        [FoldoutGroup("SetupData")] public List<Scenes> SceneDependsOn;

        void Awake()
        {
            for (var i = 0; i < factories.Count; i++)
            {
                Toolbox.Add(factories[i]);
            }
 

            Toolbox.Add<ProcessingSceneLoad>().Setup(ScenesToKeep, SceneDependsOn, this);
        }


        public void BindScene()
        {
            var poolReg = GetComponent<PoolRegister>();
            if (poolReg) poolReg.Reigster();
            
            Setup();
            initialized = true;
      
            var objs = FindObjectsOfType<MonoCached>();

            for (var i = 0; i < objs.Length; i++)
            {
                if (objs[i].state.requireStarter)
                    objs[i].SetupAfterStarter();
            }
            
        
            Timer.Add(Time.DeltaTimeFixed*4, () => PostSetup());
        }

        protected virtual void Setup()
        {
        }

        protected virtual void PostSetup()
        {
        }


        private void OnDestroy()
        {
            initialized = false;
        }
    }
}