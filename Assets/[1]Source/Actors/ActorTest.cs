using Homebrew;


public class ActorTest : Actor, ITick
{
	[FoldoutGroup("Setup")] public DataTest t;
	protected override void Setup()
	{
		Add(t);         
		Add<BehaviorTest>();      
	}                                  
}                           