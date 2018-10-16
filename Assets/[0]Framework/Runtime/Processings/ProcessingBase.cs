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
			ProcessingSystemAttributes.Setup(this);
			ProcessingGroupAttributes.Setup(this);
			ProcessingSignals.Default.Add(this);
		}


		public void Dispose()
		{
 
			ProcessingSignals.Default.Remove(this);
			ProcessingUpdate.Default.Remove(this);
 
			OnDispose();
		}


		protected virtual void OnDispose()
		{
		}
	}
}