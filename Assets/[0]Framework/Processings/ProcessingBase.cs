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
			ProcessingGroupAttributes.Default.Setup(this);
			ProcessingSignals.Default.Add(this);
			ProcessingUpdate.Default.Add(this);
		}


		public void Dispose()
		{
 
			Toolbox.Get<ProcessingSignals>().Remove(this);
			ProcessingUpdate.Default.Remove(this);
 
			OnDispose();
		}


		protected virtual void OnDispose()
		{
		}
	}
}