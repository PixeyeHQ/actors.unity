/*===============================================================
Product:    Shoot off their lumps
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       20/12/2017 10:18
================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
    public class ProcessingUpdate : MonoBehaviour, IDisposable
    {
        private List<ITick> ticks = new List<ITick>(1000);
        private List<ITickFixed> ticksFixed = new List<ITickFixed>();
        private List<ITickLate> ticksLate = new List<ITickLate>();

        public static ProcessingUpdate Default;

        private int countTicks;
        private int countTicksFixed;
        private int countTicksLate;

        private void Awake()
        {
            Default = this;
            Toolbox.Add(this);
        }

        public int GetTicksCount()
        {
            return countTicks;
        }

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
            if (Toolbox.applicationIsQuitting) return;

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


        private void Update()
        {
            if (Toolbox.changingScene) return;
            for (var i = 0; i < countTicks; i++)
            {
                ticks[i].Tick();
            }
        }

        private void FixedUpdate()
        {
            if (Toolbox.changingScene) return;
            for (var i = 0; i < countTicksFixed; i++)
                ticksFixed[i].TickFixed();
        }

        private void LateUpdate()
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
    }
}