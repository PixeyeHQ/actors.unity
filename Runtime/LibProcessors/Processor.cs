//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;

namespace Pixeye.Framework
{
	public abstract class Processor : IDisposable
	{

		protected Processor()
		{
			ProcessorGroupAttributes.Setup(this);
			ProcessorSignals.Default.Add(this);
		}

		public void Dispose()
		{
			ProcessorSignals.Default.Remove(this);
			ProcessorUpdate.Default.Remove(this);

			OnDispose();
		}

		protected virtual void OnDispose()
		{
		}

	}
}