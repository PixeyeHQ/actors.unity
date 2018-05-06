/*===============================================================
Product:    Unity3dTools
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/6/2018 1:37 PM
================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
	public abstract class Actor : MonoCached
	{
	 
		private Dictionary<int, object> components = new Dictionary<int, object>();
		private List<BehaviorBase> behaviours = new List<BehaviorBase>();

		private List<ITick> ticks = new List<ITick>();
		private List<ITickFixed> ticksFixed = new List<ITickFixed>();
		private List<ITickLate> ticksLate = new List<ITickLate>();

		private int countBehaviors;

		private int countTicks;
		private int countTicksFixed;
		private int countTicksLate;

		protected override void OnAwake()
		{
			Setup();
		}

		public override void Tick()
		{
			for (var i = 0; i < countTicks; i++)
			{
				ticks[i].Tick();
			}

			OnTick();
		}

		public override void TickLate()
		{
			for (var i = 0; i < countTicksLate; i++)
			{
				ticksLate[i].TickLate();
			}


			for (var i = 0; i < countBehaviors; i++)
			{
				behaviours[i].TickLate();
			}

			OnTickLate();
		}

		public override void TickFixed()
		{
			for (var i = 0; i < countTicksFixed; i++)
			{
				ticksFixed[i].TickFixed();
			}

			OnTickFixed();
		}


		protected virtual void OnTick()
		{
		}

		protected virtual void OnTickFixed()
		{
		}

		protected virtual void OnTickLate()
		{
		}


		protected override void OnEnable()
		{
			if (state.HasState(EntityState.Enabled)) return;
			state |= EntityState.Enabled;
			state &= ~EntityState.Released;

			ProcessingUpdate.HandleAdd(this);


			for (var i = 0; i < countBehaviors; i++)
			{
				behaviours[i].Enable(true);
			}
		}

		protected override void OnDisable()
		{
			if (Toolbox.isApplicationQuitting) return;

			if (state.HasState(EntityState.Released)) return;
			if (!state.HasState(EntityState.Enabled)) return;

			state &= ~EntityState.Enabled;

			for (var i = 0; i < behaviours.Count; i++)
			{
				behaviours[i].Enable(false);
			}

			ProcessingUpdate.HandleRemove(this);
		}


		public T Add<T>(bool enabled = true, Type desiredType = null) where T : new()
		{
			var component = new T();
			return HandleAdd(component, enabled, desiredType);
		}

		public T Add<T>(T component, Type desiredType = null)
		{
			return HandleAdd(component, true, desiredType);
		}

		private T HandleAdd<T>(T component, bool enabled = true, Type desiredType = null)
		{
			var hash = desiredType == null ? typeof(T).GetHashCode() : desiredType.GetHashCode();


			if (!HandleAddBehavior(component, enabled))
			{
				var setupable = component as ISetup;
				if (setupable != null) setupable.Setup(this);
			}


			var tick = component as ITick;
			var tickFixed = component as ITickFixed;
			var tickLate = component as ITickLate;

			if (tick != null)
			{
				ticks.Add(tick);
				countTicks++;
			}

			if (tickFixed != null)
			{
				ticksFixed.Add(tickFixed);
				countTicksFixed++;
			}

			if (tickLate != null)
			{
				ticksLate.Add(tickLate);
				countTicksLate++;
			}

			components.Add(hash, component);
			return component;
		}

		
		private bool HandleAddBehavior<T>(T component, bool enabled = true)
		{
			var behavior = component as BehaviorBase;
			if (behavior == null) return false;
			behavior.actor = this;
			behavior.Awake();
			behavior.Activate(enabled);
			behaviours.Add(behavior);
			countBehaviors++;
			return true;
		}

		public T Get<T>() where T : class
		{
			object obj;
			if (components.TryGetValue(typeof(T).GetHashCode(), out obj))
			{
				return (T) obj;
			}
 
			return null;
		}

		public T Get<T>(string path = default(string))
		{
			return path == string.Empty ? GetComponentInChildren<T>() : selfTransform.Find(path).GetComponent<T>();
		}
		
		protected override void OnDispose()
		{
			countTicks = 0;
			countTicksFixed = 0;
			countTicksLate = 0;
			countBehaviors = 0;
		 
			foreach (var value in components.Values)
			{
				var disposable = value as IDisposable;

				if (disposable == null) continue;
				disposable.Dispose();
			}

			ProcessingUpdate.HandleRemove(this);
		
			ticks.Clear();
			ticksFixed.Clear();
			ticksLate.Clear();

			behaviours.Clear();
			components.Clear();
		}	

		protected abstract void Setup();
	}
}