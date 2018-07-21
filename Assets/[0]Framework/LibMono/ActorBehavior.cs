/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       06/10/2017 21:47
================================================================*/


namespace Homebrew
{
	/// <summary>
	/// Base class for all Actor related behaviors. Behaviors process data.
	/// Use [Bind] attribute to link behavior with data poiniters.
	/// </summary>
	public abstract class ActorBehavior : IComponent
	{
		protected Actor actor;
		protected EntityState state;


		public void Awake(Actor actor)
		{
			this.actor = actor;
			state |= EntityState.Visible;
			state |= EntityState.Active;
			ProcessingBehaviorAttributes.Default.Setup(this, actor);
			Setup();
		}

		/// <summary>
		/// Inactive behaviors will recieve signals but won't be updated
		/// </summary>
		/// <param name="arg"></param>
		public void Activate(bool arg)
		{
			if (!state.HasState(EntityState.Enabled)) return;


			if (!arg && state.HasState(EntityState.Active))
			{
				state &= ~EntityState.Active;
				ProcessingUpdate.Default.Remove(this);
			}
			else if (arg && !state.HasState(EntityState.Active))
			{
				state |= EntityState.Active;
				ProcessingUpdate.Default.Add(this);
			}
		}


		public virtual void OnTagsChanged()
		{
		}

		/// <summary>
		/// Behavior initialize method for extra binds and caching. Works only once.
		/// </summary>
		protected virtual void Setup()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected T Get<T>()
		{
			return actor.Get<T>();
		}

		protected T Get<T>(string path)
		{
			return actor.Get<T>(path);
		}

		public void Enable(bool isEnabled)
		{
			if (isEnabled)
			{
				if (state.HasState(EntityState.Enabled)) return;
				state |= EntityState.Enabled;
				actor.GetSignals.Add(this);
				ProcessingUpdate.Default.Add(this);
				OnEnable();
			}
			else
			{
				if (!state.HasState(EntityState.Enabled)) return;
				state &= ~EntityState.Enabled;
				actor.GetSignals.Remove(this);
				ProcessingUpdate.Default.Remove(this);
				OnDisable();
			}
		}


		public void Dispose()
		{
			if (Toolbox.isQuittingOrChangingScene()) return;
			ProcessingUpdate.Default.Remove(this);
			OnDispose();
			actor = null;
		}

		protected virtual void OnDispose()
		{
		}
	}
}