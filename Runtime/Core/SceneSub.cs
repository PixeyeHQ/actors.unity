using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

namespace Pixeye.Actors
{
  public static class SceneSub
  {
    enum State
    {
      AlreadyAdded,
      InvalidIndex,
      NotAdded
    }

        private static readonly Dictionary<string, int> loadScenes = new Dictionary<string, int>();

        static State CheckSceneState(string sceneName)
        {
            if (loadScenes.ContainsKey(sceneName)) { return State.AlreadyAdded; }
            else { return State.NotAdded; }
        }

        public static void Add(int buildIndex)
        {
            var sceneName = NameFromBuildIndex(buildIndex);
            Add(sceneName);
        }

        public static void Add(string sceneName)
        {
            var name = System.IO.Path.GetFileNameWithoutExtension(sceneName);
            var state = CheckSceneState(name);
            if (state == State.AlreadyAdded) return;

            var sceneIndex = SceneIndexFromName(name);
            LayerKernel.Initialized[sceneIndex] = false;
            LayerKernel.LoadJobs.Add(SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive));
        }

        public static void Remove(int buildIndex)
        {
            DebugScene(buildIndex);
            var sceneName = NameFromBuildIndex(buildIndex);
            Remove(sceneName);
        }

        public static void Remove(string sceneName)
        {
            var state = CheckSceneState(sceneName);
            if (state == State.InvalidIndex || state == State.NotAdded) return;
            RemoveOp(SceneIndexFromName(sceneName));
        }

        static void RemoveOp(int buildIndex)
        {
            if (LayerKernel.Layers[buildIndex] != null) // check if this scene is a part of Actors Layers.
                LayerKernel.Layers[buildIndex].Release();
            LayerKernel.LoadJobs.Add(SceneManager.UnloadSceneAsync(buildIndex));
            LayerKernel.LoadJobs.Add(Resources.UnloadUnusedAssets());
        }
    
        internal static int SceneIndexFromName(string sceneName) {
            if (!loadScenes.ContainsKey(sceneName))
            {
                loadScenes.Add(sceneName, loadScenes.Count);
            }
            return loadScenes[sceneName];
        }

        public static string NameFromBuildIndex(int buildIndex)
        {
            var path = SceneUtility.GetScenePathByBuildIndex(buildIndex);
            if (String.IsNullOrEmpty(path)) { 
                DebugScene(buildIndex);
                //Return the index of the current scene
                return SceneManager.GetActiveScene().name; 
            }
            return System.IO.Path.GetFileNameWithoutExtension(path);
        }

        [Conditional("ACTORS_DEBUG")]
        static void DebugScene(int buildIndex)
        {
            if (buildIndex == -1)
            {
                Debug.Log($"There is no scene with Build Index {buildIndex}.");
                throw new Exception();
            }
        }
    }
}
