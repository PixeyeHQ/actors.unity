using Homebrew;
using UnityEngine;

public class BehaviorExample : ActorBehavior, ITick
{
	[Bind] private DataExample dataExample;

	public void Tick()
	{
		Debug.Log(dataExample.x);
	}
}