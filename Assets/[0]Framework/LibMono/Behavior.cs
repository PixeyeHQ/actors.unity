/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       06/10/2017 21:47
================================================================*/


using UnityEngine;

namespace Homebrew
{
	public abstract class Behavior : IComponent
	{
		protected Actor actor;
		protected EntityState state;


		public void SetActor(Actor actor)
		{
			this.actor = actor;

			ProcessingBehaviorAttributes.Default.Setup(this, actor);
		}

		public void Awake()
		{
			Setup();
			state |= EntityState.Visible;
			Enable(true);
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


		public void TickFixed()
		{
			if (state.HasState(EntityState.ActiveAndEnabled) == false) return;


			OnTickFixed();
		}

		public void TickLate()
		{
			if (state.HasState(EntityState.ActiveAndEnabled) == false) return;


			OnTickLate();
		}


		protected virtual void Setup()
		{
		}

		public virtual void OnTick()
		{
		}


		protected virtual void OnTickFixed()
		{
		}

		protected virtual void OnTickLate()
		{
		}


		protected T Get<T>() where T : class
		{
			return actor.Get<T>();
		}

		protected T Get<T>(string place = default(string)) where T : Object
		{
			return actor.Get<T>(place);
		}


		public virtual void OnTagsChanged()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}


		protected virtual void OnSpawn()
		{
		}

		protected virtual void OnDespawn()
		{
		}


		public void Enable(bool isEnabled)
		{
			if (isEnabled)
			{
				if (state.HasState(EntityState.Enabled)) return;


				state |= EntityState.Enabled;
				actor.signals.Add(this);
				OnEnable();
			}
			else
			{
				if (!state.HasState(EntityState.Enabled)) return;

				state &= ~EntityState.Enabled;

				actor.signals.Remove(this);
				OnDisable();
			}
		}

		public void Spawn(bool isSpawned)
		{
			if (isSpawned) OnSpawn();
			else OnDespawn();
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