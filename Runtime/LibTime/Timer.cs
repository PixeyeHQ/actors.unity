/*===============================================================
Product:    ecs
Developer:  Dimitry Pixeye - pixeye@hbrew.store
================================================================*/

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Pixeye.Source;
using UnityEngine;

namespace Pixeye.Framework
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
	public struct Timer
	{
		public Action action;
		public float t;
		internal int pointer;
	 

		/// <summary>
		/// Create a new timer. Timers a great for adding delayed actions.
		/// </summary>
		/// <param name="finishTime"></param>
		/// <param name="action"></param>
		public Timer(float finishTime, Action a)
		{
		  t = finishTime;
			action = a;
			pointer = -1;
		}

		/// <summary>
		/// Create a new timer and pass it to the processor. Timers a great for adding delayed actions.
		/// </summary>
		/// <param name="finishTime"></param>
		/// <param name="action"></param>
		/// <returns>Timer</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref Timer Add(float finishTime, Action action)
		{
			return ref ProcessorTimer.Default.Add(finishTime, action);
		}

		public void Stop()
		{
			#if UNITY_EDITOR

			if (pointer == -1 || pointer > ProcessorTimer.Default.length)
			{
				Debug.LogError("Can't stop the timer that is not in the system.");
				return;
			}

			#endif

			ProcessorTimer.Default.RemoveAt(pointer);
			pointer = -1;
		}

		/// <summary>
		/// Pass timer to the processor
		/// </summary>
		public void Restart()
		{
			pointer = ProcessorTimer.Default.Restart(t, action);
		}

	}

}