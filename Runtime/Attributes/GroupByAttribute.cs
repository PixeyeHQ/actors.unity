/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       5/14/2018  6:33 PM
================================================================*/

using System;

namespace Pixeye.Actors
{
	public class GroupByAttribute : Attribute
	{
		public int[] filter;

		public GroupByAttribute(params int[] filter)
		{
			this.filter = filter;
		}
	}
}