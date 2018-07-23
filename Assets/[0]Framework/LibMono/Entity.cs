/*===============================================================
Product:    Unity-Framework
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/23/2018 2:04 PM
================================================================*/


using System;
using System.Collections.Generic;

namespace Homebrew
{
	public sealed class Entity : IEntity
	{
		[EnumFlag] public EntityState state;
		
		private ProcessingSignals signals = new ProcessingSignals();
		private ProcessingTags tags = new ProcessingTags();
		private Time time = new Time();
		private int hashCode;

		public ProcessingSignals Signals => signals;
		public ProcessingTags Tags => tags;
		public int HashCode => hashCode;
		public Time Time => time;

		private Dictionary<int, object> components = new Dictionary<int, object>(EngineSettings.ActorElementsCount);
		private List<IRecieveTags> componentsTagRecievers = new List<IRecieveTags>(EngineSettings.ActorElementsCount);
		private List<IEnable> componentsEnableRecieves = new List<IEnable>();

		public Entity()
		{
			hashCode = GetHashCode();
		}


		public object Get(Type t)
		{
			object obj;
			components.TryGetValue(t.GetHashCode(), out obj);
			return obj;
		}

		public T Get<T>()
		{
			object obj;
			if (components.TryGetValue(typeof(T).GetHashCode(), out obj))
			{
				return (T) obj;
			}

			return default(T);
		}

		public T Get<T>(int hash)
		{
			return (T) components[hash];
		}

		public T Get<T>(string path)
		{
			return default(T);
		}

		public bool Contains<T>()
		{
			return components.ContainsKey(typeof(T).GetHashCode());
		}

		public bool Contains(int hash)
		{
			return components.ContainsKey(hash);
		}

		public bool HasState(EntityState possibleState)
		{
			return state.HasState(possibleState);
		}

		public void HandleDestroy()
		{
	     
		}
	}
}