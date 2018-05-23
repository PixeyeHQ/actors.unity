using System;

namespace Homebrew
{

	public class BindAttribute : Attribute
	{
 	
		public int bindType;
		
		public BindAttribute()
		{
		 	
		}
		public BindAttribute(int bindType)
		{
			this.bindType = bindType;
		}
	}

	public class From
	{
		public const int Toolbox = 1;
		public const int Object = 2;
		public const int Blueprint = 3;
	}
 

}
 