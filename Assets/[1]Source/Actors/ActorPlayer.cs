using Homebrew;
using UnityEngine;


public class ActorPlayer : Actor, ITick
{
	[FoldoutGroup("Setup")] public DataMove dataMove;
	protected override void Setup()
	{
		Add(dataMove);         
		Add<BehaviorInput>();      
	}

	protected override void OnTick()
	{
		base.OnTick();
		if (Input.GetKeyDown(KeyCode.A))
			ProcessingSceneLoad.To(Scenes.sceneTest);
		if (Input.GetKeyDown(KeyCode.Q))
			ProcessingSceneLoad.To(Scenes.sceneTest);
	}
}                           