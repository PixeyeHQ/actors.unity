//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 10/13/2018

using System;


namespace Pixeye.Actors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false)]
    [System.Runtime.InteropServices.ComVisible(true)]
    public class RequireTagsAttribute : Attribute
    {
        public int[] tags;

        public RequireTagsAttribute(params int[] tags)
        {
            this.tags = tags;
        }
    }
}
 