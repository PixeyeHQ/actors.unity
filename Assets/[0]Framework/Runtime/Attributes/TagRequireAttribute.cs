//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 10/13/2018

using System;


namespace Homebrew
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false)]
    [System.Runtime.InteropServices.ComVisible(true)]
    public class TagRequireAttribute : Attribute
    {
        public int[] tags;

        public TagRequireAttribute(params int[] tags)
        {
            this.tags = tags;
        }
    }
}
 