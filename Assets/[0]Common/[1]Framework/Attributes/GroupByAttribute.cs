/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       5/14/2018  6:33 PM
================================================================*/

using System;
 
namespace Homebrew
{
	public class GroupByAttribute : Attribute
	{
		public int[] filter;

		public GroupByAttribute(params int[] filter)
		{
			this.filter = filter;
		}

		public GroupByAttribute(params object[] f)
		{
			filter = new int[f.Length];
			for (var i = 0; i < f.Length; i++)
			{
				if (f[i] is int)
				{
					filter[i] = (int) f[i];
				}

				else
				{
					filter[i] = f[i].GetHashCode();
				}
			}
		}

 
	}
}