/*===============================================================
Product:    Unity-Framework
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/23/2018 1:57 PM
================================================================*/


namespace Homebrew
{
	public class Behavior : IComponent, IEnable
	{
		protected IEntity entity;
		protected EntityState state;


		public void Awake(IEntity entity)
		{
			this.entity = entity;
			state |= EntityState.Visible;
			state |= EntityState.Active;
			ProcessingBehaviorAttributes.Default.Setup(this, entity);
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


//		public virtual void OnTagsChanged()
//		{
//		}

		/// <summary>
		/// Behavior initialize method for extra binds and caching. Works only once.
		/// </summary>
		protected virtual void Setup()
		{
		}

		protected virtual void HandleEnable()
		{
		}

		protected virtual void HandleDisable()
		{
		}

		protected T Get<T>()
		{
			return entity.Get<T>();
		}

		protected T Get<T>(string path)
		{
			return entity.Get<T>(path);
		}

		public void Enable(bool arg)
		{
			if (arg)
			{
				if (state.HasState(EntityState.Enabled)) return;
				state |= EntityState.Enabled;
				entity.Signals.Add(this);
				ProcessingUpdate.Default.Add(this);
				HandleEnable();
			}
			else
			{
				if (!state.HasState(EntityState.Enabled)) return;
				state &= ~EntityState.Enabled;
				entity.Signals.Remove(this);
				ProcessingUpdate.Default.Remove(this);
				HandleDisable();
			}
		}


		public void Dispose()
		{
			if (Toolbox.isQuittingOrChangingScene()) return;
			ProcessingUpdate.Default.Remove(this);
			entity.Signals.Remove(this);
			OnDispose();
			entity = null;
		}

		protected virtual void OnDispose()
		{
		}
	}
}