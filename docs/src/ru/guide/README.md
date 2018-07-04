# Введение

ACTORS небольшой фреймворк, созданный для Unity3d. Он используется для облегчения разделения данных от поведения без тонн кода. Фреймворк полагается на концепт использования monobehavior'а Unity3d, но без ненужных издержек.

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
