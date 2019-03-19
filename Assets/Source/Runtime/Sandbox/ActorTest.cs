//  Project : ecs
// Contacts : Pix - ask@pixeye.games


namespace Pixeye
{
	public class ActorTest : Actor
	{
		[FoldoutGroup("Setup")]
		public ComponentTest cTest;

		protected override void Setup()
		{
			Add(cTest);
		}
	}
}