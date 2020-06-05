/*MIT License

Copyright(c) 2017 Jeiel Aranal

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*/

// Uncomment the line below to turn all arrays into reorderable lists

//#define LIST_ALL_ARRAYS

// Uncomment the line below to make all ScriptableObject fields editable
//#define EDIT_ALL_SCRIPTABLES

#if !ODIN_INSPECTOR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditorInternal;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Pixeye.Actors
{
  [CustomEditor(typeof(Object), true, isFallback = true)]
  [CanEditMultipleObjects]
  public class InspectorReordarable : Editor
  {
    // Set this to true to turn every array in non custom inspectors into reorderable lists
    const bool LIST_ALL_ARRAYS = false;

    protected static string GetGrandParentPath(SerializedProperty property)
    {
      var parent   = property.propertyPath;
      var firstDot = property.propertyPath.IndexOf('.');
      if (firstDot > 0)
      {
        parent = property.propertyPath.Substring(0, firstDot);
      }

      return parent;
    }

    protected static bool FORCE_INIT;

    [DidReloadScripts]
    static void HandleScriptReload()
    {
      FORCE_INIT = true;

      EditorApplication.delayCall = () => { EditorApplication.delayCall = () => { FORCE_INIT = false; }; };
    }

    /// <summary>
    /// Internal class that manages ReorderableLists for each reorderable
    /// SerializedProperty in a SerializedObject's direct child
    /// </summary>
    protected class SortableListData
    {
      public string Parent { get; }
      public Func<int, string> ElementHeaderCallback;

      readonly Dictionary<string, ReorderableList> propIndex = new Dictionary<string, ReorderableList>();
      readonly Dictionary<string, Action<SerializedProperty, Object[]>> propDropHandlers = new Dictionary<string, Action<SerializedProperty, Object[]>>();
      readonly Dictionary<string, int> countIndex = new Dictionary<string, int>();

      public SortableListData(string parent)
      {
        Parent = parent;
      }

      public void AddProperty(SerializedProperty property)
      {
        // Check if this property actually belongs to the same direct child
        if (GetGrandParentPath(property).Equals(Parent) == false)
          return;

        var propList = new ReorderableList(property.serializedObject, property, true, false, true, true)
        {
          headerHeight = 5
        };

        propList.drawElementCallback = delegate(Rect rect, int index, bool active, bool focused)
        {
          var targetElement = property.GetArrayElementAtIndex(index);
          var isExpanded    = targetElement.isExpanded;
          rect.height = EditorGUI.GetPropertyHeight(targetElement, GUIContent.none, isExpanded);

          if (targetElement.hasVisibleChildren)
            rect.xMin += 10;

          // Get Unity to handle drawing each element
          var propHeader = new GUIContent(targetElement.displayName);
          if (ElementHeaderCallback != null)
            propHeader.text = ElementHeaderCallback(index);
          EditorGUI.PropertyField(rect, targetElement, propHeader, isExpanded);

          // If drawing the selected element, use it to set the element height
          // Element height seems to control selected background
#if UNITY_5_1 || UNITY_5_2
					if (index == propList.index)
					{	
						// Height might have changed when dealing with serialized class
						// Call the select callback when height changes to reset the list elementHeight
						float newHeight = EditorGUI.GetPropertyHeight(targetElement, GUIContent.none, targetElement.isExpanded);
						if (rect.height != newHeight)
							propList.elementHeight = Mathf.Max(propList.elementHeight, newHeight);
					}
#endif
        };

        // Unity 5.3 onwards allows reorderable lists to have variable element heights
#if UNITY_5_3_OR_NEWER
        propList.elementHeightCallback = index => ElementHeightCallback(property, index);

        propList.drawElementBackgroundCallback = (rect, index, active, focused) =>
        {
          //	if (styleHighlight == null)
          //	styleHighlight = EditorUIStyles.box;//GUI.skin.FindStyle("MeTransitionSelectHead");
          if (focused == false)
          {
            //	GUI.Box(rect, GUIContent.none, styleHighlight);
            return;
          }

          rect.height = ElementHeightCallback(property, index);
          GUI.Box(rect, GUIContent.none, StyleFramework.box);
        };
#endif
        propIndex.Add(property.propertyPath, propList);
      }

      private float ElementHeightCallback(SerializedProperty property, int index)
      {
        var arrayElement     = property.GetArrayElementAtIndex(index);
        var calculatedHeight = EditorGUI.GetPropertyHeight(arrayElement, GUIContent.none, arrayElement.isExpanded);
        calculatedHeight += 3;
        return calculatedHeight;
      }

      public bool DoLayoutProperty(SerializedProperty property)
      {
        if (propIndex.ContainsKey(property.propertyPath) == false)
          return false;

        // Draw the header
        var headerText = $"{property.displayName} [{property.arraySize}]";
        EditorGUILayout.PropertyField(property, new GUIContent(headerText), false);

        // Save header rect for handling drag and drop
        var dropRect = GUILayoutUtility.GetLastRect();

        // Draw the reorderable list for the property
        if (property.isExpanded)
        {
          //	GUI.Box(rect, GUIContent.none, styleHighlight);
          var newArraySize = EditorGUILayout.IntField("Size", property.arraySize);
          if (newArraySize != property.arraySize)
            property.arraySize = newArraySize;

          propIndex[property.propertyPath].DoLayoutList();
          //propIndex[property.propertyPath].DoLayoutList();
        }

        // Handle drag and drop into the header
        var evt = Event.current;
        if (evt == null)
          return true;

        if (evt.type == EventType.DragUpdated || evt.type == EventType.DragPerform)
        {
          if (dropRect.Contains(evt.mousePosition) == false)
            return true;

          DragAndDrop.visualMode = DragAndDropVisualMode.Copy;
          if (evt.type == EventType.DragPerform)
          {
            DragAndDrop.AcceptDrag();
            if (propDropHandlers.TryGetValue(property.propertyPath, out var handler))
            {
              if (handler != null)
                handler(property, DragAndDrop.objectReferences);
            }
            else
            {
              foreach (var dragged_object in DragAndDrop.objectReferences)
              {
                if (dragged_object.GetType() != property.GetType())
                  continue;

                var newIndex = property.arraySize;
                property.arraySize++;

                var target = property.GetArrayElementAtIndex(newIndex);
                target.objectReferenceInstanceIDValue = dragged_object.GetInstanceID();
              }
            }

            evt.Use();
          }
        }

        return true;
      }

      public int GetElementCount(SerializedProperty property)
      {
        if (property.arraySize <= 0)
          return 0;

        if (countIndex.TryGetValue(property.propertyPath, out var count))
          return count;

        var element      = property.GetArrayElementAtIndex(0);
        var countElement = element.Copy();
        var childCount   = 0;
        if (countElement.NextVisible(true))
        {
          var depth = countElement.Copy().depth;
          do
          {
            if (countElement.depth != depth)
              break;
            childCount++;
          } while (countElement.NextVisible(false));
        }

        countIndex.Add(property.propertyPath, childCount);
        return childCount;
      }

      public ReorderableList GetPropertyList(SerializedProperty property)
      {
        if (propIndex.ContainsKey(property.propertyPath))
          return propIndex[property.propertyPath];
        return null;
      }

      public void SetDropHandler(SerializedProperty property, Action<SerializedProperty, Object[]> handler)
      {
        var path = property.propertyPath;
        if (propDropHandlers.ContainsKey(path))
          propDropHandlers[path] = handler;
        else
          propDropHandlers.Add(path, handler);
      }
    } // End SortableListData

    public bool isSubEditor;

    readonly GUILayoutOption uiExpandWidth = GUILayout.ExpandWidth(true);
    readonly GUILayoutOption uiWidth50 = GUILayout.Width(50);
    readonly GUIContent labelBtnCreate = new GUIContent("Create");

    readonly List<SortableListData> listIndex = new List<SortableListData>();
    readonly Dictionary<string, Editor> editableIndex = new Dictionary<string, Editor>();

    protected bool alwaysDrawInspector = false;
    protected bool isInitialized = false;
    protected bool hasSortableArrays = false;
    protected bool hasEditable = false;

    protected struct ContextMenuData
    {
      public string menuItem;
      public MethodInfo function;
      public MethodInfo validate;

      public ContextMenuData(string item)
      {
        menuItem = item;
        function = null;
        validate = null;
      }
    }

    protected Dictionary<string, ContextMenuData> contextData = new Dictionary<string, ContextMenuData>();

    ~InspectorReordarable()
    {
      listIndex.Clear();
      //hasSortableArrays = false;
      editableIndex.Clear();
      //hasEditable = false;
      isInitialized = false;
    }

    #region Initialization

    protected virtual void InitInspector(bool force)
    {
      if (force)
        isInitialized = false;
      InitInspector();
    }

    protected virtual void InitInspector()
    {
      if (isInitialized && FORCE_INIT == false)
        return;

      //		styleEditBox = EditorUIStyles.foldout;//new GUIStyle(EditorStyles.helpBox) {padding = new RectOffset(5, 5, 5, 5)};
      FindTargetProperties();
      FindContextMenu();
    }

    protected void FindTargetProperties()
    {
      listIndex.Clear();
      editableIndex.Clear();
      var typeScriptable = typeof(ScriptableObject);

      var iterProp = serializedObject.GetIterator();
      // This iterator goes through all the child serialized properties, looking
      // for properties that have the SortableArray attribute
      if (iterProp.NextVisible(true))
      {
        do
        {
          if (iterProp.isArray && iterProp.propertyType != SerializedPropertyType.String)
          {
#if LIST_ALL_ARRAYS
            var canTurnToList = true;
#else
            var canTurnToList = iterProp.HasAttribute<ReorderableAttribute>();
#endif
            if (canTurnToList)
            {
              hasSortableArrays = true;
              CreateListData(serializedObject.FindProperty(iterProp.propertyPath));
            }
          }
        } while (iterProp.NextVisible(true));
      }

      isInitialized = true;
      if (hasSortableArrays == false)
      {
        listIndex.Clear();
      }
    }

    private IEnumerable<MethodInfo> GetAllMethods(Type t)
    {
      if (t == null)
        return Enumerable.Empty<MethodInfo>();
      var binding = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
      return t.GetMethods(binding).Concat(GetAllMethods(t.BaseType));
    }

    private void FindContextMenu()
    {
      contextData.Clear();

      // Get context menu
      var targetType      = target.GetType();
      var contextMenuType = typeof(ContextMenu);
      var methods         = GetAllMethods(targetType).ToArray();
      for (var index = 0; index < methods.GetLength(0); ++index)
      {
        var methodInfo = methods[index];
        foreach (ContextMenu contextMenu in methodInfo.GetCustomAttributes(contextMenuType, false))
        {
          if (contextData.ContainsKey(contextMenu.menuItem))
          {
            var data = contextData[contextMenu.menuItem];
            if (contextMenu.validate)
              data.validate = methodInfo;
            else
              data.function = methodInfo;
            contextData[data.menuItem] = data;
          }
          else
          {
            var data = new ContextMenuData(contextMenu.menuItem);
            if (contextMenu.validate)
              data.validate = methodInfo;
            else
              data.function = methodInfo;
            contextData.Add(data.menuItem, data);
          }
        }
      }
    }

    private void CreateListData(SerializedProperty property)
    {
      var parent = GetGrandParentPath(property);

      // Try to find the grand parent in SortableListData
      var data = listIndex.Find(listData => listData.Parent.Equals(parent));
      if (data == null)
      {
        data = new SortableListData(parent);
        listIndex.Add(data);
      }

      data.AddProperty(property);
      var attr = property.GetAttributes<ReorderableAttribute>();
      if (attr != null && attr.Length == 1)
      {
        var arrayAttr = (ReorderableAttribute) attr[0];
        if (arrayAttr != null)
        {
          HandleReorderableOptions(arrayAttr, property, data);
        }
      }
    }

    private void HandleReorderableOptions(ReorderableAttribute arrayAttr, SerializedProperty property, SortableListData data)
    {
      // Custom element header
      if (string.IsNullOrEmpty(arrayAttr.ElementHeader) == false)
      {
        data.ElementHeaderCallback = i => $"{arrayAttr.ElementHeader} {(arrayAttr.HeaderZeroIndex ? i : i + 1)}";
      }

      // Draw property as single line
      if (arrayAttr.ElementSingleLine)
      {
        var list = data.GetPropertyList(property);
#if UNITY_5_3_OR_NEWER
        list.elementHeightCallback = index => EditorGUIUtility.singleLineHeight + 6;
        list.drawElementBackgroundCallback = (rect, index, active, focused) =>
        {
          if (focused == false)
            return;

          GUI.Box(rect, GUIContent.none, StyleFramework.box);
        };
#endif

        list.drawElementCallback = (rect, index, active, focused) =>
        {
          var element = property.GetArrayElementAtIndex(index);
          element.isExpanded = false;

          var childCount = data.GetElementCount(property);
          if (childCount < 1)
            return;

          rect.y      += 3;
          rect.height -= 6;

          var restoreWidth = EditorGUIUtility.labelWidth;
          if (element.NextVisible(true))
          {
            EditorGUIUtility.labelWidth /= childCount;

            var padding = 5f;
            var width   = rect.width - padding * (childCount - 1);
            width /= childCount;

            var childRect = new Rect(rect) {width = width};
            var depth     = element.Copy().depth;
            do
            {
              if (element.depth != depth)
                break;

              if (childCount <= 2)
                EditorGUI.PropertyField(childRect, element, false);
              else
                EditorGUI.PropertyField(childRect, element, GUIContent.none, false);
              childRect.x += width + padding;
            } while (element.NextVisible(false));

            EditorGUIUtility.labelWidth = restoreWidth;
          }
        };
      }
    }

    /// <summary>
    /// Given a SerializedProperty, return the automatic ReorderableList assigned to it if any
    /// </summary>
    /// <param name="property"></param>
    /// <returns></returns>
    protected ReorderableList GetSortableList(SerializedProperty property)
    {
      if (listIndex.Count == 0)
        return null;

      var parent = GetGrandParentPath(property);

      var data = listIndex.Find(listData => listData.Parent.Equals(parent));
      if (data == null)
        return null;

      return data.GetPropertyList(property);
    }

    /// <summary>
    /// Set a drag and drop handler function on a SerializedObject's ReorderableList, if any
    /// </summary>
    /// <param name="property"></param>
    /// <param name="handler"></param>
    /// <returns></returns>
    protected bool SetDragDropHandler(SerializedProperty property, Action<SerializedProperty, Object[]> handler)
    {
      if (listIndex.Count == 0)
        return false;

      var parent = GetGrandParentPath(property);
      var data   = listIndex.Find(listData => listData.Parent.Equals(parent));
      if (data == null)
        return false;

      data.SetDropHandler(property, handler);
      return true;
    }

    #endregion

    protected bool InspectorGUIStart(bool force = false)
    {
      // Not initialized, try initializing
      if (hasSortableArrays && listIndex.Count == 0)
        InitInspector();
      if (hasEditable && editableIndex.Count == 0)
        InitInspector();

      // No sortable arrays or list index unintialized
      var cannotDrawOrderable = (hasSortableArrays == false || listIndex.Count == 0);
      var cannotDrawEditable  = (hasEditable == false || editableIndex.Count == 0);
      if (cannotDrawOrderable && cannotDrawEditable && force == false)
      {
        if (isSubEditor)
          DrawPropertiesExcluding(serializedObject, "m_Script");
        else
          base.OnInspectorGUI();

        //	DrawContextMenuButtons();
        return false;
      }

      serializedObject.Update();
      return true;
    }

    protected virtual void DrawInspector()
    {
      DrawPropertiesAll();
    }

    public override void OnInspectorGUI()
    {
      if (InspectorGUIStart(alwaysDrawInspector) == false)
        return;

      EditorGUI.BeginChangeCheck();

      DrawInspector();

      if (EditorGUI.EndChangeCheck())
      {
        serializedObject.ApplyModifiedProperties();
        InitInspector(true);
      }

      //	DrawContextMenuButtons();
    }

    protected enum IterControl
    {
      Draw,
      Continue,
      Break
    }

    protected void IterateDrawProperty(SerializedProperty property, Func<IterControl> filter = null)
    {
      if (property.NextVisible(true))
      {
        // Remember depth iteration started from
        var depth = property.Copy().depth;
        do
        {
          // If goes deeper than the iteration depth, get out
          if (property.depth != depth)
            break;
          if (isSubEditor && property.name.Equals("m_Script"))
            continue;

          if (filter != null)
          {
            var filterResult = filter();
            if (filterResult == IterControl.Break)
              break;
            if (filterResult == IterControl.Continue)
              continue;
          }

          DrawPropertySortableArray(property);
        } while (property.NextVisible(false));
      }
    }

    /// <summary>
    /// Draw a SerializedProperty as a ReorderableList if it was found during
    /// initialization, otherwise use EditorGUILayout.PropertyField
    /// </summary>
    /// <param name="property"></param>
    protected void DrawPropertySortableArray(SerializedProperty property)
    {
      // Try to get the sortable list this property belongs to
      SortableListData listData = null;
      if (listIndex.Count > 0)
        listData = listIndex.Find(data => property.propertyPath.StartsWith(data.Parent));

      var isScriptableEditor = editableIndex.TryGetValue(property.propertyPath, out var scriptableEditor);

      // Has ReorderableList
      if (listData != null)
      {
        // Try to show the list
        if (listData.DoLayoutProperty(property) == false)
        {
          EditorGUILayout.PropertyField(property, false);
          if (property.isExpanded)
          {
            EditorGUI.indentLevel++;
            var targetProp = serializedObject.FindProperty(property.propertyPath);
            IterateDrawProperty(targetProp);
            EditorGUI.indentLevel--;
          }
        }
      }
      // Else try to draw ScriptableObject editor
      else if (isScriptableEditor)
      {
        var hasHeader = property.HasAttribute<HeaderAttribute>();
        var hasSpace  = property.HasAttribute<SpaceAttribute>();

        float foldoutSpace = hasHeader ? 24 : 7;
        if (hasHeader && hasSpace)
          foldoutSpace = 31;

        hasSpace |= hasHeader;

        // No data in property, draw property field with create button
        if (scriptableEditor == null)
        {
          bool doCreate;
          using (new EditorGUILayout.HorizontalScope())
          {
            EditorGUILayout.PropertyField(property, uiExpandWidth);
            using (new EditorGUILayout.VerticalScope(uiWidth50))
            {
              if (hasSpace) GUILayout.Space(10);
              doCreate = GUILayout.Button(labelBtnCreate, EditorStyles.miniButton);
            }
          }

          if (doCreate)
          {
            var propType     = property.GetTypeReflection();
            var createdAsset = CreateAssetWithSavePrompt(propType, "Assets");
            if (createdAsset != null)
            {
              property.objectReferenceValue = createdAsset;
              property.isExpanded           = true;
            }
          }
        }
        // Has data in property, draw foldout and editor
        else
        {
          EditorGUILayout.PropertyField(property);
          var rectFoldout = GUILayoutUtility.GetLastRect();
          rectFoldout.width = 20;
          if (hasSpace) rectFoldout.yMin += foldoutSpace;

          property.isExpanded = EditorGUI.Foldout(rectFoldout, property.isExpanded, GUIContent.none);

          if (property.isExpanded)
          {
            EditorGUI.indentLevel++;
            using (new EditorGUILayout.VerticalScope(StyleFramework.box))
            {
              var restoreIndent = EditorGUI.indentLevel;
              EditorGUI.indentLevel = 1;
              scriptableEditor.serializedObject.Update();
              scriptableEditor.OnInspectorGUI();
              scriptableEditor.serializedObject.ApplyModifiedProperties();
              EditorGUI.indentLevel = restoreIndent;
            }

            EditorGUI.indentLevel--;
          }
        }
      }
      else
      {
        var targetProp  = serializedObject.FindProperty(property.propertyPath);
        var isStartProp = targetProp.propertyPath.StartsWith("m_");
        using (new EditorGUI.DisabledScope(isStartProp))
        {
          EditorGUILayout.PropertyField(targetProp, targetProp.isExpanded);
        }
      }
    }

    // Creates a new ScriptableObject via the default Save File panel
    private ScriptableObject CreateAssetWithSavePrompt(Type type, string path)
    {
      path = EditorUtility.SaveFilePanelInProject("Save ScriptableObject", "New " + type.Name + ".asset", "asset", "Enter a file name for the ScriptableObject.", path);
      if (path == "") return null;
      var asset = ScriptableObject.CreateInstance(type);
      AssetDatabase.CreateAsset(asset, path);
      AssetDatabase.SaveAssets();
      AssetDatabase.Refresh();
      AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
      EditorGUIUtility.PingObject(asset);
      return asset;
    }

    #region Helper functions

    /// <summary>
    /// Draw the default inspector, with the sortable arrays
    /// </summary>
    public void DrawPropertiesAll()
    {
      var iterProp = serializedObject.GetIterator();
      IterateDrawProperty(iterProp);
    }

    /// <summary>
    /// Draw the default inspector, except for the given property names
    /// </summary>
    /// <param name="propertyNames"></param>
    public void DrawPropertiesExcept(params string[] propertyNames)
    {
      var iterProp = serializedObject.GetIterator();

      IterateDrawProperty(iterProp, filter: () =>
      {
        if (propertyNames.Contains(iterProp.name))
          return IterControl.Continue;
        return IterControl.Draw;
      });
    }

    /// <summary>
    /// Draw the default inspector, starting from a given property
    /// </summary>
    /// <param name="propertyStart">Property name to start from</param>
    public void DrawPropertiesFrom(string propertyStart)
    {
      var canDraw  = false;
      var iterProp = serializedObject.GetIterator();
      IterateDrawProperty(iterProp, filter: () =>
      {
        if (iterProp.name.Equals(propertyStart))
          canDraw = true;
        if (canDraw)
          return IterControl.Draw;
        return IterControl.Continue;
      });
    }

    /// <summary>
    /// Draw the default inspector, up to a given property
    /// </summary>
    /// <param name="propertyStop">Property name to stop at</param>
    public void DrawPropertiesUpTo(string propertyStop)
    {
      var iterProp = serializedObject.GetIterator();
      IterateDrawProperty(iterProp, filter: () =>
      {
        if (iterProp.name.Equals(propertyStop))
          return IterControl.Break;
        return IterControl.Draw;
      });
    }

    /// <summary>
    /// Draw the default inspector, starting from a given property to a stopping property
    /// </summary>
    /// <param name="propertyStart">Property name to start from</param>
    /// <param name="propertyStop">Property name to stop at</param>
    public void DrawPropertiesFromUpTo(string propertyStart, string propertyStop)
    {
      var canDraw  = false;
      var iterProp = serializedObject.GetIterator();
      IterateDrawProperty(iterProp, () =>
      {
        if (iterProp.name.Equals(propertyStop))
          return IterControl.Break;

        if (iterProp.name.Equals(propertyStart))
          canDraw = true;

        if (canDraw == false)
          return IterControl.Continue;

        return IterControl.Draw;
      });
    }

    #endregion
  }
}
#endif