//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games
//  Author: Michael Garforth / http://wiki.unity3d.com/index.php/Profiler

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Pixeye.Actors
{
  public class Profile
  {
    public struct ProfilePoint
    {
      public DateTime lastRecorded;
      public TimeSpan totalTime;
      public int totalCalls;
    }

    private static Dictionary<string, ProfilePoint> profiles = new Dictionary<string, ProfilePoint>();
    private static DateTime startTime = DateTime.UtcNow;
    private static DateTime _startTime;
    private static Stopwatch _stopWatch;
    private static readonly TimeSpan _maxIdle = TimeSpan.FromSeconds(10);

    private Profile()
    {
    }

    public static DateTime UtcNow
    {
      get
      {
        if (_stopWatch == null || startTime.Add(_maxIdle) < DateTime.UtcNow)
        {
          _startTime = DateTime.UtcNow;
          _stopWatch = Stopwatch.StartNew();
        }

        return _startTime.AddTicks(_stopWatch.Elapsed.Ticks);
      }
    }

    public static void Start(string tag)
    {
      profiles.TryGetValue(tag, out var point);
      point.lastRecorded = UtcNow;
      profiles[tag] = point;
    }

    public static void End(string tag)
    {
      if (!profiles.ContainsKey(tag))
      {
        UnityEngine.Debug.LogError("Can only end profiling for a tag which has already been started (tag was " + tag + ")");
        return;
      }

      var point = profiles[tag];
      point.totalTime += UtcNow - point.lastRecorded;
      ++point.totalCalls;
      profiles[tag] = point;
    }

    public static void Reset()
    {
      profiles.Clear();
      startTime = DateTime.UtcNow;
    }

    public static void PrintResults()
    {
      var endTime = DateTime.UtcNow - startTime;
      var output = new FastString();
      output.Append("============================\n\t\t\t\tProfile results:\n============================\n");
      foreach (var pair in profiles)
      {
        double totalTime = pair.Value.totalTime.TotalSeconds;
        int totalCalls = pair.Value.totalCalls;
        if (totalCalls < 1) continue;
        output.Append("\nProfile ");
        output.Append(pair.Key);
        output.Append(" took ");
        output.Append(totalTime.ToString("F9"));
        output.Append(" seconds to complete over ");
        output.Append(totalCalls);
        output.Append(" iteration");
        if (totalCalls != 1) output.Append("s");
        output.Append(", averaging ");
        output.Append((totalTime / totalCalls).ToString("F9"));
        output.Append(" seconds per call");
      }

      output.Append("\n\n============================\n\t\tTotal runtime: ");
      output.Append(endTime.TotalSeconds.ToString("F3"));
      output.Append(" seconds\n============================");
      UnityEngine.Debug.Log(output.ToString());
    }
  }
}