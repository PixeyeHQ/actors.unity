using Homebrew;


public class ActorTest : Actor, ITick
{
	[Foldout("Setup")] public DataTest t;
	protected override void Setup()
	{
		Add(t);         
		Add<BehaviorTest>();      
	}                                  
}                           