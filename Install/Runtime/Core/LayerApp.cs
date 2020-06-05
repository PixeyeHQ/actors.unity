using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Actors
{
  public class LayerApp : Layer<LayerApp>, ITick
  {
    internal static List<AsyncOperation> LoadJobs = new List<AsyncOperation>();
    public static Action<float> OnSceneLoading = delegate { };

    protected override void Setup()
    {
    }

    protected override void OnLayerDestroy()
    {
    }


    public void Tick(float dt)
    {
      HandleLoadingProgress();
    }

    static void HandleLoadingProgress()
    {
      if (LoadJobs.Count <= 0) return;
      
      var progress = 0f;
      for (var i = 0; i < LoadJobs.Count; i++)
        progress += LoadJobs[i].progress;
      var ratio = progress / LoadJobs.Count;
      OnSceneLoading(ratio);
      if (ratio == 1)
      {
        LoadJobs.Clear();
      }
    }
  }
}