# Introduction

ACTORS is a small framework explicitly built for Unity3d. It is used to ease the pain of decoupling data from behaviors without tons of boilerplate code. It relies on Unity3d scripting monobehavior concept but without unnecessary overhead.

```csharp
public class ActorPlayer : Actor, ITick
{
	[FoldoutGroup("Setup")] public DataMove dataMove;

    protected override void Setup()
	{
		Add(dataMove);
		Add<BehaviorInput>();
	}

}
```
```csharp
[System.Serializable]
public class DataMove : IData
{
	public float x;
	public float y;
	public void Dispose()
	{
	}
}
```
```csharp
public class BehaviorInput : Behavior, ITick
{
	[Bind] private DataMove dataMove;

	public override void OnTick()
	{
		dataMove.x = Input.GetAxis("Horizontal");
		dataMove.y = Input.GetAxis("Vertical");
	}
}

```