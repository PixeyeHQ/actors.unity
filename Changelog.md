## Changelog 
### Actors-2020-06-02
🛠️ **Fixed** 
* [🐞Pooled gameobject of entity gets null reference exception.](https://github.com/PixeyeHQ/actors.unity/issues/36)
* [🐞Pooled Actors won't initialize after re-activating.](https://github.com/PixeyeHQ/actors.unity/issues/37)
* [🐞Childs of entities are not initialized.](https://github.com/PixeyeHQ/actors.unity/issues/38)
* [🐞Groups are not cleaned when a scene is reloaded.](https://github.com/PixeyeHQ/actors.unity/issues/39)
* [🐞Actors continue to think that they are on the old layer when using `entity.MoveTo<T>`](https://github.com/PixeyeHQ/actors.unity/issues/40)
* [🐞Unloading scene in the inspector and hitting play breaks the editor.](https://github.com/PixeyeHQ/actors.unity/issues/41)
* [🐞Tools->Actors->Update Actors doesn't work in the Unity 2019.4](https://github.com/PixeyeHQ/actors.unity/issues/43)
* [🐞Updating entities from the Added/Removed Ecs events do not work correctly.](https://github.com/PixeyeHQ/actors.unity/issues/44)

### Actors-2020-06 | Codename: Bluefin Tuna
🚧 **IMPORTANT** 🚧   
The new version of Actors **is not compatible** with previous versions. If you are using ***Actors-2020-04-30***  or earlier version in the production cycle, please change your manifest link to: ```"com.pixeye.ecs": "https://github.com/PixeyeHQ/actors.unity.git#actors-2020-04-30",```

The framework was rewritten so there is no reason to write down all changes. Look [README](https://github.com/PixeyeHQ/actors.unity/blob/develop/README.md).

If you want to migrate to the new version of Actors checkout the [MIGRATION GUIDE](https://github.com/PixeyeHQ/actors.unity/wiki/Migration-to-Actors-2020.06).


