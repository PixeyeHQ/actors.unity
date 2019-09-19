//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;

namespace Pixeye.Framework
{
	public abstract class Processor : IDisposable
	{
		protected Processor()
		{
			ProcessorGroups.Setup(this);
			ProcessorSignals.Add(this);
			Toolbox.disposables.Add(this);
		}

		public void Dispose()
		{
			ProcessorSignals.Remove(this);
			ProcessorUpdate.Remove(this);

			OnDispose();
		}

		protected virtual void OnDispose()
		{
		}
	}


	public abstract class ProcessorGroup : GroupEvents, IDisposable
	{
		protected ProcessorGroup()
		{
			ProcessorInitializer.Setup(this);
			ProcessorSignals.Add(this);
			Toolbox.disposables.Add(this);
		}

		public void Dispose()
		{
			ProcessorSignals.Remove(this);
			ProcessorUpdate.Remove(this);

			OnDispose();
		}
		protected virtual void OnDispose()
		{
		}
	}

	public abstract class Processor<T> : ProcessorGroup
	{
		public Group<T> source = null;
	}

	public abstract class Processor<T, Y> : ProcessorGroup
	{
		public Group<T, Y> source = null;
	}

	public abstract class Processor<T, Y, U> : ProcessorGroup
	{
		public Group<T, Y, U> source = null;
	}

	public abstract class Processor<T, Y, U, I> : ProcessorGroup
	{
		public Group<T, Y, U, I> source = null;
	}

	public abstract class Processor<T, Y, U, I, O> : ProcessorGroup
	{
		public Group<T, Y, U, I, O> source = null;
	}

	public abstract class Processor<T, Y, U, I, O, P> : ProcessorGroup
	{
		public Group<T, Y, U, I, O, P> source = null;
	}

	public abstract class Processor<T, Y, U, I, O, P, A> : ProcessorGroup
	{
		public Group<T, Y, U, I, O, P, A> source = null;
	}

	public abstract class Processor<T, Y, U, I, O, P, A, S> : ProcessorGroup
	{
		public Group<T, Y, U, I, O, P, A, S> source = null;
	}

	public abstract class Processor<T, Y, U, I, O, P, A, S, D> : ProcessorGroup
	{
		public Group<T, Y, U, I, O, P, A, S, D> source = null;
	}

	public abstract class Processor<T, Y, U, I, O, P, A, S, D, F> : ProcessorGroup
	{
		public Group<T, Y, U, I, O, P, A, S, D, F> source = null;
	}
}