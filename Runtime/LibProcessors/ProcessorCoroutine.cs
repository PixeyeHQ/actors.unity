using System;
using System.Collections;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public class ProcessorCoroutine : ITick, IDisposable
  {
    public void Tick(float delta)
    {
    }

    public void Dispose()
    {
    }
  }


  /// A handle to a (potentially running) coroutine.
  public struct coroutine
  {
    /// Reference to the routine's runner.
    public ProcessorCoroutines processorCoroutines;


    /// Reference to the routine's enumerator.
    public IEnumerator enumerator;


    /// Construct a coroutine. Never call this manually, only use return values from Coroutines.Run().
    public coroutine(ProcessorCoroutines processorCoroutines, IEnumerator enumerator)
    {
      this.processorCoroutines = processorCoroutines;
      this.enumerator = enumerator;
    }


    /// Stop this coroutine if it is running.
    public bool stop()
    {
      return isRunning && processorCoroutines.Stop(enumerator);
    }


    /// A routine to wait until this coroutine has finished running.
    public IEnumerator wait()
    {
      if (enumerator != null)
        while (processorCoroutines.IsRunning(enumerator))
          yield return null;
    }


    /// True if the enumerator is currently running.
    public bool isRunning => enumerator != null && processorCoroutines.IsRunning(enumerator);
  }
}