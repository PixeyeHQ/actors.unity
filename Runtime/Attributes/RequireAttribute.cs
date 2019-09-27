//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 10/23/2018

using System;

namespace Pixeye.Actors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false)]
    [System.Runtime.InteropServices.ComVisible(true)]
    public class RequireAttribute : Attribute
    {
        public Type[] types;

        public RequireAttribute(params Type[] types)
        {
            this.types = types;
        }
    }
 
}