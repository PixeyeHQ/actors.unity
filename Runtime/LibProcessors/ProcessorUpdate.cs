//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Framework
{
	public sealed class ProcessorUpdate : MonoBehaviour, IDisposable, IKernel
	{
		public static ProcessorUpdate Default;

		internal static List<Time> times = new List<Time>();
		internal static int timesLen = 0;

		List<ITick> ticks = new List<ITick>(1000);
		List<ITickFixed> ticksFixed = new List<ITickFixed>();
		List<ITickLate> ticksLate = new List<ITickLate>();

		int countTicks;
		int countTicksFixed;
		int countTicksLate;

		void Awake()
		{
			Default = this;
		}

		public int GetTicksCount()
		{
			return countTicks;
		}

		public static void AddTick(object updateble)
		{
			Default.ticks.Add(updateble as ITick);
			Default.countTicks++;
		}

		public static void RemoveTick(object updateble)
		{
			Default.ticks.Remove(updateble as ITick);
			Default.countTicks--;
		}


		public static void AddTickFixed(object updateble)
		{
			Default.ticksFixed.Add(updateble as ITickFixed);
			Default.countTicksFixed++;
		}

		public static void RemoveTickFixed(object updateble)
		{
			Default.ticksFixed.Remove(updateble as ITickFixed);
			Default.countTicksFixed--;
		}


		public static void AddTickLate(object updateble)
		{
			Default.ticksLate.Add(updateble as ITickLate);
			Default.countTicksLate++;
		}

		public static void RemoveTickLate(object updateble)
		{
			Default.ticksLate.Remove(updateble as ITickLate);
			Default.countTicksLate--;
		}


		public static void Add(object updateble)
		{
			var tickable = updateble as ITick;
			if (tickable != null)
			{
				Default.ticks.Add(tickable);

				Default.countTicks++;
			}

			var tickableFixed = updateble as ITickFixed;
			if (tickableFixed != null)
			{
				Default.ticksFixed.Add(tickableFixed);
				Default.countTicksFixed++;
			}

			var tickableLate = updateble as ITickLate;
			if (tickableLate != null)
			{
				Default.ticksLate.Add(tickableLate);
				Default.countTicksLate++;
			}
		}

		public static void Remove(object updateble)
		{
			if (Default.ticks.Remove(updateble as ITick))
			{
				Default.countTicks--;
			}

			if (Default.ticksFixed.Remove(updateble as ITickFixed))
			{
				Default.countTicksFixed--;
			}

			if (Default.ticksLate.Remove(updateble as ITickLate))
			{
				Default.countTicksLate--;
			}
		}

		void Update()
		{
			if (Toolbox.changingScene) return;

 
			var delta = Time.delta * Time.Default.timeScale;

			for (int i = 0; i < timesLen; i++)
			{
				times[i].Tick();
			}

			for (var i = 0; i < countTicks; i++)
			{
				ticks[i].Tick(delta);
			}
		}

		void FixedUpdate()
		{
			if (Toolbox.changingScene) return;
			var delta = Time.deltaFixed;
			for (var i = 0; i < countTicksFixed; i++)
				ticksFixed[i].TickFixed(delta);
		}

		void LateUpdate()
		{
			if (Toolbox.changingScene) return;
			var delta = Time.delta;
			for (var i = 0; i < countTicksLate; i++)
				ticksLate[i].TickLate(delta);
		}


		public void Dispose()
		{
			countTicks = 0;
			countTicksFixed = 0;
			countTicksLate = 0;

			ticks.RemoveAll(t => t is IKernel == false);
			
			ticksFixed.Clear();
			ticksLate.Clear();

			countTicks = ticks.Count;
		}

		public static void Create()
		{
			var obj = new GameObject("ActorsUpdate");
			DontDestroyOnLoad(obj);
			Default = obj.AddComponent<ProcessorUpdate>();
		}
	}
}