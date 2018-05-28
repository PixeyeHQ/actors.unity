using Homebrew;


public class ActorPlayer : Actor, ITick
{
	[FoldoutGroup("Setup")] public DataMove dataMove;
	protected override void Setup()
	{
		Add(dataMove);         
		Add<BehaviorInput>();      
	}                                  
}                           