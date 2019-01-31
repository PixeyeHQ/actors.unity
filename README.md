<p align="center">
    <img src="http://raw.pixeye.games/logo_framework.png" alt="Actors">
</p>

[![Join the chat at https://gitter.im/ActorsFramework/Lobby](https://img.shields.io/badge/gitter-join%20chat-green.svg?style=flat-square)](https://gitter.im/ActorsFramework/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Join the chat at https://discord.gg/ukhzx83](https://img.shields.io/badge/discord-join%20channel-brightgreen.svg?style=flat-square)](https://discord.gg/ukhzx83)
[![Twitter Follow](https://img.shields.io/badge/twitter-%40dimmPixeye-blue.svg?style=flat-square&label=Follow)](https://twitter.com/dimmPixeye)
[![license](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://github.com/dimmpixeye/Actors-Unity3d-Framework/blob/master/LICENSE)

## Translation
* [EN](https://github.com/dimmpixeye/Actors-Unity3d-Framework/blob/Actor2.0/README.md)
* [WIKI](https://github.com/dimmpixeye/Actors-Unity3d-Framework/wiki)

# What is ACTORS? 
ACTORS is a complete game framework with multiscene editing, game object pooling and ECS ( entity-component-system ) data-driven approach for game logic explicitly built for Unity3d. 

It is used to ease the pain of decoupling data from behaviors without tons of boilerplate code and without unnecessary overhead.

### Game code overivew :

Components are serializable, plain c# classes inherited from IComponent interface. All game variables are held in components.
```csharp
using UnityEngine;
namespace Homebrew
{
    [System.Serializable]
    public class ComponentInputExample : IComponent
    {
        public KeyCode Up;
        public KeyCode Right;
        public KeyCode Down;
        public KeyCode Left;
    }

	public static class ExtensionComponentInputExample
	{
		public static ComponentInputExample ComponentInputExample(this int entity) { return Storage<ComponentInputExample>.Instance.components[entity]; }

		public static bool HasComponentInputExample(this int entity) { return Storage<ComponentInputExample>.Instance.HasComponent(entity); }
	}

}
```
An actor is a body for an entity. The entity itself is just an incremental number. Use actors when you want to compose your entities from the inspector and want to have strong link with monobehavior.

```csharp
  public class ActorExample : Actor
    {
        [FoldoutGroup("Setup")] public ComponentInputExample componentInputExample;

        protected override void Setup()
        {
            Add(componentInputExample);   
        }
    }
```
Processings are either systems or some "global" game controllers. 
Usually, you would add them to the toolbox from starter scripts.

```csharp
using UnityEngine;
namespace Homebrew
{
    public class ProcessingExampleInput : ProcessingBase, ITick
    {
        // A group is a container of all entities that have certain components.
        public Group<ComponentInputExample, ComponentObject> groupInput;

        public void Tick()
        {
            // loop through group of actors
            foreach(var entity in groupInput)
            {
                // get component from group.
                var cInputExample = entity.ComponentInputExample();
                var cObject = entity.ComponentObject();
                
                
                if (Input.GetKeyDown(cInputExample.Up))
                    Debug.Log(cObject.obj + " UP!" );
                 
                if (Input.GetKeyDown(cInputExample.Down))
                    Debug.Log(cObject.obj + " DOWN!" );
                 
                if (Input.GetKeyDown(cInputExample.Right))
                    Debug.Log(cObject.obj + " RIGHT!" );
                 
                if (Input.GetKeyDown(cInputExample.Left))
                    Debug.Log(cObject.obj + " LEFT!" );
            }
        }
    }
}
```

Starters are classes that initialize scene and can be used to add all processing you would need on the level. Developers control what scenes to load from starter scripts. Using add method in starter class is equal to Toolbox.Add<T>();
 
```csharp
public class StarterLevel1 : Starter
{
    protected override void Setup()
    {
        Add<ProcessingExampleInput>();
    }

}
```
Note that you always need to load kernel scene with starter in order to work correctly.
![Starter](https://i.gyazo.com/9f8964dad3333abbe57a9d3f35c3cc5e.png)


SceneKernel must be both in scenes to keep and in scenes depends on. Also don't forget to add scenes into the build settings. The order of scenes doesn't matter.

[![Image from Gyazo](https://i.gyazo.com/00c0b22d0a76651945711171cbad1372.png)](https://gyazo.com/00c0b22d0a76651945711171cbad1372)
