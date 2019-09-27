 
namespace Pixeye.Actors.Maths
{
	public struct float2
	{
		public float a;
		public float b;

		public float2(float a, float b)
		{
			this.a = a;
			this.b = b;
		}


		public float Between(float chance = 0.5f)
		{
			return UnityEngine.Random.value > chance ? a : b;
		}
	}
}