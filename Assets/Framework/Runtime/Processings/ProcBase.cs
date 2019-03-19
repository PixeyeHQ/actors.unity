//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;


namespace Pixeye
{
	public abstract class ProcBase : IDisposable
	{
		protected ProcBase()
		{
			ProcGroupAttributes.Setup(this);
			ProcSignals.Default.Add(this);
		}


		public void Dispose()
		{
 
			ProcSignals.Default.Remove(this);
			ProcUpdate.Default.Remove(this);
 
			OnDispose();
		}


		protected virtual void OnDispose()
		{
		}
	}
}