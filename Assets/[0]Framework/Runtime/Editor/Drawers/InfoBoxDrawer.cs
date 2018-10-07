//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 9/9/2018
#if!ODIN_INSPECTOR

using UnityEditor;
using UnityEngine;

namespace Homebrew
{
    [CustomPropertyDrawer(typeof(InfoBoxAttribute))]
    public class InfoBoxDrawer : DecoratorDrawer
    {
        InfoBoxAttribute infoBox => ((InfoBoxAttribute) attribute);

        public override float GetHeight()
        {
            return base.GetHeight() +32;
        }
        
      

        public override void OnGUI(Rect position)
        {
            var v = position.max;
            v.y = position.max.y - 10;
            position.max = v;
            EditorGUI.HelpBox(position, infoBox.description, (MessageType) (int) infoBox.messageType);
        }
    }
}
#endif