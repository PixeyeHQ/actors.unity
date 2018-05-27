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

### Project Setup and StarterKernel
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

