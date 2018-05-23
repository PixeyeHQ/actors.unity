/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       5/14/2018  6:34 PM
================================================================*/

using System;

namespace Homebrew
{
	public class GroupExcludeAttribute : Attribute
	{
		public int[] filter;

		public GroupExcludeAttribute(params int[] filter)
		{
			this.filter = filter;
		}
	}
}