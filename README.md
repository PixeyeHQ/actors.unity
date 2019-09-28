<p align="center">
    <img src="https://i.gyazo.com/0d279c9e9fefb1198b5566a98c8776aa.png" alt="Actors">
</p>

[![Discord](https://img.shields.io/discord/320945300892286996.svg?label=Discord)](https://discord.gg/suZuhyt)
[![Twitter Follow](https://img.shields.io/badge/twitter-%40dimmPixeye-blue.svg?style=flat-square&label=Follow)](https://twitter.com/dimmPixeye)
[![license](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://github.com/dimmpixeye/Actors-Unity3d-Framework/blob/master/LICENSE)

# ACTORS - Fast ECS (Entity Component System) Framework for Unity 
ACTORS is a complete game framework with multiscene editing, game object pooling, ECS and data-driven approach for game logic explicitly built for Unity. It is used to ease the pain of decoupling data from behaviors without tons of boilerplate code and unnecessary overhead. 

 
### Requirements
- Unity 2018 and higher 

### How to Install
#### From packages ( Preferable )

- Create a new Unity Project
- Open the manifest.json file in the Packages folder inside of the Project
- Add ```"com.pixeye.ecs": "https://github.com/dimmpixeye/actors.git",```

#### From Unity
- Download from https://github.com/dimmpixeye/ecs/releases 

#### How To Update
If you use packages you can automatically get fresh updates inside Unity editor!  
Press Tools->Actors->Update Framework[GIT] to get new update when needed.

## Documentation 

* [Examples](https://github.com/dimmpixeye/CryoshockMini) ( In progress ) 
* [Wiki](https://github.com/dimmpixeye/ecs/wiki) ( In progress ) 
 
## Basic

### Components
Components are data containers without logic. In ACTORS Framework components can be either classes or structs. You should decide carefully from the start of the project what kind of layout ( class or structure ) you want to use as the workflow slightly differs.

> You can automatically create a component class/struct from a special template in Unity.  
> Project->Create->Actors->Generate->Component

#### Class Components

```csharp
	sealed class ComponentHealth
	{
		public int val;
		public int valMax;
	}
```

#### Struct Components
> To use struct components you need to add ```ACTORS_COMPONENTS_STRUCTS``` to Scripting Define Symbols in the Project Player Settings.  

```csharp
	struct ComponentHealth
	{
		public int val;
		public int valMax;
	}
```

#### Component Helper
Every component is generated with special helpers that are optional but makes your life way easier.  
If you don't use Unity for generating components, you can easily make a template in your IDE. Or type helpers manually.

```csharp
	static partial class component
	{
	       // auxiliary excluding filter for entity groups
		public const string Health = "ComponentHealth";
               // a shortcut to get compontent like this : entity.ComponentHealth();
		public static ref ComponentHealth ComponentHealth(in this ent entity)
			=> ref Storage<ComponentHealth>.components[entity.id];
	}
        
	sealed class StorageComponentHealth : Storage<ComponentHealth>
	{
	        // This is for performance. Adding new Component is much faster than new T();
		public override ComponentHealth Create() => new ComponentHealth();
		// Every time one or more components are removed from the entity the dispose method will run.
                // Use this method for cleanup and reverting settings of the component.
		public override void Dispose()
		{
			for (int i = 0; i < disposedLen; i++)
			{
				ref var component = ref components[disposed[i]];
				component.val = 0;
				component.valMax = 100;
			}
		}
	}

```

### Entity
Entity is an incremental ID that help accessing components. Entity is represented by ```ent``` structure.


#### How to create entity ?

```csharp
public void SomeMethod()
{
    // Bare entity
    ent e = Entity.Create();
}
```
___

Entities can hold information about unity objects as well!

```csharp
public void SomeMethod()
{    
     // New entity with a new GO ( GameObject ).
     // The GO prefab will be taken from the Resources folder by string ID.
     ent e = Entity.Create("Obj Fluffy Unicorn");
     // Access to the transform of Obj Fluffy Unicorn gameobject.
     e.transform.position = new Vector3(0,0,0) ;
}
```
___

```csharp
public GameObject prefabFluffyUnicorn;
public void SomeMethod()
{    
     // New entity with a new GO ( GameObject ).
     // The GO will be created from the provided prefab.
     // The GO will be pooled.
     ent e = Entity.Create(prefabFluffyUnicorn, true);
     // Access to the transform of Obj Fluffy Unicorn gameobject.
     e.transform.position = new Vector3(0,0,0) ;
}
```
___

You can pool gameobject by adding ```true``` variable in the end of the method.
```csharp
public void SomeMethod()
{    
     // New entity with a new GO ( GameObject ).
     // The GO prefab will be taken from the Resources folder by string ID. 
     // The GO will be pooled.
     ent e = Entity.Create("Obj Fluffy Unicorn", true);
     // Access to the transform of Obj Fluffy Unicorn gameobject.
     e.transform.position = new Vector3(0,0,0) ;
}
```
___

#### How to add Components ?
There are several ways to add components depending on the context of your code.
In case you want to setup your new entity use ```Set``` Method. Use ```Set``` method only with newly created entities.

```csharp
public void SomeMethod()
{    
     ent e = Entity.Create("Obj Bunny");
     // Add components
     var cCute       = e.Set<ComponentCute>();
     var cJumping    = e.Set<ComponentJumping>();
     var cConsumable = e.Set<ComponentConsumable>();
     var cPoo        = e.Set<ComponentCanPoo>();

     // Component Cute
     cCute.attractivness = float.PositiveInfinity;
     // Component Jumping
     cJumping.power = 100;
}
```

Use ```Add``` method when you want to attach new component to already existed entity.
```csharp
public void SomeMethod()
{    
     // where e is some entity.
     // Add components
     var cCute       = e.Add<ComponentCute>();
     var cJumping    = e.Add<ComponentJumping>();
     var cConsumable = e.Add<ComponentConsumable>();
     var cPoo        = e.Add<ComponentCanPoo>();

     // Component Cute
     cCute.attractivness = float.PositiveInfinity;
     // Component Jumping
     cJumping.power = 100;

}
```
 

The difference between Add and Set are in the operations that Framework must do to create this object. In the example above, the Framework needs to make 4 ```ADD``` operations, but in the case of the ```SET``` method, it will make only 1 operation.

Use ```AddGet``` method when you unsure if entity has particular component. This method will check and add component if it doesn't exist.

```csharp
public void SomeMethod()
{    
     // where e is some entity.
     // Add components
     var cCute       = e.AddGet<ComponentCute>();
     var cJumping    = e.AddGet<ComponentJumping>();
     var cConsumable = e.AddGet<ComponentConsumable>();
     var cPoo        = e.AddGet<ComponentCanPoo>();

     // Component Cute
     cCute.attractivness = float.PositiveInfinity;
     // Component Jumping
     cJumping.power = 100;

}
```


#### How to kill Entities?

```csharp
// Create new entity with Obj Bunny prefab
ent e = Entity.Create("Obj Bunny");
// Somewhere in the code
e.Release();
```

> If you create an entity with a GameObject, it will be destroyed as well. If the GameObject was marked as poolable, it will be deactivated and reused in the future.

#### How to kill Entity without touching a GameObject?
```csharp
// Create new entity with Obj Bunny prefab
ent e = Entity.Create("Obj Bunny");
// Somewhere in the code
e.Unbind();
```

### Processors
Processors are systems in ACTORS framework. You execute game logic through systems.
Custom processors must be inherited from a Processor class.

### Group
Processors execute game logic through iterating groups. Groups are entities that are filtered by specific components. The same entity may lay in many groups.

```csharp
sealed class ProcessorMove : Processor, ITick
	{
          // Define a group. The group is defined via Processor parent class
          Group<ComponentMove,ComponentPosition> groupMovables;
	  
	        // ITick interface Adds Tick method. It's an update with delta time.
	  	public void Tick(float delta)
		{
		        // iteration through group
			for (int i = 0; i < groupMovables.length; i++)
			{
				ref var entity = ref groupMovables.entities[i];

				var cMove     = entity.ComponentMove();
				var cPosition = entity.ComponentPosition();

				// do some logic
			}
		}
	  
        }
```

If you are going to use only one group in the processor you can take a slightly different approach. There is no difference except that you will type less.

```csharp
// Define a group from the processor. The group defined in this way called source.
sealed class ProcessorMove : Processor<ComponentMove,ComponentPosition>, ITick
	{
  
	        // ITick interface Adds Tick method. It's an update with delta time.
	  	public void Tick(float delta)
		{
		        // iteration through group
			for (int i = 0; i < source.length; i++)
			{
				ref var entity = ref source.entities[i];

				var cMove     = entity.ComponentMove();
				var cPosition = entity.ComponentPosition();

				// do some logic
			}
		}
	  
        }
```

### Group events
You can make events for entities that were added or removed from the group. It's "similar" to Unity OnEnable and OnDisable logic. 

```csharp
sealed class ProcessorMove : Processor, ITick
	{
          // Define a group. The group is defined via Processor parent class
          Group<ComponentMove,ComponentPosition> groupMovables;
	  
          public ProcessorMove()
	  {
	  // register EventsForMovables for group. Choose events to work with.
	  // sending this processor as param allows to use it from events class
	  groupMovables.Set<EventsForMovables>(Op.Add | Op.Remove, this);
	  }
 
	        // ITick interface Adds Tick method. It's an update with delta time.
	  	public void Tick(float delta)
		{
		        // iteration through group
			for (int i = 0; i < groupMovables.length; i++)
			{
				ref var entity = ref groupMovables.entities[i];

				var cMove     = entity.ComponentMove();
				var cPosition = entity.ComponentPosition();

				// do some logic
			}
		}
		
		class EventsForMovables : GroupEvents<ProcessorMove>
		{
                        public override void OnAdd(ent[] entities, int length)
			{
			   // work with all entities that were added to the group on the current frame
			   for (int i = 0; i < length; i++)
			   {
			        ref var entity = ref entities[i];
			   }
			   // if you need a link to the Processor from the events  class use variable proc
                           proc.DoStuff();
			}
			public override void OnRemove(ent[] entities, int length)
                        {
			   for (int i = 0; i < length; i++)
			   {
			        ref var entity = ref entities[i];
			   }
			}
			
                }
		
	  
        }
```
The code below shows how to add events to group from the processor.

```csharp
// Define a group from the processor. The group defined in this way called source.
 // register EventsForMovables for group. Choose events to work with.
[WantEvent(Op.Add | Op.Remove)]
sealed class ProcessorMove : Processor<ComponentMove,ComponentPosition>, ITick
	{
	        // ITick interface Adds Tick method. It's an update with delta time.
	  	public void Tick(float delta)
		{
		        // iteration through group
			for (int i = 0; i < source.length; i++)
			{
				ref var entity = ref source.entities[i];

				var cMove     = entity.ComponentMove();
				var cPosition = entity.ComponentPosition();

				// do some logic
			}
		}
	
	                 public override void OnAdd(ent[] entities, int length)
			{
			   // work with all entities that were added to the group on the current frame
			   for (int i = 0; i < length; i++)
			   {
			        ref var entity = ref entities[i];
			   }
			}
			public override void OnRemove(ent[] entities, int length)
                        {
			   for (int i = 0; i < length; i++)
			   {
			        ref var entity = ref entities[i];
			   }
			}
        }
```

```Tip. You can use Op.All instead of Op.Add | Op.Remove```



## Starters
The Starter class is the entry point of a game scene. You define all your Processors and Scene dependecies there. How you define your processors matters for execution order.
```csharp
        // Inherit from Starter class
	sealed class StarterGame : Starter
	{
                // override Setup method. It's like Awake in Unity.
		protected override void Setup()
		{
			Add<ProcessorMotion>();
			Add<ProcessorInput>();
			Add<ProcessorPlayer>();
                  }
         }
```

## Actors
The Actor is a monobehavior class that allows communicating between unity game objects and framework. Most of the time you will inherit from Actors when defining new objects.

The Actor class is for defining what is your Entity. You use Actors only to add some components to the Entity, to have a connection between Framework and Unity out of the box and for initial setup of the object. You can use it as _view_ class if you like MVC patterns.

### How to create an Actor

```csharp
public class ActorModuleReactor : Actor
    {
       // use the FoldoutGroup attribute to decorate components nicely 
       // in groups in the Unity Inspector
       [FoldoutGroup("Setup")]
        public ComponentStateMachine componentStateMachine;

        [FoldoutGroup("Setup")]
        public ComponentRecycle componentRecycle;

        // Use setup method to define Actor.
        protected override void Setup()
        {
             // add your components to the Entity of the Actor
             entity.Set(componentStateMachine);
             entity.Set(componentRecycle);
             
             // add a component by its type. 
             entity.Set<ComponentDescription>;
        }
    }
```

[![Actor in the Inspector](https://i.gyazo.com/2bdd01853f4df82d3ddf6e8f06241b1f.gif)](https://gyazo.com/2bdd01853f4df82d3ddf6e8f06241b1f)
