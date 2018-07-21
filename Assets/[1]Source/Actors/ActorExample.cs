using Homebrew;


public class ActorExample : Actor
{
	[FoldoutGroup("Setup")] public DataExample dataExample;

	protected override void SetupData()
	{
		Add(dataExample);
	}

	protected override void SetupBehaviors()
	{
		Add<BehaviorExample>();
	}
}