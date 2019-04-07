//   Project : Actors
//  Contacts : Pixeye - ask@pixeye.games 

using UnityEngine;

namespace Pixeye.Framework
{
    [CreateAssetMenu(fileName = "GameSession", menuName = "Actors Framework/Add/Data/GameSession")]
    public class GameSession : DataGame, IKernel
    {
        public static GameSession Default => Toolbox.Get<GameSession>();
    }
}
