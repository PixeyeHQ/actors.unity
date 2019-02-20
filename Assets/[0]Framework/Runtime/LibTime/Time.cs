/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       1/31/2018  8:17 PM
================================================================*/


using UnityEngine;

namespace Homebrew
{
	public class Time : ITick, IKernel, IComponent
	{
		public static Time Default;
		protected const float fps = 60;

		public float isActive = 1.0f;
		public float timeScale = 1.0f;


		protected float _deltaTimeFixed;
		protected float _deltaTime;
		protected float _lastFrame;


		public static float delta => Default._deltaTime;
		public static float frame;
		public static float deltaFixed => Default._deltaTimeFixed;

		public float timeScaleCached = 1;


		public Time() { ProcessingUpdate.Default.Add(this); }

		public void OnFocus() { _lastFrame = UnityEngine.Time.realtimeSinceStartup; }

		public void Tick()
		{
			frame = UnityEngine.Time.frameCount;
			var timeSinceStart = UnityEngine.Time.unscaledTime;
			_deltaTime = UnityEngine.Time.deltaTime * isActive * timeScale;
			_deltaTimeFixed = 1 / fps * timeScale;
			_lastFrame = timeSinceStart;
		}
	}
}