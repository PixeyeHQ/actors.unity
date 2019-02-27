<p align="center">
    <img src="http://raw.pixeye.games/logo_framework.png" alt="Actors">
</p>


[![Discord](https://img.shields.io/discord/320945300892286996.svg?label=Discord)](https://discord.gg/suZuhyt)
[![Join the chat at https://gitter.im/ActorsFramework/Lobby](https://img.shields.io/badge/gitter-join%20chat-green.svg?style=flat-square)](https://gitter.im/ActorsFramework/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Twitter Follow](https://img.shields.io/badge/twitter-%40dimmPixeye-blue.svg?style=flat-square&label=Follow)](https://twitter.com/dimmPixeye)
[![license](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://github.com/dimmpixeye/Actors-Unity3d-Framework/blob/master/LICENSE)

# ACTORS -The Entity Component System framework for Unity
ACTORS is a complete game framework with multiscene editing, game object pooling and ECS ( entity-component-system ) data-driven approach for game logic explicitly built for Unity3d. It is used to ease the pain of decoupling data from behaviors without tons of boilerplate code and without unnecessary overhead. 

## Features

- ECS events ( can be extended with Unirx )
- Very lightweight ECS syntax
- Actors ( visual entity composer in the Unity Inspector window )
- Built-in support for pooling
- Built-in support for Unity multiscene editing 
- Built-in support for plugins with a pluggable wrapper that you can share with others/through projects
- Built-in support for updates through ITick, ITickFixed, ITickLate - ( faster than Unity Update methods )
- Signals ( in-memory publish/subscribe system and effectively replace Unity3d SendMessage )
- Tags ( add simple tags to entities to define states )
- Editor extensions ( foldout group in the inspector and tags editing )
- Numerous monobehavior components to help interact with the framework
- Templates for creating scriptable objects
- Game console plugin for commands and cheats
- Framework can be extended with ODIN inspector

## Requirements

- Unity 2018 and higher 

## How to Install

### From packages

- Create a new Unity Project
- Open the manifest.json file in the Packages folder inside of the Project
- Add ```"com.pixeye.ecs": "https://github.com/dimmpixeye/ecs.unity.git",```
- Press Tools->Actors->Update Framework[GIT] in Unity to get new update when needed

### From Unity

- Download from https://github.com/dimmpixeye/ecs/releases 

## Documentation 

* [Examples](https://github.com/dimmpixeye/ecs-Examples)
* [Wiki](https://github.com/dimmpixeye/ecs/wiki)
 
 
 
