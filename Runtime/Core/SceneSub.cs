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
            InvalidSceneName,
            NotAdded,
            IsLoading,
            IsLoaded
        }

        private static readonly Dictionary<string, int> loadedScenes = new Dictionary<string, int>();
        private static readonly Stack<int> freeIndexes = new Stack<int>();
        private static int sceneСounter = SceneManager.sceneCountInBuildSettings;

        static State CheckSceneState(string sceneName)
        {
            if (String.IsNullOrEmpty(sceneName)) return State.InvalidSceneName;
            if (SceneManager.GetSceneByName(sceneName).isLoaded) return State.IsLoaded;
            if (SceneManager.GetSceneByName(sceneName).name != default) { return State.IsLoading; }
            else { return State.NotAdded; }
        }

        public static void Add(int buildIndex)
        {
            DebugScene(buildIndex);
            var sceneName = GetSceneName(buildIndex);
            Add(sceneName);
        }

        public static void Add(string sceneName)
        {
            var name = System.IO.Path.GetFileNameWithoutExtension(sceneName);
            var state = CheckSceneState(name);
            if (state == State.NotAdded)
            {
                var layerIndex = GetLayerIndex(name);
                LayerKernel.Initialized[layerIndex] = false;
                LayerKernel.LoadJobs.Add(SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive));
            }
        }

        public static void Remove(int buildIndex)
        {
            DebugScene(buildIndex);
            var sceneName = GetSceneName(buildIndex);
            Remove(sceneName);
        }

        public static void Remove(string sceneName)
        {
            var name = System.IO.Path.GetFileNameWithoutExtension(sceneName);
            var state = CheckSceneState(name);
            if (state == State.IsLoaded) { RemoveOp(name); }
        }

        static void RemoveOp(string sceneName)
        {
            var layerIndex = GetLayerIndex(sceneName);
            if (LayerKernel.Layers[layerIndex] != null) // check if this scene is a part of Actors Layers.
                LayerKernel.Layers[layerIndex].Release();
            LayerKernel.LoadJobs.Add(SceneManager.UnloadSceneAsync(sceneName));
            LayerKernel.LoadJobs.Add(Resources.UnloadUnusedAssets());
            loadedScenes.Remove(sceneName);
            if (layerIndex >= SceneManager.sceneCountInBuildSettings) { freeIndexes.Push(layerIndex); }
        }

        internal static int GetLayerIndex(string sceneName)
        {
            if (!loadedScenes.ContainsKey(sceneName))
            {
                var buildIndex = GetBuildIndex(sceneName);
                if (buildIndex < 0)
                {
                    loadedScenes.Add(sceneName, (freeIndexes.Count > 0) ? freeIndexes.Pop() : sceneСounter++);
                }
                else
                {
                    loadedScenes.Add(sceneName, buildIndex);
                }
            }
            return loadedScenes[sceneName];
        }

        internal static string GetSceneName(int buildIndex)
        {
            var path = SceneUtility.GetScenePathByBuildIndex(buildIndex);
            return System.IO.Path.GetFileNameWithoutExtension(path);
        }

        internal static int GetBuildIndex(string sceneName)
        {
            for (var i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
            {
                var testedScreen = GetSceneName(i);
                if (testedScreen == sceneName)
                    return i;
            }
            return -1;
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