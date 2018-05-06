/*===============================================================
Product:    Unity3dTools
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/6/2018 2:25 PM
================================================================*/


using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
	public class ProcessingUpdate : IDisposable
	{
		private List<ITick> ticks = new List<ITick>();
		private List<ITickFixed> ticksFixed = new List<ITickFixed>();
		private List<ITickLate> ticksLate = new List<ITickLate>();


		private int countTicks;
		private int countTicksFixed;
		private int countTicksLate;

		public int GetTicksCount()
		{
			return countTicks;
		}

		public ProcessingUpdate()
		{
			GameObject.Find("[KERNEL]").AddComponent<ComponentUpdate>().Setup(this);
		}

		public void Add(object updateble)
		{
			if (updateble is ITick)
				ticks.Add(updateble as ITick);

			if (updateble is ITickFixed)
				ticksFixed.Add(updateble as ITickFixed);

			if (updateble is ITickLate)
				ticksLate.Add(updateble as ITickLate);

			countTicks = ticks.Count;
			countTicksFixed = ticksFixed.Count;
			countTicksLate = ticksLate.Count;
		}

		public void Remove(object updateble)
		{
			if (Toolbox.isApplicationQuitting) return;

			if (updateble is ITick)
				ticks.Remove(updateble as ITick);

			if (updateble is ITickFixed)
				ticksFixed.Remove(updateble as ITickFixed);

			if (updateble is ITickLate)
				ticksLate.Remove(updateble as ITickLate);

			countTicks = ticks.Count;
			countTicksFixed = ticksFixed.Count;
			countTicksLate = ticksLate.Count;
		}

		public void Tick()
		{
		 
			for (var i = 0; i < countTicks; i++)
			{
				ticks[i].Tick();
			}
		}

		public void TickFixed()
		{
		 
			for (var i = 0; i < countTicksFixed; i++)
				ticksFixed[i].TickFixed();
		}

		public void TickLate()
		{
		 
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

		public static void HandleAdd(object updateble)
		{
			Toolbox.Get<ProcessingUpdate>().Add(updateble);
		}

		public static void HandleRemove(object updateble)
		{
			if (Toolbox.isApplicationQuitting) return;
			Toolbox.Get<ProcessingUpdate>().Remove(updateble);
		}
	}
}