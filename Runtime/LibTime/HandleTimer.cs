/*===============================================================
Product:    Shoot off their lumps
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       23/12/2017 17:04
================================================================*/

using System;
using System.Collections.Generic;

namespace Pixeye.Framework
{
	public class HandleTimer : IDisposable, IKernel
	{

		public static HandleTimer Default = new HandleTimer();
		public readonly List<Timer> allWorkingTimers = new List<Timer>();

		public void Dispose()
		{
			for ( var i = 0; i < allWorkingTimers.Count; i++ )
			{
				allWorkingTimers[i].Dispose();
			}

			allWorkingTimers.Clear();
		}

	}
}