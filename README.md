<p align="center">
    <img src="http://raw.pixeye.games/logo_framework.png" alt="Actors">
</p>
<p align="center">
    
[![Join the chat at https://gitter.im/ActorsFramework/Lobby](https://img.shields.io/badge/gitter-join%20chat-green.svg?style=flat-square)](https://gitter.im/ActorsFramework/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Twitter Follow](https://img.shields.io/badge/twitter-%40dimmPixeye-blue.svg?style=flat-square&label=Follow)](https://twitter.com/dimmPixeye)
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



