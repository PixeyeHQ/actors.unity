/*===============================================================
Product:    Shoot off their lumps
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       23/12/2017 17:04
================================================================*/

using System;
using System.Collections.Generic;


namespace Homebrew
{
	public class ProcessingTimer : IDisposable, IKernel
	{
		public static ProcessingTimer Default = new ProcessingTimer();
		public readonly List<Timer> allWorkingTimers = new List<Timer>();
		public void Dispose()
		{
			for (var i = 0; i < allWorkingTimers.Count; i++)
			{
				allWorkingTimers[i].Dispose();
			}

			allWorkingTimers.Clear();
		 
		}
	}
}