//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 9/9/2018

#if!ODIN_INSPECTOR

using UnityEngine;


namespace Homebrew{
public class InfoBoxAttribute : PropertyAttribute {
    public string description;
    public InfoMessageType messageType;
 
  
    public InfoBoxAttribute(string description, InfoMessageType messageType = InfoMessageType.Info)
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