 

# Reactive PoolManager
An ultra fast and lightweight object pool manager with zero allocations with prepopulate feature.
Uses Unix extension and based on object instance ids. You can pool  prefabs without any extra components and can mix different prefab types in one pool.

[![https://gyazo.com/ebf0f27a5e5ec29ecfe019a9897e105c](https://i.gyazo.com/ebf0f27a5e5ec29ecfe019a9897e105c.gif)](https://gyazo.com/ebf0f27a5e5ec29ecfe019a9897e105c)

*How to use*

Firstly, add a new pool to the game.
```C#
 ManagerPool.Instance.AddPool(PoolType.Entities);
```
Edit PoolType enum file to add more pool types
```C#
  public enum PoolType
    {
        Entities = 0,
        Fx = 1
    }
```

If needed you can prepopulate some objects at any time:
```C#
//right after adding new pool
 ManagerPool.Instance.AddPool(PoolType.Entities).PopulateWith(prefab, 100, 10);
//or by getting pool from manager
 ManagerPool.Instance.Get(PoolType.Entities).PopulateWith(prefab, 10, 1, 100);
```

+ First values if object you want to add to pool
+ Second value is amount of objects you want to prepopulate
+ Third value is a number of objects you want to create per tick
+ Fourth value is the size of the tick count in frames for one chunk of objects to be created.

```C#
PopulateWith(prefab, 10, 1, 100); 
```

To Spawn new object on scene simple use 
You can add position,rotation and parent aswell
```C#
ManagerPool.Instance.Spawn(PoolType.Entities,prefab);
```

When you don't need object no more use
```C#
ManagerPool.Instance.Despawn(PoolType.Entities, ##YOUR_SPAWNED_GAMEOBJECT##);
```


You can gain control of such events as OnSpawn/OnDespawn by adding an IPoolable interface to a component of your object in the pool.
```C#
public class BigShip : MonoBehaviour , IPoolable {
    public void OnSpawn()
    {   
    }

    public void OnDespawn()
    {
    }
}
```


