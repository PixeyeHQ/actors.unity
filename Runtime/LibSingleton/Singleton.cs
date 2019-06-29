using UnityEngine;

namespace Pixeye.Framework
{
	public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
	{

		public static T _instance;

		protected void Initialize()
		{
			if (_instance) return;
			_instance = this as T;
			DontDestroyOnLoad(_instance);
		}

		static object _lock = new object();

		public static T Instance
		{
			get
			{
				if (applicationIsQuitting)
				{
					Debug.LogWarning("[Singleton] Instance '" + typeof(T) +
					                 "' already destroyed on application quit." +
					                 " Won't create again - returning null.");
					return null;
				}

				lock (_lock)
				{
					if (_instance != null) return _instance;
					_instance = (T) FindObjectOfType(typeof(T));

					if (FindObjectsOfType(typeof(T)).Length > 1)
					{
						Debug.LogError("[Singleton] Something went really wrong " +
						               " - there should never be more than 1 singleton!" +
						               " Reopening the scene might fix it.");
						return _instance;
					}

					if (_instance != null) return _instance;
					var singleton = new GameObject();
					_instance = singleton.AddComponent<T>();
					singleton.name = typeof(T).Name;

					DontDestroyOnLoad(singleton);

					return _instance;
				}
			}
		}

		public static bool isQuittingOrChangingScene()
		{
			return applicationIsQuitting || changingScene;
		}

		public static bool changingScene;
		public static bool applicationIsQuitting;

		void OnDisable()
		{
			applicationIsQuitting = true;
		}

		virtual protected void OnApplicationQuit()
		{
			applicationIsQuitting = true;
		}

	}
}