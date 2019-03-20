//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Pixeye
{
	public class EditorActorsGUI
	{

		static readonly Stack<bool> s_EnabledStack = new Stack<bool>();

		internal static void BeginDisabled(bool disabled)
		{
			s_EnabledStack.Push(GUI.enabled);
			GUI.enabled &= !disabled;
		}

		internal static void EndDisabled()
		{
			if (s_EnabledStack.Count <= 0)
				return;
			GUI.enabled = s_EnabledStack.Pop();
		}

	}
}