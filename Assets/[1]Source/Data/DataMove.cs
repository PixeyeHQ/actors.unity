/*===============================================================
Product:    Unity3dTools
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/21/2018 9:06 PM
================================================================*/


namespace Homebrew
{
	[System.Serializable]
	public class DataMove : IData, ISetup
	{
		public float x;
		public float y;

		public void Dispose()
		{
		}

		public void Setup(Actor actor)
		{
			x = actor.selfTransform.position.x;
		}
	}
}