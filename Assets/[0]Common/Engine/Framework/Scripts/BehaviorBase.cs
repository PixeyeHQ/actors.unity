/*===============================================================
Product:    Unity3dTools
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/6/2018 1:37 PM
================================================================*/


namespace Homebrew
{
	public class BehaviorBase : IComponent
	{
		public Actor actor;

		public EntityState state;


		public void Awake()
		{
			state |= EntityState.Visible;
			Setup();
		}

		public void Activate(bool arg)
		{
			if (arg == false)
				state &= ~EntityState.Active;
			else state |= EntityState.Active;
		}

		public void Tick()
		{
			if (state.HasState(EntityState.ActiveAndEnabled) == false) return;
			OnTick();
		}

		public void TickLate()
		{
			if (state.HasState(EntityState.ActiveAndEnabled) == false) return;
			OnTickLate();
		}

		public void TickFixed()
		{
			if (state.HasState(EntityState.ActiveAndEnabled) == false) return;
			OnTickFixed();
		}

		public virtual void Setup()
		{
		}

		public virtual void OnTick()
		{
		}

		protected virtual void OnTickLate()
		{
		}

		protected virtual void OnTickFixed()
		{
		}


		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}


		public void Enable(bool isEnabled)
		{
			if (isEnabled)
			{
				if (state.HasState(EntityState.Enabled)) return;
				state |= EntityState.Enabled;
				OnEnable();
			}

			else
			{
				if (!state.HasState(EntityState.Enabled)) return;
				state &= ~EntityState.Enabled;
				OnDisable();
			}
		}

		public void Dispose()
		{
			OnDispose();
		}


		protected virtual void OnDispose()
		{
		}
	}
}