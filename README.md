<p align="center">
    <img src="https://i.gyazo.com/0d279c9e9fefb1198b5566a98c8776aa.png" alt="Actors">
</p>

[![Discord](https://img.shields.io/discord/320945300892286996.svg?label=Discord)](http://discord.pixeye.games)
[![Twitter Follow](https://img.shields.io/badge/twitter-%40dimmPixeye-blue.svg?style=flat-square&label=Follow)](https://twitter.com/dimmPixeye)
[![license](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://github.com/dimmpixeye/Actors-Unity3d-Framework/blob/master/LICENSE)
[![openupm](https://img.shields.io/npm/v/com.pixeye.ecs?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.pixeye.ecs/)

#### Actors is a framework empowering developers to make better games faster on Unity.
## ⭐ Why Actors ?
The framework favors simplicity and doesn't try to "abstract away" Unity workflows bringing first-class support for combining ECS with classic Unity component system.
- Deterministic worflow.
- ECS with clean syntax and no codegen.
- ECS integration with Unity gameobjects via Actor components.
- Logic Layers.
- Object Pooling.
- Multiscene editing.
- Reactive variables.
- Fast coroutines working in any class.
- Update methods working in any class.

## 📖 ECS Basic Overview
**🔖 Entities** are containers for components. Entity ID is represented by ent structure.
```csharp
// Create entity
ent alpaca = Entity.Create();
// Kill entity
alpaca.Release();
```

**🔖 Components** are containers for data.
```csharp
sealed class ComponentAlpaca
{
  public int fluffiness;
}
```
<details>
<summary>
To create a new component right click in project window and select Create->Actors->ECS Component
</summary>
<a href="https://gyazo.com/9b1735ba6c7b7844c222b9b439fc8dcb"><img src="https://i.gyazo.com/9b1735ba6c7b7844c222b9b439fc8dcb.gif" alt="Component creation" width="800"/></a>
</details>

> 💡 *For comfortable workflow a component is created together with special helper class. While you can live without that helper all examples are provided with use of it.*


**🔖 Systems** in Actors are called **Processors**. Processors execute game logic with **groups**. Groups are containers for entities filtered by components mask.
```csharp
  public class ProcessorAlpaca : Processor, ITick
  {
    // All entities that have ComponentAlpaca will be in this group.
    readonly Group<ComponentAlpaca> alpacas = default;
    
    public void Tick(float dt)
    {
      // iterate through entities in the group
      foreach (var alpaca in alpacas)
      {
        // retrieve a component
        var cAlpaca = alpaca.ComponentAlpaca();
      }
    }
  }
```
<details>
<summary>
To create a new processor right click in project window and select Create->Actors->ECS Processor.
</summary>
<a href="https://gyazo.com/e550c2a6fa035c0d877e5491414febcf"><img src="https://i.gyazo.com/e550c2a6fa035c0d877e5491414febcf.gif" alt="Add processor" width="800"/></a>
</details>

**🔖 Layers** are containers for your **processors** and entry point of the scene. You can think about layers as **ECS worlds**, but they are much more then that. In fact, everything in Actors controlled by layers. Every unity scene must hold no more than one layer.

```csharp
using Pixeye.Actors;

public class LayerGame : Layer<LayerGame>
{
  protected override void Setup()
  {
    // the order affects on execution
    Add<ProcessorAlpaca>();
    Add<ProcessorDamage>();
    Add<ProcessorAnimations>();
  }
}
```
<details>
<summary>
To create a new layer right click in project window and select Create->Actors->Layer
</summary>
<a href="https://gyazo.com/8bf54796394aead4cead1ad059fabdf9"><img src="https://i.gyazo.com/8bf54796394aead4cead1ad059fabdf9.gif" alt="Layers="000"/></a>
</details>

## 📖 Scenes Overview
The framework favors multiscene architecture in Unity. The concept is simple: you have one main scene that can be only changed for another scene and subscenes that can be added/removed when needed. Normally scene will have a logic layer of the framework. This will be explained further.
  
> 💡 *The main (or it's also called active in Unity) scene name font style is bold inside the Hierarchy window.*

* **Scene API**
  * **SceneMain**: API for changing the main scene.
  * **SceneSub** : API for adding/removing a subscenes.

```csharp
public class ProcessorAlpaca : Processor, ITick
{
  public void Tick(float dt)
  {
      // Example of how to change the main scene.
      if (Input.GetKeyDown(KeyCode.Alpha1))
        SceneMain.ChangeTo(1);                       // by index
    
      if (Input.GetKeyDown(KeyCode.Alpha2))
        SceneMain.ChangeTo("Scene Alpaca Fields");   // by name

      // Example of how to work with subscenes.
      if (Input.GetKeyDown(KeyCode.Alpha1))
      {
        SceneSub.Add("Alpaca Shop");    //  by name
        SceneSub.Add(2);                //  by index
      }
      if (Input.GetKeyDown(KeyCode.Alpha2))
      {
        SceneSub.Remove("Alpaca Shop"); //  by name
        SceneSub.Remove(2);             //  by index
      }
  }
}
```

> 💡 *Don't forget to add scene in the build settings of your game.*

Note that you can have **only one** copy of each scene. In case you try to add scene twice the framework will ignore the call.


## 📖 Layers Overview
As already said, layers are very important part of the framework. Each layer represents a unity scene and holds several important modules of the framework. When the layer is removed or changed everything that is inside of the layer will be cleaned up. Another important thing is that *any* **Actor** or **Monocache** components will start working *only* after initialization and setup of the layer. The concepts of **actor** and **monocache** will be discussed further.

* **Public Layer Modules** 
  * **Engine**   : Core module that controls all other updates.
  * **ECS**      : API for specific ECS stuff like events.
  * **Entity**   : API for creating new entities on the layer.
  * **Actor**    : API for creating new actors on the layer.
  * **Observer** : Reactive observer for any variable.
  * **Time**     : API for custom timing on the layer.
  * **Obj**      : API for instantiating prefabs on the layer.

* **Private Layer Modules**
  * **Pool**     : Module that controls GameObject pooling. 
  * **Signals**  : Module that controls signals, a global event dispatcher.
  * **Routines** : Module that controls routines, custom coroutines.

* **Who are aware of Layers?**
  * **Processors** : Created in the layer and get the reference of it.
  * **Monocache**  : Base monobehavior classes in the framework. They get the reference of a layer when initialized.
  * **Actors**     : Inherited from monocache class. They represent entity view.

### 📘 Routine Overview
**Routines** are custom coroutines that can work outside of Unity scope and more performant than native Unity coroutines.
Routines work inside of a **layer** and will be stopped if the layer they work on would be destroyed. Routines have similar to Coroutines API so it will be very easy to start using them.
There are two types of routines:
* **Scaled**  : These routines are affected by layer's time scale.
* **Unscaled**: These routines are not affected by layer's time scale.

```csharp
public class ProcessorAlpaca : Processor, ITick
{
  IEnumerator CoHangWithAlpaca()
  {
     yield return Layer.Wait(2.0f);
     yield return Layer.WaitFrame;
     Debug.Log("Stop hanging around");
  }

  public void Tick(float dt)
  {
      if (Input.GetKeyDown(KeyCode.Alpha1))
      {
        var routine = Layer.Run(CoHangWithAlpaca()); // run routine and get routine call.
        routine.Stop(); // stop the routine
      }
  }
}
```
**🔖 Wait for** are delayed actions based on coroutines.
```csharp
if (Input.GetKeyDown(KeyCode.Alpha1))
{
   Layer.WaitFor(1.0f, () => { Debug.Log("Hello!"); });
}
```

**🔖 Wait** is used to wait for a period of time or to finish another routine.
```csharp
IEnumerator CoWorld()
    {
      yield return Layer.Run(CoHello()).Wait();
      Debug.Log("World !");
    }
    IEnumerator CoHello()
    {
      Debug.Log("Hello");
      yield return Layer.Wait(1.0f);
    }
```



## 📖 How to Install  
#### Git Installation
- Open the manifest.json file of your Unity project.
- Add ```"com.pixeye.ecs": "https://github.com/PixeyeHQ/actors.unity.git"```
#### OpenUPM Installation
The package is available on the [openupm registry](https://openupm.com). It's recommended to install it via [openupm-cli](https://github.com/openupm/openupm-cli).
```
openupm add com.pixeye.ecs
```
#### Manual Installation 
- Download latest package from the [Release](https://github.com/PixeyeHQ/actors.unity/releases) section
- Import ```actors.unitypackage``` to your Unity Project
- Optionally import ```actors-template.unitypackage``` from the Install folder of Actors
#### How To Update
<details> <summary>
Press Tools->Actors->Update Actors to get a new update.
</summary>
         <a href="https://gyazo.com/e64645a5eacba87e6714da2e848cb88d"><img                        src="https://i.gyazo.com/e64645a5eacba87e6714da2e848cb88d.gif" alt="Updating" width="800"/></a>
        </details>
        
> 💡 *If you install via **OpenUPM** registry, you can update the package using the Unity package manager.*

    
    
In Actors components can be either classes or structures.
<details>
<summary>
To change component type press Tools->Actors->Set Struct Components
</summary>
<a href="https://gyazo.com/eb9e8cd2e5b9000e412d8466c15b6281"><img src="https://i.gyazo.com/eb9e8cd2e5b9000e412d8466c15b6281.gif" alt="switch to struct" width="1512.5"/></a>
</details>

> 💡 *You should decide from the start what component types you want to use as the workflow slightly differs. Personally, I advice to stick with classes.*

