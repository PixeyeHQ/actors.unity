<p align="center">
    <img src="http://raw.pixeye.games/logo_framework.png" alt="Actors">
</p>

[![Join the chat at https://gitter.im/ActorsFramework/Lobby](https://img.shields.io/badge/gitter-join%20chat-green.svg?style=flat-square)](https://gitter.im/ActorsFramework/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Join the chat at https://discord.gg/ukhzx83](https://img.shields.io/badge/discord-join%20channel-brightgreen.svg?style=flat-square)](https://discord.gg/ukhzx83)
[![Twitter Follow](https://img.shields.io/badge/twitter-%40dimmPixeye-blue.svg?style=flat-square&label=Follow)](https://twitter.com/dimmPixeye)
[![license](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://github.com/dimmpixeye/Actors-Unity3d-Framework/blob/master/LICENSE)

## Translation
* [EN](https://github.com/dimmpixeye/Actors-Unity3d-Framework/blob/Actor2.0/README.md)
* [RU](https://github.com/dimmpixeye/Actors-Unity3d-Framework/blob/Actor2.0/README-ru.md)
* [Example project](https://github.com/dimmpixeye/Actors-example)

# What is ACTORS ? 
A complete game framework with multiscene editing, game object pooling and ECS ( entity-component-system ) data-driven approach for game logic explicitly built for Unity3d. It is used to ease the pain of decoupling data from behaviors without tons of boilerplate code. It relies on Unity3d scripting monobehavior concept but without unnecessary overhead.


### Game code overivew :

Data components are serializable, plain c# classes inherited from IData interface. All game variables are held in data components.
```csharp
using UnityEngine;
namespace Homebrew
{
    [System.Serializable]
    public class DataInputExample : IData
    {
        public KeyCode Up;
        public KeyCode Right;
        public KeyCode Down;
        public KeyCode Left;
    }
}
```
An actor is a body for an entity. The entity itself is just an incremental number. Use actors when you want to compose your entities from the inspector.

```csharp
  public class ActorExample : Actor
    {
        [FoldoutGroup("Setup")] public DataInputExample dataInputExample;

        protected override void Setup()
        {
            Add(dataInputExample);   
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
        public Group<DataInputExample> actors;

        public void Tick()
        {
            // loop through group of actors
            for (int i = 0; i < actors.length; i++)
            {
                // get data component from group.
                var data = actors.component[i];
                
                // If you need to get game object connected to the entity you can use.GetActor(group_index) method.
                if (Input.GetKeyDown(data.Up))
                    Debug.Log(actors.GetActor(i).gameObject + " UP!" );
                 
                if (Input.GetKeyDown(data.Down))
                    Debug.Log(actors.GetActor(i).gameObject + " DOWN!" );
                 
                if (Input.GetKeyDown(data.Right))
                    Debug.Log(actors.GetActor(i).gameObject + " RIGHT!" );
                 
                if (Input.GetKeyDown(data.Left))
                    Debug.Log(actors.GetActor(i).gameObject + " LEFT!" );
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
 
