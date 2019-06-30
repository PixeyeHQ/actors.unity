<p align="center">
    <img src="http://raw.pixeye.games/logo_framework.png" alt="Actors">
</p>

[![Discord](https://img.shields.io/discord/320945300892286996.svg?label=Discord)](https://discord.gg/suZuhyt)
[![Join the chat at https://gitter.im/ActorsFramework/Lobby](https://img.shields.io/badge/gitter-join%20chat-green.svg?style=flat-square)](https://gitter.im/ActorsFramework/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Twitter Follow](https://img.shields.io/badge/twitter-%40dimmPixeye-blue.svg?style=flat-square&label=Follow)](https://twitter.com/dimmPixeye)
[![license](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://github.com/dimmpixeye/Actors-Unity3d-Framework/blob/master/LICENSE)

# ACTORS - Lightning fast ECS (Entity Component System) Framework for Unity 
ACTORS is a complete game framework with multiscene editing, game object pooling, ECS and data-driven approach for game logic explicitly built for Unity3d. It is used to ease the pain of decoupling data from behaviors without tons of boilerplate code and unnecessary overhead. 

 
## Requirements
- Unity 2018 and higher 

## How to Install
### From packages ( Preferable )

- Create a new Unity Project
- Open the manifest.json file in the Packages folder inside of the Project
- Add ```"com.pixeye.ecs": "https://github.com/dimmpixeye/ecs.git",```

### From Unity
- Download from https://github.com/dimmpixeye/ecs/releases 

### How To Update
If you use packages you can automatically get fresh updates inside Unity editor!  
Press Tools->Actors->Update Framework[GIT] to get new update when needed.

## Documentation 

* [Examples](https://github.com/dimmpixeye/CryoshockMini)
* [Wiki](https://github.com/dimmpixeye/ecs/wiki)
 
## Introduction

For more information please visit the [Wiki](https://github.com/dimmpixeye/ecs/wiki).

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
	static partial class Components
	{
		public const string Health = "Pixeye.Source.ComponentHealth";

		[RuntimeInitializeOnLoadMethod]
		static void ComponentHealthInit()
		{
			Storage<ComponentHealth>.Instance.Creator       = () => { return new ComponentHealth(); };
			Storage<ComponentHealth>.Instance.DisposeAction = DisposeComponentHealth;
		}

		/// Use this method to clean variables
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DisposeComponentHealth(in ent entity)
		{
			ref var component = ref Storage<ComponentHealth>.Instance.components[entity.id];
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ref ComponentHealth ComponentHealth(in this ent entity)
		{
			return ref Storage<ComponentHealth>.Instance.components[entity.id];
		}
	}
```
