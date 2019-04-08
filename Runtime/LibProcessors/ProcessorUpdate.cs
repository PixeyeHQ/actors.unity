//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Framework
{
	public class ProcessorUpdate : MonoBehaviour, IDisposable, IKernel
	{
		List<ITick> ticks = new List<ITick>(1000);
		List<ITickFixed> ticksFixed = new List<ITickFixed>();
		List<ITickLate> ticksLate = new List<ITickLate>();

		public static ProcessorUpdate Default;

		int countTicks;
		int countTicksFixed;
		int countTicksLate;

		void Awake() { Default = this; }

		public int GetTicksCount() { return countTicks; }

		public void Add(object updateble)
		{
			var tickable = updateble as ITick;
			if (tickable != null)
			{
				ticks.Add(tickable);

				countTicks++;
			}

			var tickableFixed = updateble as ITickFixed;
			if (tickableFixed != null)
			{
				ticksFixed.Add(tickableFixed);
				countTicksFixed++;
			}

			var tickableLate = updateble as ITickLate;
			if (tickableLate != null)
			{
				ticksLate.Add(tickableLate);
				countTicksLate++;
			}
		}

		public void Remove(object updateble)
		{
			if (ticks.Remove(updateble as ITick))
			{
				countTicks--;
			}

			if (ticksFixed.Remove(updateble as ITickFixed))
			{
				countTicksFixed--;
			}

			if (ticksLate.Remove(updateble as ITickLate))
			{
				countTicksLate--;
			}
		}


		void Update()
		{
			
			if (Toolbox.changingScene) return;
			
			for (var i = 0; i < countTicks; i++)
			{
				ticks[i].Tick();
			}
		}

		void FixedUpdate()
		{
			if (Toolbox.changingScene) return;
			for (var i = 0; i < countTicksFixed; i++)
				ticksFixed[i].TickFixed();
		}

		void LateUpdate()
		{
			if (Toolbox.changingScene) return;
			for (var i = 0; i < countTicksLate; i++)
				ticksLate[i].TickLate();
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