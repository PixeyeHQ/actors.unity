//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 9/9/2018

#if!ODIN_INSPECTOR

using UnityEngine;


namespace Pixeye.Actors{
public class InfoBoxAttribute : PropertyAttribute {
    public string description;
    public InfoMessageType messageType;
 
    /// <summary>Adds the property to the specified foldout group.</summary>
    /// <param name="name">Name of the foldout group.</param>
    /// <param name="foldEverything">Toggle to put all properties to the specified group</param>
	
    public InfoBoxAttribute(string description, InfoMessageType messageType)
    {
        this.messageType = messageType;
        this.description = description;
    }
}

    public enum InfoMessageType
    {
        /// <summary>Generic message box with no type.</summary>
        None,
        /// <summary>Information message box.</summary>
        Info,
        /// <summary>Warning message box.</summary>
        Warning,
        /// <summary>Error message box.</summary>
        Error,
    }
    
}
#endif