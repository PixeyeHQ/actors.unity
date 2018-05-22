/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       4/30/2018  9:54 AM
================================================================*/

using System;


namespace Homebrew
{
	public abstract class ProcessingBase : IDisposable
	{
		protected ProcessingBase()
		{
			ProcessingAttributes.Default.Setup(this);
			ProcessingSignals.Default.Add(this);
		}


		public void Dispose()
		{
			Toolbox.Get<ProcessingSignals>().Remove(this);

			OnDispose();
		}


		protected virtual void OnDispose()
		{
		}
	}
}