/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       08/10/2017 21:54
================================================================*/

using System;
 using System.Collections.Generic;
 
 namespace Homebrew
 {
     public class Timer : ITick, IComponent, IDisposable
     {
         internal static Dictionary<TimerKey, List<Timer>> cachedTimers = new Dictionary<TimerKey, List<Timer>>(10);
 
 
         public float timer;
 
         public float finishTime;
         public float timeScale = 1;
 
         public Action callBackAction;
 
         public bool isAutoKill = true;
         public bool IsRunning { get; set; }
 
 
         public static bool FindAllTimers(int entity, int state, out List<Timer> timers)
         {
             TimerKey key;
             key.entity = entity;
             key.state = state;
 
 
             return cachedTimers.TryGetValue(key, out timers);
         }
 
         /// <summary>
         /// Create a new timer and pass it to the processor. Timers a great for adding delayed actions.
         /// </summary>
         /// <param name="finishTime"></param>
         /// <param name="action"></param>
         /// <returns></returns>
         public static Timer Add(float finishTime, Action action = null)
         {
             if (finishTime == 0)
             {
                 action();
                 return null;
             }
 
             var timer = new Timer();
 
             timer.finishTime = finishTime;
 
             if (action == null) return timer;
             timer.callBackAction = action;
             timer.Play();
             return timer;
         }
 
 
         public Timer()
         {
         }
 
         public Timer(Action callBackAction, float finishTime, bool isAutoKill = false)
         {
             this.isAutoKill = isAutoKill;
             this.finishTime = finishTime;
             this.callBackAction = callBackAction;
             timer = 0.0f;
         }
 
 
         public Timer AddID(int entity, int state = -1)
         {
             TimerKey key;
             key.entity = entity;
             key.state = state;
             List<Timer> timers;
             if (cachedTimers.TryGetValue(key, out timers))
             {
                 timers.Add(this);
             }
             else
             {
                 cachedTimers.Add(key, new List<Timer>(10) {this});
             }
 
             return this;
         }
 
         public static void Stop(Timer obj)
         {
             if (obj == null) return;
             obj.Stop();
         }
 
         public static void Release(Timer obj)
         {
             if (obj == null) return;
             if (Toolbox.applicationIsQuitting) return;
 
 
             obj.Dispose();
         }
 
         public void Stop()
         {
             ProcessingUpdate.Default.Remove(this);
             ProcessingTimer.Default.allWorkingTimers.Remove(this);
             IsRunning = false;
             timer = 0.0f;
         }
 
         public Timer SetTimeScale(float timeScale)
         {
             this.timeScale = timeScale;
             return this;
         }
 
         public Timer Play()
         {
             timer = 0.0f;
             IsRunning = true;
             ProcessingTimer.Default.allWorkingTimers.Add(this);
             ProcessingUpdate.Default.Add(this);
             return this;
         }
 
         public Timer Restart(float finishTime = 0.0f)
         {
             if (finishTime != 0.0f)
                 this.finishTime = finishTime;
 
             if (timer > 0)
             {
                 timer = 0.0f;
                 IsRunning = true;
                 return this;
             }
 
             timer = 0.0f;
             IsRunning = true;
             ProcessingTimer.Default.allWorkingTimers.Add(this);
             ProcessingUpdate.Default.Add(this);
             return this;
         }
 
         public Timer Restart(Action callBackAction, float finishTime = 0.0f)
         {
             this.callBackAction = callBackAction;
             return Restart(finishTime);
         }
 
 
         public void Tick()
         {
             Execute();
         }
 
         public void Execute()
         {
             timer += Time.delta * timeScale;
 
             if (timer < finishTime) return;
 
             timer = 0.0f;
             IsRunning = false;
 
             if (callBackAction != null)
                 callBackAction();
 
             if (isAutoKill) Release();
             else
             {
                 ProcessingUpdate.Default.Remove(this);
                 ProcessingTimer.Default.allWorkingTimers.Remove(this);
             }
         }
 
         public void Release()
         {
             if (Toolbox.applicationIsQuitting) return;
             Dispose();
         }
 
 
         public void Dispose()
         {
             ProcessingUpdate.Default.Remove(this);
             ProcessingTimer.Default.allWorkingTimers.Remove(this);
             timer = 0.0f;
             IsRunning = false;
             isAutoKill = true;
 
             callBackAction = null;
         }
     }
 
     public static class ExtensionTimer
     {
         public static Timer TryRestart(this Timer t, Action callBackAction, float finishTime, bool isAutoKill = false)
         {
             if (t == null) t = new Timer(callBackAction, finishTime, isAutoKill);
             t.Restart();
             return t;
         }
 
         public static void Kill(this Timer t)
         {
             if (t == null) return;
             t.Release();
         }
     }
 
     public struct TimerKey : IEquatable<TimerKey>
     {
         public int entity;
         public int state;
 
         public TimerKey(int x, int y) : this()
         {
             entity = x;
             state = y;
         }
 
 
         public override int GetHashCode()
         {
             unchecked
             {
                 return (entity * 397) ^ state;
             }
         }
 
         public override bool Equals(object other)
         {
             if (ReferenceEquals(null, other)) return false;
             return other is TimerKey && Equals((TimerKey) other);
         }
 
 
         public bool Equals(TimerKey other)
         {
             return entity == other.entity && state == other.state;
         }
     }
 }