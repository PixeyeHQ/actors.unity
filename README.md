<p align="center">
    <img src="http://raw.pixeye.games/logo_framework.png" alt="Actors">
</p>
<p align="center">
    
[![Join the chat at https://gitter.im/ActorsFramework/Lobby](https://img.shields.io/badge/gitter-join%20chat-green.svg?style=flat-square)](https://gitter.im/ActorsFramework/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Twitter Follow](https://img.shields.io/badge/twitter-%40dimmPixeye-blue.svg?style=flat-square&label=Follow)](https://twitter.com/dimmPixeye)
[![license](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://github.com/dimmpixeyeUnity-Framework/master/LICENSE)
</p>

Actors - The component based pattern for Unity3d
================================================================
ACTORS  is a small framework explicitly built for Unit3d. It is used to ease the pain of decoupling data from behaviors without tons of boilerplate code. 

### Installation
From Source
* Clone this repo and open it as a new Unity3D project.

### Project Overview
The project consists of several folders :
* [-]Common : for in-house libraries, framework plugables.
* [0]Framework : the framework code. You generally don't need to touch here anything.
* [1]Source : the game code.
* [2]Content : the game content such as scenes, graphics, audio and so on.
* [3]ThirdParty : libraries you use from asset store.
* Plugins : unity3d plugin folder.

### Project Setup
The framework heavily rely on Unity3D additive scenes. To use it in the way it was designed you need to make some preparations.

1. Open sceneKernel scene. You can find it in Assets/[2]Content/Scenes
It has one transform in the view called [KERNEL] - this is the root object of all your game. For convenience, I've attached the camera to it ( but you don't have to if you don't want ) 

2. Look on StarterKernel script attached to [KERNEL]. By starters, I call scripts that initialize your game, libraries, and scenes. 

StarterKernel has few public variables you can set up: 
* ScriptableObject Blueprints: a blueprint is a container for all game blueprints. I call customizable game-data scriptable object as "blueprint. 
* ScriptableObject DataGameSettings: use this to add some game settings related stuff.
* ScriptableObject DataGameSessiom : in-game session blackboard. Customize it as you need. 
* Pluggable: a list of all used pluggables. Plugable is a wrapper for a custom third-party asset you want to link with game and framework and initialize from the start. By default, you have a pluggable called PlugableConsole that add debug game console in the project.

[![https://gyazo.com/1e79f2d6bf54c3762f35eab153cb0bfe](https://i.gyazo.com/1e79f2d6bf54c3762f35eab153cb0bfe.png)](https://gyazo.com/1e79f2d6bf54c3762f35eab153cb0bfe)

### Scenes Setup

Add new scenes in game from File->New Scene command. You will notice that scene will be generated differently from normal unity3d scene setup. A scene doesn't have camera or light. It's because you add them additively from other scenes. ( sceneKernel by default )

#### Scene overview 
All scenes have essential objects that you don't want to change.
* [SETUP]: this is a root object for starter scripts and any settings related objects.
* [SCENE]: this is a root object for your game-related game objects in a scene. Put all your level here.
* [SCENE]/Dynamic: this is an object to hold all game objects that will be created at runtime. It's essential to separate loaded stuff from static to ease the process of debugging in hierarchy view.

#### Starters
A starter is a monobehavior component that you attach to [SETUP] game object. Starter controls scene loading&setup. You can inherit from starter component to extend it and add your custom logic. For example "startLevelOne."

Starter variables :
* Factories: by a factory, I call scriptable object that handles of creating complex objects. (For example factory player - spawn player object + spawn and setup player UI bars: hp, attack and so on.)
* Scenes to keep: add string names of views you want to save after this scene close. Usually, you would always want to save sceneKernel.
* Scenes depend on: scenes that need to be added when this scene starts. Typically, you would always want to depend on sceneKernel.


[![https://gyazo.com/1285f0b0feb8ecb0495ca536aae25606](https://i.gyazo.com/1285f0b0feb8ecb0495ca536aae25606.png)](https://gyazo.com/1285f0b0feb8ecb0495ca536aae25606)


### Creating new objects
So from this point we are ready to go and add new gameobjects. 

#### Monocached
Instead of using Monobehaviors it's recommended to use Monocached classes.
You can customize destroy time and pool type for your object. If pool is set the object will be deactivated and cached. If pool is set to none the object will be destroyed. Pooling is a great concenpt for objects that instantiate constantly. Bullets for example.

#### Actors
Base class for your game actors. Inherit from Monocached. It's basically a container for your data and behaviors. When you want to add new game entity inherit from Actor. For Example: ActorPlayer : Actor. 
Actor is the *ONLY* game-logic monobehavior you will need on the game object.

##### Actor setup example

```csharp
// inherit from Actor. Inherit from ITick interface to mark that this object must be updated.
  public class ActorPlayer : Actor, ITick
{
    // add serializable data classes to ActorPlayer so we can inspect them in the Inspector
    // Use [FoldoutGroup("Setup")] to make nice foldable groups of variables in the inspector
	[FoldoutGroup("Setup")] public DataMove dataMove;
	
        // Use protected override void Setup to initialize Actor.
        // Setup is used to add data into Actor's container and create behavior scripts for an Actor.
    	protected override void Setup()
		{
            // use Add(object) to add already created object into Actor's container. For example data.
			Add(dataMove);
            // use Add<T>() to create new object and add into Actor's container. For example behavior.
			Add<BehaviorInput>();
		}
 
}
```
[![https://gyazo.com/f3960af1f36566e3d114d97af9e3f0b6](https://i.gyazo.com/f3960af1f36566e3d114d97af9e3f0b6.png)](https://gyazo.com/f3960af1f36566e3d114d97af9e3f0b6)

#### Data component
Data components are serializable, plain c# classes inherited from IData interface. All game variables are held in data components.
The same data components may be shared through various of behaviors.


##### Data setup example

```csharp
// Always put [System.Serializable] to all data components and be sure to inherit from IData
	[System.Serializable]
    // Inhe
	public class DataMove : IData
	{
		public float x;
		public float y;

		public void Dispose()
		{
		}
	}
```

##### ISetup interface
If you need to make setup in data components use ISetup interface for that. It will allow getting current Actor in the Setup method of your data for further customizations. 
```csharp

	[System.Serializable]
	public class DataMove : IData, ISetup
	{
		public float x;
		public float y;

		public void Dispose()
		{
		}

		public void Setup(Actor actor)
		{
			x = actor.selfTransform.position.x;
		}
	}
 ```
 
#### Behavior component
Behaviors are plain c# classes that need data components to work and can't live without actors. Behaviors are workhorses of actors and define how actor behaves.

##### Behavior example

```csharp

// Inherit from ITick to mark this behavior for updates
		public class BehaviorInput : Behavior, ITick
	{
        // use [Bind] attribute for lazy initialization from Actor
		[Bind] private DataMove dataMove;

        // Update analogue, populating dataMove variables.
		public override void OnTick()
		{
			dataMove.x = Input.GetAxis("Horizontal");
			dataMove.y = Input.GetAxis("Vertical");
		}
	}
 ```



