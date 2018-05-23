using Homebrew;
using UnityEngine;

[CreateAssetMenu(fileName = "CommandsDefault", menuName = "Commands/CommandsDefault")]
public class CommandsConsoleDefault : CommandsConsole
{
	[Bind]
	public void TestCommand(string name)
	{
		Debug.Log(name);
	}
}