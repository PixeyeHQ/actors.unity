//   Project : Actors
//  Contacts : Pixeye - ask@pixeye.games 

using UnityEngine;

namespace Pixeye.Framework
{
	[CreateAssetMenu(fileName = "GameSettings", menuName = "Actors Framework/Add/Data/GameSettings")]
	public class GameSettings : DataGame, IKernel
	{

		public static GameSettings Default => Toolbox.Get<GameSettings>();

	}
}