/*===============================================================
Product:    BattlecruiserPrototype
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       4/28/2018 5:23 PM
================================================================*/


using System;

namespace Pixeye.Actors
{
	[AttributeUsage(AttributeTargets.Field)]
	public class TagFieldAttribute : Attribute
	{
        public string categoryName;
        public string className;

        public TagFieldAttribute(string categoryName, Type clas)
        {
            this.categoryName = categoryName;
            className = clas.ToString();
        }

        public TagFieldAttribute(Type clas, string categoryName)
        {
            this.categoryName = categoryName;
            className = clas.ToString();
        }

        public TagFieldAttribute(string categoryName)
        {
            this.categoryName = categoryName;
        }

        public TagFieldAttribute(Type clas)
        {
            className = clas.ToString();
        }

        public TagFieldAttribute() { }
	}
}