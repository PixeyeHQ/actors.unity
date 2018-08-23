/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/9/2018  6:01 AM
================================================================*/

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
    public class StarterKernel : MonoBehaviour
    {
        [FoldoutGroup("SetupData")] public Blueprints blueprints;
        [FoldoutGroup("SetupData")] public DataGame dataGameSettings;
        [FoldoutGroup("SetupData")] public DataGame dataGameSession;

        [FoldoutGroup("SetupData")] public List<Pluggable> pluggables = new List<Pluggable>();


        private void Awake()
        {
            Toolbox.Add(blueprints);
           
            GameObject.Find("[KERNEL]").AddComponent<ProcessingUpdate>();
            Time.Default = Toolbox.Add<Time>();


            ProcessingTimer.Default = Toolbox.Add<ProcessingTimer>();
            ProcessingSignals.Default = Toolbox.Add<ProcessingSignals>();
            ProcessingGoPool.Default = Toolbox.Add<ProcessingGoPool>();
            ProcessingResources.Default = Toolbox.Add<ProcessingResources>();
            ProcessingEntities.Default = Toolbox.Add<ProcessingEntities>();
            ProcessingBehaviorAttributes.Default = Toolbox.Add<ProcessingBehaviorAttributes>();
            ProcessingScene.Default = Toolbox.Add<ProcessingScene>();


            for (var i = 0; i < pluggables.Count; i++)
            {
                pluggables[i].Plug();
            }


            Toolbox.Add(dataGameSession);
            Toolbox.Add(dataGameSettings);

            Application.runInBackground = false;

            ProcessingFastPool<Timer>.Instance.Populate(50);
     
        }


        private IEnumerator OnApplicationFocus(bool hasFocus)
        {
            if (Application.isEditor) yield break;
            if (hasFocus) Time.Default.OnFocus();
            yield return new WaitForSeconds(0.01f);
            Time.Default.isActive = hasFocus ? 1f : 0f;
        }
    }
}