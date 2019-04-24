//  Project : game.metro
// Contacts : Pix - ask@pixeye.games

using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Pixeye.Framework
{
	[CreateAssetMenu(fileName = "DataTypes", menuName = "Actors/Add/Util/DataTypes")]
	public class DataTypes : SerializedScriptableObject
	{

		public Type[] allTypes = new Type[0];

	}
}