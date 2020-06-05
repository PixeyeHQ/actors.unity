//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games
 
#if!ODIN_INSPECTOR
using UnityEditor;
using UnityEngine;

namespace Pixeye.Actors
{
    [CustomPropertyDrawer(typeof(InfoBoxAttribute))]
    public class DrawerInfoBox : DecoratorDrawer
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