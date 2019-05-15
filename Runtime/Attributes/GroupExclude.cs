/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       5/14/2018  6:34 PM
================================================================*/

using System;

namespace Pixeye.Framework
{
	public class GroupExcludeAttribute : Attribute
	{

		public int[] filter = new int[0];
		public int[] filterType = new int[0];

		public GroupExcludeAttribute(params int[] filter)
		{
			this.filter = filter;
		}

		public GroupExcludeAttribute(params Type[] filterType)
		{
			this.filterType = new int[filterType.Length];

			for (int i = 0; i < filterType.Length; i++)
			{
				this.filterType[i] = Storage.allDict[filterType[i].GetHashCode()].GetComponentID();
			}
		}
 

	}
}