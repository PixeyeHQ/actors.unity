/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       1/31/2018  8:17 PM
================================================================*/


namespace Homebrew
{
	[System.Serializable]
	public class Time : ITick, IKernel, IComponent
	{
		public static Time Default;

		protected const float fps = 30;
		protected float _deltaTimeFixed;
		protected float _deltaTime;
		protected float _lastFrame;
		public float isActive = 1.0f;
		public float timeScale = 1.0f;
 
		public float deltaTime => Default._deltaTime * timeScale;

		public float deltaTimeFixed => Default._deltaTimeFixed * timeScale;

		public static float DeltaTime => Default._deltaTime * Default.timeScale;

		public static float DeltaTimeFixed => Default._deltaTimeFixed * Default.timeScale;


		public Time()
		{
			_deltaTimeFixed = 1 / fps;
		}

		public void OnFocus()
		{
			_lastFrame = UnityEngine.Time.realtimeSinceStartup;
		}

		public void Tick()
		{
			var timeSinceStart = UnityEngine.Time.realtimeSinceStartup;
			_deltaTime = (timeSinceStart - _lastFrame) * isActive;
			_lastFrame = timeSinceStart;
		}

		public void Dispose()
		{
			 
		}
	}
}