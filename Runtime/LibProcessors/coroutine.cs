//  Project : ecs.examples
// Contacts : Pix - ask@pixeye.games


using System;
using System.Collections;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Actors
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public class ProcessorCoroutines : ITick
	{
		IEnumerator[] running = new IEnumerator[36];
		internal float[] delays = new float[36];
		internal int currentIndex;
		int length;

		public coroutine Run(float delay, IEnumerator routine)
		{
			if (length == running.Length)
			{
				Array.Resize(ref running, length << 1);
				Array.Resize(ref delays, length << 1);
			}

			running[length]  = routine;
			delays[length++] = delay;

			return new coroutine(this, routine);
		}

		public coroutine Run(IEnumerator routine)
		{
			if (length == running.Length)
			{
				Array.Resize(ref running, length << 1);
				Array.Resize(ref delays, length << 1);
			}

			running[length]  = routine;
			delays[length++] = 0f;

			return new coroutine(this, routine);
		}
		public coroutine run(IEnumerator routine)
		{
			return Run(0, routine);
		}


		public bool Stop(IEnumerator routine)
		{
			int i = 0;

			for (; i < length; i++)
			{
				if (routine == running[i]) break;
			}

			if (i < 0)
				return false;

			running[i] = null;
			delays[i]  = 0f;
			return true;
		}


		public bool Stop(coroutine routine)
		{
			return routine.stop();
		}


		public void StopAll()
		{
			length = 0;
		}


		public bool IsRunning(IEnumerator routine)
		{
			for (int i = 0; i < length; i++)
			{
				if (routine == running[i]) return true;
			}

			return false;
		}

		public bool IsRunning(coroutine routine)
		{
			return routine.isRunning;
		}


		public void Tick(float delta)
		{
			for (int i = length - 1; i >= 0; i--)
			{
				if (delays[i] > 0f)
					delays[i] -= delta;

				else if (running[i] == null || !MoveNext(running[i], i))
				{
					if (i < --length)
					{
						Array.Copy(running, i + 1, running, i, length - i);
						Array.Copy(delays, i + 1, delays, i, length - i);
					}
				}
			}
		}

		bool MoveNext(IEnumerator routine, int index)
		{
			currentIndex = index;
			if (routine.Current is IEnumerator)
			{
				if (MoveNext((IEnumerator) routine.Current, index))
					return true;

				delays[index] = 0f;
			}


			return routine.MoveNext();
		}
	}

	public class routines : ProcessorCoroutines
	{
		public static readonly routines Default = new routines();
		internal static readonly routines Global = new routines();

		/// <summary>
		/// Local coroutines that work only on main scene.
		/// </summary>
		public static coroutine run(float delay, IEnumerator routine)
		{
			return Default.Run(delay, routine);
		}
		/// <summary>
		/// Local coroutines that work only on main scene.
		/// </summary>
		public static coroutine run(IEnumerator routine)
		{
			return Default.Run(0, routine);
		}

		public static bool stop(IEnumerator routine)
		{
			return Default.Stop(routine);
		}


		public static IEnumerator waitFrame => null;
		public static IEnumerator wait(float t)
		{
			Default.delays[Default.currentIndex] = t;
			return null;
		}

		/// <summary>
		/// Coroutines that runs globally and are not affected by scene changes.
		/// </summary>
		public static class app
		{
			public static coroutine run(float delay, IEnumerator routine)
			{
				return Global.Run(delay, routine);
			}
			public static coroutine run(IEnumerator routine)
			{
				return Global.Run(0, routine);
			}


			public static bool stop(IEnumerator routine)
			{
				return Global.Stop(routine);
			}
		}
	}


	public class WaitFrame : IEnumerator
	{
		public object Current => null;

		public bool MoveNext() => true;

		public void Reset()
		{
		}
	}

	/// <summary>
	/// A handle to a (potentially running) coroutine.
	/// </summary>
	public struct coroutine
	{
		/// <summary>
		/// Reference to the routine's runner.
		/// </summary>
		public ProcessorCoroutines processorCoroutines;

		/// <summary>
		/// Reference to the routine's enumerator.
		/// </summary>
		public IEnumerator enumerator;

		/// <summary>
		/// Construct a coroutine. Never call this manually, only use return values from Coroutines.Run().
		/// </summary>
		/// <param name="processorCoroutines">The routine's runner.</param>
		/// <param name="enumerator">The routine's enumerator.</param>
		public coroutine(ProcessorCoroutines processorCoroutines, IEnumerator enumerator)
		{
			this.processorCoroutines = processorCoroutines;
			this.enumerator          = enumerator;
		}

		/// <summary>
		/// Stop this coroutine if it is running.
		/// </summary>
		/// <returns>True if the coroutine was stopped.</returns>
		public bool stop()
		{
			return isRunning && processorCoroutines.Stop(enumerator);
		}

		/// <summary>
		/// A routine to wait until this coroutine has finished running.
		/// </summary>
		/// <returns>The wait enumerator.</returns>
		public IEnumerator wait()
		{
			if (enumerator != null)
				while (processorCoroutines.IsRunning(enumerator))
					yield return null;
		}

		/// <summary>
		/// True if the enumerator is currently running.
		/// </summary>
		public bool isRunning => enumerator != null && processorCoroutines.IsRunning(enumerator);
	}
}