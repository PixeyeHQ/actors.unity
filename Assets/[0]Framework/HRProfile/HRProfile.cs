/*===============================================================
Product:    Shoot off their lumps
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       19/01/2018 12:40
================================================================*/

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Homebrew{
 
 
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
    private static Stopwatch _stopWatch = null;
    private static TimeSpan _maxIdle = TimeSpan.FromSeconds(10);
 
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
 
    public static void StartProfile(string tag)
    {
        ProfilePoint point;
 
        profiles.TryGetValue(tag, out point);
        point.lastRecorded = UtcNow;
        profiles[tag] = point;
    }
 
    public static void EndProfile(string tag)
    {
        if (!profiles.ContainsKey(tag))
        {
            UnityEngine.Debug.LogError("Can only end profiling for a tag which has already been started (tag was " + tag + ")");
            return;
        }
        ProfilePoint point = profiles[tag];
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
        TimeSpan endTime = DateTime.UtcNow - startTime;
        System.Text.StringBuilder output = new System.Text.StringBuilder();
        output.Append("============================\n\t\t\t\tProfile results:\n============================\n");
        foreach (KeyValuePair<string, ProfilePoint> pair in profiles)
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