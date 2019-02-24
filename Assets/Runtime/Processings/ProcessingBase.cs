//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;


namespace Pixeye
{
	public abstract class ProcessingBase : IDisposable
	{
		protected ProcessingBase()
		{
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