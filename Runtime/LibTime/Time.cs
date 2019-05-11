//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

namespace Pixeye.Framework
{
	public class Time :  IKernel
	{
		protected const float fps = 60;
		
		/// <summary>
		/// <para> Default Framework Time. Use it for independent timing</para>
		/// </summary>
		public static Time Default = new Time();
		public static int frame => UnityEngine.Time.frameCount;
	 
	 
		/// <summary>
		///   <para> The scale at which the time is passing. This can be used for slow motion effects.</para>
		/// </summary>
		public float timeScale = 1.0f;


		protected float _deltaTimeFixed;
		protected float _deltaTime;
		
		internal float timeScaleCached = 1.0f;
		/// <summary>
		/// <para> The time in seconds it took to complete the last frame</para>
		/// </summary>
		public static float delta => Default._deltaTime;
		/// <summary>
		/// <para> 1 / 60 constant time</para>
		/// </summary>
		public static float deltaFixed => Default._deltaTimeFixed;


		public Time()
		{
			ProcessorUpdate.times.Add(this);
			ProcessorUpdate.timesLen++;
			_deltaTimeFixed = 1 / fps;
			_deltaTime = _deltaTimeFixed;
		}


		public void Tick()
		{
			_deltaTime = UnityEngine.Time.deltaTime * timeScale;
			_deltaTimeFixed *= timeScale;
		}
	}
}