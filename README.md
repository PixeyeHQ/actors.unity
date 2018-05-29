<p align="center">
    <img src="http://raw.pixeye.games/logo_framework.png" alt="Actors">
</p>

[![Join the chat at https://gitter.im/ActorsFramework/Lobby](https://img.shields.io/badge/gitter-join%20chat-green.svg?style=flat-square)](https://gitter.im/ActorsFramework/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Join the chat at https://discord.gg/ukhzx83](https://img.shields.io/badge/discord-join%20channel-brightgreen.svg?style=flat-square)](https://discord.gg/ukhzx83)
[![Twitter Follow](https://img.shields.io/badge/twitter-%40dimmPixeye-blue.svg?style=flat-square&label=Follow)](https://twitter.com/dimmPixeye)
[![license](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://github.com/dimmpixeyeUnity-Framework/master/LICENSE)

## Actors - The component based pattern for Unity3d

ACTORS  is a small framework explicitly built for Unit3d. It is used to ease the pain of decoupling data from behaviors without tons of boilerplate code. 

## Installation
From Source
* Clone this repo and open it as a new Unity3D project.

## Project Overview
The project consists of several folders :
* [-]Common : for in-house libraries, framework pluggables.
* [0]Framework : the framework code. You generally don't need to touch here anything.
* [1]Source : the game code.
* [2]Content : the game content such as scenes, graphics, audio and so on.
* [3]ThirdParty : libraries you use from asset store.
* Plugins : unity3d plugin folder.

## Project Setup
The framework heavily rely on Unity3D additive scenes. To use it in the way it was designed you need to make some preparations.

1. Open sceneKernel scene. You can find it in Assets/[2]Content/Scenes
It has one transform in the view called [KERNEL] - this is the root object of all your game. For convenience, I've attached the camera to it ( but you don't have to if you don't want ) 

2. Look on StarterKernel script attached to [KERNEL]. By starters, I call scripts that initialize your game, libraries, and scenes. 

StarterKernel has few public variables you can set up: 
* ScriptableObject Blueprints: a blueprint is a container for all game blueprints. I call customizable game-data scriptable object as "blueprint. 
* ScriptableObject DataGameSettings: use this to add some game settings related stuff.
* ScriptableObject DataGameSessiom : in-game session blackboard. Customize it as you need. 
* Pluggable: a list of all used pluggables. Pluggable is a wrapper for a custom third-party asset you want to link with game and framework and initialize from the start. By default, you have a pluggable called PlugableConsole that add debug game console in the project.

[![https://gyazo.com/1e79f2d6bf54c3762f35eab153cb0bfe](https://i.gyazo.com/1e79f2d6bf54c3762f35eab153cb0bfe.png)](https://gyazo.com/1e79f2d6bf54c3762f35eab153cb0bfe)

## Scenes Setup

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


## Creating new objects
So from this point we are ready to go and add new gameobjects. 

### Monocached
Instead of using Monobehaviors it's recommended to use Monocached classes.
You can customize destroy time and pool type for your object. If pool is set the object will be deactivated and cached. If pool is set to none the object will be destroyed. Pooling is a great concenpt for objects that instantiate constantly. Bullets for example.

### Actors
Base class for your game actors. Inherit from Monocached. It's basically a container for your data and behaviors. When you want to add new game entity inherit from Actor. For Example: ActorPlayer : Actor. 
Actor is the *ONLY* game-logic monobehavior you will need on the game object.

#### Actor setup example

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

You don't need to write any logic inside of actor classes. Use behavior classes instead. Normally your actor class should look like this:
```csharp
	public class ActorHero : Actor, ITickFixed, ITick, ITickLate
	{
		[FoldoutGroup("Setup"), SerializeField]
		private DataBlueprint dataBlueprint;
		[FoldoutGroup("Setup"), HideInInspector, SerializeField]
		private DataAnimationState dataAnimationState;
		[FoldoutGroup("Setup"), SerializeField]
		private DataInput dataInput;
		[FoldoutGroup("Setup"), SerializeField]
		private DataHealth dataHealth;
		[FoldoutGroup("Setup"), SerializeField]
		private DataDepthRender dataDepthRender;



		protected override void Setup()
		{
			Add(dataBlueprint);
			Add(dataAnimationState);
			Add(dataDepthRender);
			Add(dataHealth);
			Add(dataInput);
		
			Add<DecorateDamageReturn>();
			Add<DecorateBloodFloor>();
			Add<DecorateDamageBlink>();
			Add<DecorateBloodSplats>();

			Add<BehaviorTurn>();
			Add<BehaviorMove>();
			Add<BehaviorRoll>();
			
			Add<BehaviorPlayerInput>();
			Add<BehaviorDamageble>();

		}
	}
```

### Get method
When you are working with actors/behaviors use Get<T> instead of GetComponent<T>. Get<T> method tries to find component inside of actor
container.
Example:
	
```csharp
Get<DataMovement>().facing
```
You can get unity components as well by adding path to child transform
```csharp
labelScore = Get<TextMeshProUGUI>("anchor_left/label_score");
```

	 

## Data component
Data components are serializable, plain c# classes inherited from IData interface. All game variables are held in data components.
The same data components may be shared through various of behaviors.


### Data setup example

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

#### ISetup interface
Sometimes your data containers might need extra setup from code instead of Unity3d Inspector. In this case, use this interface for your
data components. When data component is added to an actor he will check all components for ISetup interface and trigger them.
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
 
## Behavior component
Behaviors are plain c# classes that need data components to work and can't live without actors. Behaviors are workhorses of actors and define how actor behaves.

### Behavior example

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

## **Signals**
Signals are in-memory publish/subscribe system and effectively replace Unity3d SendMessage.
There are two layers of signal disptachers : local is implemented inside Actor class. Global can be reached from ProcessingSignals.Default.

Steps to use signals :

1. Create a new structure. I prefer to call them like Singal*YourName*. The structure holds all your arguments you want to pass.
```csharp
public struct SignalCameraShake 
{
	public int strength;
}
```
2. Add an IReceive<T> to an object interested in receiving your signal. T is a type of your signal.
A method HandleSignal(T arg) will be added to your script. It's an entry point for your signal.
 
```csharp
  public class ProcessingShakeCamera : IDisposable, IMustBeWiped, IReceive<SignalCameraShake> 
  {
	public void HandleSignal(SignalCameraShake arg)
		{
			if (arg.strength == 0)
				tweenShakeAverage.Restart();
			else if (arg.strength == 1)
				tweenShakeStrong.Restart();
			else if (arg.strength == 2)
				tweenShakeVeryStrong.Restart();
		}
  }
```

3. Add subscription to your signal dispatcher.
```csharp
  public class ProcessingShakeCamera : IDisposable, IMustBeWiped, IReceive<SignalCameraShake> 
  {
	
	public ProcessingShakeCamera()
		{
		        // subscribe this object on global signal dispatcher.
			ProcessingSignals.Default.Add(this);
	        }
		
	public void HandleSignal(SignalCameraShake arg)
		{
			if (arg.strength == 0)
				tweenShakeAverage.Restart();
			else if (arg.strength == 1)
				tweenShakeStrong.Restart();
			else if (arg.strength == 2)
				tweenShakeVeryStrong.Restart();
		}
  }
```
 4. Provide unsubscribe logic
```csharp
  public class ProcessingShakeCamera : IDisposable, IMustBeWiped, IReceive<SignalCameraShake> 
  {
	
	public ProcessingShakeCamera()
		{
		        // subscribe this object on global signal dispatcher.
			ProcessingSignals.Default.Add(this);
	        }
		
	public void HandleSignal(SignalCameraShake arg)
		{
			if (arg.strength == 0)
				tweenShakeAverage.Restart();
			else if (arg.strength == 1)
				tweenShakeStrong.Restart();
			else if (arg.strength == 2)
				tweenShakeVeryStrong.Restart();
		}
		
		// We don't want object to recieve signals when it's destroyed.
			public void Dispose()
		{
		        // Unsubscribe 
			ProcessingSignals.Default.Remove(this);
		}
		
  }
 ``` 
  Please note that you don't need to implement subscribe/unsubscribe logic that when you inherit from behavior or actor class.
  Just add IReceive interfaces :
  ```csharp
  	public class DecorateDamageBlink : Behavior, IReceive<SignalDamage>
	{
	 
		public void HandleSignal(SignalDamage val)
		{
			Blink();
		}
	
	}
  
 ``` 


## **Interfaces overivew**
There are several interfaces in the framework to extend entity functionality.

### ITick
The framework use single monobehavior update for *ALL* entities. Because of that we don't use any Update methods in actors/behaviors. 
Instead we mark actors and behaviors with interfaces to define update type. Use ITick if you have code that needs to run per frame.

```csharp
public class BehaviorExample : Behavior, ITick{
    public override void OnTick() { }
}
```
### ITickFixed
Use it when you have code that needs to run every fixed framerate frame.

```csharp
public class BehaviorExample : Behavior, ITickFixed{
    public override void OnTickFixed() { }
}
```
### ITickLate
Use it when you have code that needs to run after all other updates.

```csharp
public class BehaviorExample : Behavior, ITickLate{
    public override void OnTickLate() { }
}
``` 

 ### IData
Use it when you want mark class as a data container. Remember that you need use [System.Serializable] attribute for data containers.
```csharp
[System.Serializable]
public class DataExample : IData{
    public override void Dispose() { }
}
``` 

 ### ISetup
Sometimes your data containers might need extra setup from code instead of Unity3d Inspector. In this case, use this interface for your
data components. When data component is added to an actor he will check all components for ISetup interface and trigger them.
```csharp
[System.Serializable]    
public class DataRender: ISetup, IData
{
	public MaterialPropertyBlock matPropBlock;
	public int ID = 0;
 
	public void Setup(Actor actor)
	{
			var rend = actor.Get<SpriteRenderer>("view");
			matPropBlock = new MaterialPropertyBlock();
			rend.GetPropertyBlock(matPropBlock);
	}

	public void Dispose()
	{
		source = null;
	}
}
```

### IMustBeWiped
IMstBeWiped interface marks processings that must be cleaned from toolbox when scene changed.
```csharp
  public class ProcessingShakeCamera : IDisposable, IMustBeWiped 
  {
  }
```

### IReceive<T>
IReceive<T> interface is used when you want entity to recieve a signal with type of T from local signal dispatcher. IReceive<T> normally used inside of Actors for local communication.
```csharp
  public class ProcessingShakeCamera : IDisposable, IMustBeWiped, IReceive<SignalCameraShake> 
  {
	public void HandleSignal(SignalCameraShake arg)
		{
			if (arg.strength == 0)
				tweenShakeAverage.Restart();
			else if (arg.strength == 1)
				tweenShakeStrong.Restart();
			else if (arg.strength == 2)
				tweenShakeVeryStrong.Restart();
		}
  }
```

### IReceiveGlobal<T>
IReceiveGlobal<T> interface is used when you want entity to receive a signal with type of T from global signal dispatcher. 
```csharp
  public class ProcessingShakeCamera : IDisposable, IMustBeWiped, IReceiveGlobal<SignalCameraShake> 
  {
	public void HandleSignal(SignalCameraShake arg)
		{
			if (arg.strength == 0)
				tweenShakeAverage.Restart();
			else if (arg.strength == 1)
				tweenShakeStrong.Restart();
			else if (arg.strength == 2)
				tweenShakeVeryStrong.Restart();
		}
  }
```
## Toolbox
The toolbox is a singleton that contains all processings, global data and everything you want to get from global access.
Think of toolbox as a "global actor." 

To add a new instance of a class to toolbox use Add method
Example:
```csharp
Toolbox.Add<ProcessingInputConnect>();
```

To get something from toolbox use Get method
Example:
```csharp
Toolbox.Get<ProcessingInputConnect>();
```


## Processings
Docs are coming soon. Global scripts to control groups of actors. Similar to ECS systems.
Or used like "managers" classes. 
## Blueprints
Docs are coming soon. Scriptable objects that define common resources for similar actors
## Tags
Docs are coming soon. Glue to identify actors and work with game logic.
## ECS
Docs are coming soon. Simple ECS pattern for working with actors.


	
 
