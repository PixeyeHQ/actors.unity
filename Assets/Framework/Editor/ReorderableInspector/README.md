# Reorderable Inspector

Automatically turn arrays/lists into ReorderableLists in Unity inspectors. Inspired by [Alejandro Santiago's implementation](https://medium.com/developers-writing/how-about-having-nice-arrays-and-lists-in-unity3d-by-default-e4fba13d1b50).

![Sortable Array](./Docs/sortable-array.png)

This is an editor enhancement that gives you nicer inspector features without having to write additional code. Easily rearrange arrays, add buttons for utility functions, and and edit linked `ScriptableObjects` right in your GameObject's inspector.

## Installation

Download the UnityPackage from the [latest releases](https://github.com/ChemiKhazi/ReorderableInspector/releases) and import it into Unity. The directory can be moved after being imported.

## Usage

To draw an array as a `ReorderableList`, mark the property with the `Reorderable` attribute.

```C#
// Add this `using` statement to the top of your file
using SubjectNerd.Utilities;

public class ListReorderTest : MonoBehaviour
{  
	[Reorderable]
	public string[] stringArray; // This will be drawn with a ReorderableList

	public List<string> stringList; // This will be drawn as a default array
}
```

If you want to apply the reorderable list to all arrays, edit `ReorderableArrayInspector.cs` and uncomment the defines at the top of the file

## Additional Features

### `ContextMenu` buttons.

Quickly add buttons for utility functions to the inspector by using Unity's `ContextMenu` attribute

```C#
public class ContextMenuTest : MonoBehaviour
{
	public bool isTestEnabled;

	[ContextMenu("Test Function")]
	private void MyTestFunction()
	{
		Debug.Log("Test function fired");
	}

	[ContextMenu("Test Function", isValidateFunction:true)]
	private bool TestFunctionValidate()
	{
		return isTestEnabled;
	}

	[ContextMenu("Other Test")]
	private void NonValidatedTest()
	{
		Debug.Log("Non validated test fired");
	}
}
```

![Context Menu](./Docs/context-menu.png)

### Inline `ScriptableObject` editing

Edit settings stored in a `ScriptableObject` in the inspector with the `EditScriptable` attribute. A feature inspired by [Tom Kail's ExtendedScriptableObjectDrawer](https://heavens-vault-game.tumblr.com/post/162127808290/inline-scriptableobject-editing-in-unity)

```C#
public class SkinData : ScriptableObject
{
	public string id;
	public Sprite sprite;
}

public class TestEntity : MonoBehaviour
{
	public string entityName;
	
	// Add the `EditScriptable` attribute to edit the `ScriptableObject` in the GameObject inspector
	[EditScriptable]
	public SkinData skin;
}
```

## Limitations

- Only supports Unity 5 and above
- ReorderableLists of class instances may be a little rough, especially below Unity version 5.3
- Custom inspectors will not automatically gain the ability to turn arrays into reorderable lists. See next section.

## Custom inspectors

Custom inspectors will not automatically draw arrays as ReorderableLists unless they inherit from `ReorderableArrayInspector`.

This class contains helper functions that can handle default property drawing. Below is a template for a custom inspector.

Additional custom inspector functionality is [discussed in the wiki](https://github.com/ChemiKhazi/ReorderableInspector/wiki/Custom-Inspectors).

## Inspector Template
```C#
[CustomEditor(typeof(YourCustomClass))]
public class CustomSortableInspector : ReorderableArrayInspector
{
	// Called by OnEnable
	protected override void InitInspector()
	{
		base.InitInspector();
		
		// Always call DrawInspector function
		alwaysDrawInspector = true;
		
		// Do other initializations here
	}
	
	// Override this function to draw
	protected override void DrawInspector()
	{
		// Call the relevant default drawer functions here
		// The following functions will automatically draw properties
		// with ReorderableList when applicable
		/*
		// Draw all properties
		DrawPropertiesAll();

		// Like DrawPropertiesExcluding
		DrawPropertiesExcept("sprites");

		// Draw all properties, starting from specified property
		DrawPropertiesFrom("propertyName");

		// Draw all properties until before the specified property
		DrawPropertiesUpTo("endPropertyName");

		// Draw properties starting from startProperty, ends before endProperty
		DrawPropertiesFromUpTo("startProperty", "endProperty");
		*/
		
		// Write your custom inspector functions here
		EditorGUILayout.HelpBox("This is a custom inspector", MessageType.Info);
	}
}
```


## Buy me a coffee!

If this Unity enhancement is useful to you, it would be great if you could [buy me a coffee](https://ko-fi.com/subjectnerd)!
