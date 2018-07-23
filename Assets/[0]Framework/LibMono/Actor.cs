/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       12/09/2017 19:06
================================================================*/

using System;
using UnityEngine;
using System.Collections.Generic;


namespace Homebrew
{
	/// <summary>
	/// Base class for any game logic / complex entities 
	/// </summary>
	public abstract class Actor : MonoCached, IEntity
	{
		[HideInInspector] public int hashCode;
		[HideInInspector] public ProcessingTags tags = new ProcessingTags();
		 

		private Dictionary<int, object> components = new Dictionary<int, object>(EngineSettings.ActorElementsCount);
		private List<IRecieveTags> componentsTagRecievers = new List<IRecieveTags>(EngineSettings.ActorElementsCount);
		private List<IEnable> componentsEnableRecieves = new List<IEnable>();


		public Time Time => time;
		public ProcessingSignals Signals => signals;
		public ProcessingTags Tags => tags;
		public int HashCode => hashCode;

		/// <summary>
		/// A method to add all Data Components to Actor's container.
		/// </summary>
		protected abstract void SetupData();

		/// <summary>
		/// A method to add all Behavior Components to Actor's container.
		/// This method invokes with one frame delay after SetupData method.
		/// </summary>
		protected abstract void SetupBehaviors();


		protected override void OnAwake()
		{
			hashCode = GetHashCode();

			tags.Initialize(HandleTagsChanged);
			tags.Add(hashCode);

			SetupData();
			Timer.Add(Time.DeltaTime, SetupBehaviors);
		}


		protected override void OnTimeScaleChanged()
		{
			signals.Send(new SignalTimeScaleChanged());
		}


		#region PROCESSING

		public void HandleTagsChanged()
		{
			if (Toolbox.isQuittingOrChangingScene()) return;
			ProcessingEntities.Default.Changed(this);

			var amount = componentsTagRecievers.Count;
			for (int i = 0; i < amount; i++)
			{
				componentsTagRecievers[i].OnTagsChanged();
			}
		}

		#endregion

		#region PROCESSING ACTIVATION

		public override void OnEnable()
		{
			if (state.HasState(EntityState.OnHold)) return;
			if (state.HasState(EntityState.Enabled)) return;
			state &= ~EntityState.Released;
			state |= EntityState.Enabled;

			signals.Add(this);

			ProcessingUpdate.Default.Add(this);
			ProcessingEntities.Default.Add(this);

			var count = componentsEnableRecieves.Count;

			for (int i = 0; i < count; i++)
			{
				componentsEnableRecieves[i].Enable(true);
			}

			HandleEnable();
		}

		public override void OnDisable()
		{
			if (Toolbox.isQuittingOrChangingScene()) return;
			if (state.HasState(EntityState.Released)) return;
			if (!state.HasState(EntityState.Enabled)) return;
			state &= ~EntityState.Enabled;

			signals.Remove(this);

			ProcessingUpdate.Default.Remove(this);
			ProcessingEntities.Default.Remove(this);

			var count = componentsEnableRecieves.Count;

			for (int i = 0; i < count; i++)
			{
				componentsEnableRecieves[i].Enable(false);
			}

			HandleDisable();
		}

		#endregion

		#region PROCESSING ADD / REMOVE

		void AddBehavior(ActorBehavior behavior, bool enabled = true)
		{
			behavior.Awake(this);
			behavior.Enable(enabled);
		}


		T HandleAdd<T>(T component, bool enabled = true, Type desiredType = null)
		{
			var hash = desiredType == null ? typeof(T).GetHashCode() : desiredType.GetHashCode();

			components.Add(hash, component);

			var behavior = component as ActorBehavior;
			if (behavior != null) AddBehavior(behavior, enabled);
			else
			{
				var setupable = component as ISetup;
				if (setupable != null) setupable.Setup(this);
				tags.Add(hash);
			}

			var e =   component as IEnable;
			if (e != null) componentsEnableRecieves.Add(e);
			var t =   component as IRecieveTags;
			if (t != null) componentsTagRecievers.Add(t);


			return component;
		}

		public void Add<T>(T component, Type desiredType = null)
		{
			HandleAdd(component, true, desiredType);
		}

		public T Add<T>(bool enabled = true, Type desiredType = null) where T : new()
		{
			var component = new T();
			return HandleAdd(component, enabled, desiredType);
		}


		public void Remove<T>()
		{
			var hash = typeof(T).GetHashCode();
			object obj;

			if (components.TryGetValue(hash, out obj))
			{
				components.Remove(hash);
				var disposable = obj as IDisposable;
				disposable.Dispose();
				tags.Remove(hash);

				componentsEnableRecieves.Remove(obj as IEnable);
				componentsTagRecievers.Remove(obj as IRecieveTags);
			}
		}

		#endregion

		#region PROCESSING GET

		public T Get<T>(int hash)
		{
			return (T) components[hash];
		}


		public T Get<T>()
		{
			object obj;
			if (components.TryGetValue(typeof(T).GetHashCode(), out obj))
			{
				return (T) obj;
			}

			return typeof(T).IsSubclassOf(typeof(UnityEngine.Object)) ? GetComponentInChildren<T>() : default(T);
		}

		public T Get<T>(string path)
		{
			if (path == string.Empty) return GetComponentInChildren<T>();
			var o = selfTransform.Find(path);
			return o == null ? default(T) : o.GetComponent<T>();
		}

		public object Get(Type t)
		{
			object obj;
			components.TryGetValue(t.GetHashCode(), out obj);

			if (obj == null)
				if (t == typeof(Component))
					return GetComponentInChildren(t);

			return obj;
		}

		#endregion

		#region PROCESSING SEARCH

		public bool HasState(EntityState possibleState)
		{
			return state.HasState(possibleState);
		}

		public bool Contains<T>()
		{
			return components.ContainsKey(typeof(T).GetHashCode());
		}

		public bool Contains(int hash)
		{
			return components.ContainsKey(hash);
		}

		#endregion

		#region PROCESSING DEACTIVATION

		private void OnDestroy()
		{
			foreach (var value in components.Values)
			{
				var disposable = value as IDisposable;

				if (disposable != null)
				{
					disposable.Dispose();
				}
			}

			if (!Toolbox.isQuittingOrChangingScene())
			{
				ProcessingEntities.Default.Remove(this);
				ProcessingUpdate.Default.Remove(this);
			}

		                                                                     
			var timers = ProcessingTimer.Default.allWorkingTimers.FindAll(t =>  ReferenceEquals(t.id, this));
			for (int i = 0; i < timers.Count; i++)
			{
				timers[i].Dispose();
			}           

			components.Clear();
			componentsTagRecievers.Clear();
			componentsEnableRecieves.Clear();
		}

		public void HandleDestroy()
		{
			HandleDestroyGO();
		}

	 

		#endregion
	}
}