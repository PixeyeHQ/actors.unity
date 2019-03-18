//  Project : ecs
// Contacts : Pix - ask@pixeye.games


using UnityEngine;

namespace Pixeye
{
	public class StarterTest : Starter
	{

		public GameObject go;
  	public int amount = 50;
		public static GameObject gogo;
		protected override void Setup()
		{
			gogo = go;
			Add<ProcessingTest>();


 
			
			for (int i = 0; i < amount; i++)
			{
				Instantiate(go);
			}

		}

		void Update()
		{
			 
		}
	}
}