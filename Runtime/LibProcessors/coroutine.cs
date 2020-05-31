//  Project : ecs.examples
// Contacts : Pix - ask@pixeye.games


using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;


namespace Pixeye.Actors
{
  

  // [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  // public class ProcessorRoutine
  // {
  //   ProcessorCoroutines Local;
  //   public App app;
  //
  //   bool timescaled = true;
  //   float period = -1;
  //
  //   public ProcessorRoutine()
  //   {
  //     app = new App();
  //     app.Global = new ProcessorCoroutines();
  //
  //     app.Global.timescaled = true;
  //     app.Global.period = -1;
  //
  //     ProcessorCoroutines.coroutine_handlers_global.Add(app.Global);
  //   }
  //
  //   public void addLocalRoutines()
  //   {
  //     Local = new ProcessorCoroutines();
  //     Local.timescaled = timescaled;
  //     Local.period = period;
  //     Local.accum = period;
  //     ProcessorCoroutines.coroutine_handlers.Add(Local);
  //   }
  //
  //   public ProcessorRoutine ignoreTimescale()
  //   {
  //     timescaled = false;
  //     app.Global.timescaled = false;
  //     return this;
  //   }
  //
  //   public ProcessorRoutine setUpdatePeriod(float arg)
  //   {
  //     period = arg;
  //     app.Global.period = arg;
  //     app.Global.accum = arg;
  //     return this;
  //   }
  //
  //   /// <summary>
  //   /// Local coroutines that work only on main scene.
  //   /// </summary>
  //   public Routine run(float delay, IEnumerator routine)
  //   {
  //     return Local.Run(delay, routine);
  //   }
  //
  //   /// <summary>
  //   /// Local coroutines that work only on main scene.
  //   /// </summary>
  //   public Routine run(IEnumerator routine)
  //   {
  //     return Local.Run(0, routine);
  //   }
  //
  //
  //   public bool stop(IEnumerator routine)
  //   {
  //     return Local.Stop(routine);
  //   }
  //
  //
  //   public IEnumerator waitFrame => null;
  //
  //   public IEnumerator wait(float t)
  //   {
  //     Local.delays[Local.currentIndex] = t;
  //     return null;
  //   }
  //
  //   /// <summary>
  //   /// Coroutines that runs globally and are not affected by scene changes.
  //   /// </summary>
  //   public class App
  //   {
  //     internal ProcessorCoroutines Global;
  //
  //     public Routine run(float delay, IEnumerator routine)
  //     {
  //       return Global.Run(delay, routine);
  //     }
  //
  //     public Routine run(IEnumerator routine)
  //     {
  //       return Global.Run(0, routine);
  //     }
  //
  //
  //     public bool stop(IEnumerator routine)
  //     {
  //       return Global.Stop(routine);
  //     }
  //   }
  // }


  // public static class routines
  // {
  //   internal static ProcessorCoroutines Local;
  //   internal static ProcessorCoroutines Global;
  //
  //   internal static void Init()
  //   {
  //     Local = new ProcessorCoroutines();
  //     Global = new ProcessorCoroutines();
  //
  //     Local.timescaled = true;
  //     Global.timescaled = true;
  //
  //     Local.period = -1;
  //     Global.period = -1;
  //
  //     ProcessorCoroutines.coroutine_handlers.Add(Local);
  //     ProcessorCoroutines.coroutine_handlers_global.Add(Global);
  //   }
  //
  //
  //   /// Local coroutines that work only on main scene.
  //   public static Routine run(float delay, IEnumerator routine)
  //   {
  //     return Local.Run(delay, routine);
  //   }
  //
  //
  //   /// Local coroutines that work only on main scene.
  //   public static Routine run(IEnumerator routine)
  //   {
  //     return Local.Run(0, routine);
  //   }
  //
  //
  //   public static bool stop(IEnumerator routine)
  //   {
  //     return Local.Stop(routine);
  //   }
  //
  //
  //   public static IEnumerator waitFrame => null;
  //
  //   public static IEnumerator wait(float t)
  //   {
  //     Local.delays[Local.currentIndex] = t;
  //     return null;
  //   }
  //
  //
  //   /// Coroutines that runs globally and are not affected by scene changes.
  //   public static class app
  //   {
  //     public static Routine run(float delay, IEnumerator routine)
  //     {
  //       return Global.Run(delay, routine);
  //     }
  //
  //     public static Routine run(IEnumerator routine)
  //     {
  //       return Global.Run(0, routine);
  //     }
  //
  //
  //     public static bool stop(IEnumerator routine)
  //     {
  //       return Global.Stop(routine);
  //     }
  //   }
  // }


  public class WaitFrame : IEnumerator
  {
    public object Current => null;

    public bool MoveNext() => true;

    public void Reset()
    {
    }
  }


   
}