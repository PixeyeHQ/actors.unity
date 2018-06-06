<p align="center">
    <img src="http://raw.pixeye.games/logo_framework.png" alt="Actors">
</p>

[![Join the chat at https://gitter.im/ActorsFramework/Lobby](https://img.shields.io/badge/gitter-join%20chat-green.svg?style=flat-square)](https://gitter.im/ActorsFramework/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Join the chat at https://discord.gg/ukhzx83](https://img.shields.io/badge/discord-join%20channel-brightgreen.svg?style=flat-square)](https://discord.gg/ukhzx83)
[![Twitter Follow](https://img.shields.io/badge/twitter-%40dimmPixeye-blue.svg?style=flat-square&label=Follow)](https://twitter.com/dimmPixeye)
[![license](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://github.com/dimmpixeyeUnity-Framework/master/LICENSE)

## Actors - Компонентно-ориентированный паттерн для Unity3d

ACTORS небольшой фреймворк, созданный для Unity3d. Он используется для облегчения разделения данных от поведения без тонн кода. Фреймворк полагается на концепт использования monobehavior'а Unity3d, но без ненужных издержек.

### Обзор игрового кода :
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

## Содержание

* Установка
    * <a href="#Installation">Загрузка</a>
    * <a href="#Overview">Обзор проекта</a>
    * <a href="#Setup">Установка проекта</a>
    * <a href="#Scenes Setup">Создание сцен</a>
* Базовые понятия  
    * <a href="#Actors overview">Обзор акторов</a>
    * <a href="#Data component">Компонент данных (Data)</a>
    * <a href="#Behavior component">Компонент поведения (Behavior)</a>
    * <a href="#Signals">Сигналы</a>
    * <a href="#Interfaces overivew">Обзор интерфейсов</a>
    * <a href="#Processings">Обработчики (Processings)</a>  
        * <a href="#ProcessingSceneLoad">Как сменить сцену</a>
    * <a href="#Object pooling">Пул объектов (Object pooling)</a>
    * <a href="#Creating and destroying new objects">Создание и удаление новых объектов</a>
    * <a href="#Blueprints">Схемы (Blueprints)</a>
    * <a href="#Tags">Теги</a>
    * <a href="#ECS">ECS</a>

##  <a id="Installation"></a>Загрузка
Из источника
* Клонируйте этот репозиторий и откройте его как новый проект Unity3D.

## <a id="Overview"></a>Обзор проекта
Проект включает в себя несколько папок:
* [-]Common : Для использования встроенных библиотек, плагинов фреймворка.
* [0]Framework : Код фреймворка. Вам не нужно тут ничего трогать.
* [1]Source : Игровой код.
* [2]Content : Игровой контент: сцены, графика, аудио и т.д.
* [3]ThirdParty : Используемые вами библиотеки из Asset store.
* Plugins : Папка для плагинов unity3d.

##  <a id="Setup"></a>Установка проекта
Фреймворк очень полагается на аддитивные сцены в Unity3D. Что бы использовать его так как было задумано вам нужно сделать немного приготовлений.

1. Откройте сцену sceneKernel. Вы можете найти ее в Assets/[2]Content/Scenes
там вы найдете один transform в view, названном [KERNEL] - это корневой объект всей вашей игры. Для удобства, я прикрепил к ней камеру ( но, если вам это не надо, вы можете так не делать ) 

2. Взгляните на скрипт StarterKernel, прикрепленный к [KERNEL]. Стратерами я называю скрипты, которые инициализируют вашу игру, библиотеки и сцены. 

В StarterKernel есть несколько переменных, которые вы можете настроить: 
* ScriptableObject Blueprints: Blueprint это контейнер для всех blueprint'ов в вашей игре. Вlueprint'ами я называю схемы, построенные на  ScriptableObject. 
* ScriptableObject DataGameSettings: Сюда можно добавить некторые настройки для вашей игры.
* ScriptableObject DataGameSessiom : Доска внутреигровой сессии. Изменяйте так, как вам нужно. 
* Pluggable: лист всех используемых доп. модулей. Pluggable это оболочка для различных внешних ассетов, которые вы хотите подключить к игре и фреймворку и инцициализировать при запуске. По умолчанию у вас стоит модуль называемый PlugableConsole, который добавляет в проект внутреигровую консоль отладки.

[![https://gyazo.com/1e79f2d6bf54c3762f35eab153cb0bfe](https://i.gyazo.com/1e79f2d6bf54c3762f35eab153cb0bfe.png)](https://gyazo.com/1e79f2d6bf54c3762f35eab153cb0bfe)

## <a id="Scenes Setup"></a>Создание сцены

Добавляйте новые сцены в игру с помощью File->New Scene command. Вам сообщат, что сцена будет сгенерирована отлично от нормальной сцены в unity3d. Сцена не будет иметь камеры и освещения. Все потому что вы добавляете их аддитивно из других сцен. ( по умолчанию из sceneKernel )

### Обзор сцены 
Все сцены содержат важные объекты, которые вам не нужно изменять.
* [Setup]: это корневой объект, для starter скриптов и любых обектов, связанных с настройками.
* [SCENE]: Это корневой объект для всех относящихся к игре объектов на сцене. Помещайте ваши уровни сюда.
* [SCENE]/Dynamic: это объект, содержащий в себе все игровый объекты, создаваемые в runtime режиме. Важно разделять создаваемые объекты от статических для облегчения процесса отладки.

### Starters
Starter это компонент monobehavior, который вы подключаете к объекту [Setup]. Starter управляет загрузкой и установкой сцены. Вы можете унаследоваться от компонента Starter что бы расширить его и добавить в него собственную логику. Например "startLevel1"

Переменные в starter:
* Factories: под factory, я подразумеваю ScriptableОbject, который используется для создания сложных объектов. (Например factory player - создает объект игрока + создает и устанавливает UI игрока: HP, атаки и т.д.)
* Scenes to keep: сюда добавьте названия сцен, которые вы хотите сохранить после закрытия сцены. Обычно вам нужно всегда хотеть сохранить sceneKernel.
* Scenes depend on: сцены, которые вы хотите добавить при старте этой сцены. Обычно вам всегда нужно добавлять sceneKernel.


[![https://gyazo.com/1285f0b0feb8ecb0495ca536aae25606](https://i.gyazo.com/1285f0b0feb8ecb0495ca536aae25606.png)](https://gyazo.com/1285f0b0feb8ecb0495ca536aae25606)


## <a id="Actors overview"></a>Обзор акторов
С этого момента мы готовы создавать новые gameobject'ы. 

### Monocached
Вместо использования Monobehavior'ов рекомендуется использовать классы Monocached.
Вы можете настроить время уничтожения и типы пулов для вашего объекта. Если пул назначен объект будет деактивирован и кэширован. Если пул не назначен, то объект будет уничтожен. Объединение в пулы это отличная концепция для объектов, которые постоянно создаются. Например для пуль.

### Акторы (Actors)
Базовый класс для всех ваших акторов в игре. Наследуется от Monocached. Это контейнер для ваших компонентов данных и поведения (data&behaviors). Когда вам нужно добавить новую игровую сущность наследуйте ее от класса Actor. Например: ActorPlayer : Actor. 
Акторы это единственные компоненты влияющие на игровую логику объектов.

#### Пример настойки актора

```csharp
// Наследуйтесь от Аctor. Так же наследуйтесь от интерфейса ITick чтобы обозначить этот объект обновляемым.
  public class ActorPlayer : Actor, ITick
{
    // добавьте сериализуемые классы данных к ActorPlayer для того чтобы видеть их в инспекторе
    // Используйте [FoldoutGroup("Setup")] что бы добавить классные вкладки для переменных в инспекторе
	[FoldoutGroup("Setup")] public DataMove dataMove;
	
        // Используйте protected override void Setup для инициализации актора.
        // Setup используется для добавления компонентов данных в контейнер актора и создания скриптов поведения для него.
    	protected override void Setup()
		{
            // используйте Add<T>() для создания нового объекта и добавления его в контейнер актора. Например компоненты данных ( data ).
			Add(dataMove);
            // используйте Add<T>() для создания нового объекта и добавления его в контейнер актора. Например поведения ( behavior ).
			Add<BehaviorInput>();
		}
 
}
```
[![https://gyazo.com/f3960af1f36566e3d114d97af9e3f0b6](https://i.gyazo.com/f3960af1f36566e3d114d97af9e3f0b6.png)](https://gyazo.com/f3960af1f36566e3d114d97af9e3f0b6)

Вам не нужно писать никакой логики внутри классов актора. Вместо этого используйте классы поведения (behavior). Обычно класс вашего актора должен быть похож на этот:
```csharp
	public class ActorHero : Actor, ITickFixed, ITick, ITickLate
	{
		[FoldoutGroup("Setup"), SerializeField]
		private DataBlueprint dataBlueprint;
		[FoldoutGroup("Setup"), HideInInspector, SerializeField]
		private DataAnimationState dataAnimationState;
		[FoldoutGroup("Setup"), SerializeField]
		private DataInput dataInput;
		[FoldoutGroup("Setup"), SerializeField]
		private DataHealth dataHealth;
		[FoldoutGroup("Setup"), SerializeField]
		private DataDepthRender dataDepthRender;



		protected override void Setup()
		{
			Add(dataBlueprint);
			Add(dataAnimationState);
			Add(dataDepthRender);
			Add(dataHealth);
			Add(dataInput);
		
			Add<DecorateDamageReturn>();
			Add<DecorateBloodFloor>();
			Add<DecorateDamageBlink>();
			Add<DecorateBloodSplats>();

			Add<BehaviorTurn>();
			Add<BehaviorMove>();
			Add<BehaviorRoll>();
			
			Add<BehaviorPlayerInput>();
			Add<BehaviorDamageble>();

		}
	}
```

### Метод Get
Когда вы работете с акторами/поведением используйте Get<T> вместо GetComponent<T>. Метод Get<T> попытается найти компонент внутри актора.
Пример:
```csharp
Get<DataMovement>().facing
```
Вы можете получать компоненты unity так же легко, просто добавив путь к дочернему transform
```csharp
labelScore = Get<TextMeshProUGUI>("anchor_left/label_score");
```
	 

## <a id="Data component"></a>Компонент данных
Компоненты данных это обычные, сериализуемые c# классы, наследованные от интерфейса IData. Все ваши игровые переменные хранятся в компонентах данных.
Одни и те же компоненты данных могут совместно использоваться различными поведениям.


### Пример компонента данных

```csharp
// Помещайте [System.Serializable] ко всем компонентам данных и проверяйте на наследование от IData
	[System.Serializable]
    // Inhe
	public class DataMove : IData
	{
		public float x;
		public float y;

		public void Dispose()
		{
		}
	}
```

#### Интерфейс ISetup
Иногда необходима настройка компонента данных после запуска приложения. Наследуйте компонент данных от интерфейса ISetup, чтобы предоставить дополнительную настройку. Когда они будут добавлены к актору он проверит все компоненты на наличие интерфейса ISetup и запустит их.
```csharp

	[System.Serializable]
	public class DataMove : IData, ISetup
	{
		public float x;
		public float y;

		public void Dispose()
		{
		}

		public void Setup(Actor actor)
		{
			x = actor.selfTransform.position.x;
		}
	}
 ```
 
## <a id="Behavior component"></a>Компонент поведения (Behavior)
Поведения это обычные классы c#, живущие только внутри акторов, которым нужны компоненты данных для работы. Компоненты поведения это рабочие лошадки акторов, ведь именно они определяют как акторы будет себя вести на сцене.

### Пример компонента поведения

```csharp

// Наследуйтесь от ITick чтобы пометить это поведение обновляемым
		public class BehaviorInput : Behavior, ITick
	{
        // Используйте атрибут [Bind] для ленивой инициализации из актора
		[Bind] private DataMove dataMove;

        // Аналог стандартного Update , добавляем переменные dataMove.
		public override void OnTick()
		{
			dataMove.x = Input.GetAxis("Horizontal");
			dataMove.y = Input.GetAxis("Vertical");
		}
	}
 ```

## <a id="Signals"></a>Сигналы
Сигналы это система подписки/получения сообщений, которая эффективно заменяет SendMessage Unity3d.
Существует 2 уровня диспетчера сигналов : локальный реализован внутри класса Actor. Глобальный можно использовать из ProcessingSignals.Default.

Как использовать сигналы:

1. Создайте новую структуру. Я предпочитаю называть их Signal*YourName*. Структура содержит все аргументы, которые вы хотите передать.
```csharp
public struct SignalCameraShake 
{
	public int strength;
}
```
2. Добавьте IReceive<T> к объекту, который будет принимать ваш сигнал. T это тип вашего сигнала.
Метод HandleSignal(T arg) будет добавлен в ваш скрипт. Это входная точка для вашего сигнала.
 
```csharp
  public class ProcessingShakeCamera : IDisposable, IMustBeWipedOut, IReceive<SignalCameraShake> 
  {
	public void HandleSignal(SignalCameraShake arg)
		{
			if (arg.strength == 0)
				tweenShakeAverage.Restart();
			else if (arg.strength == 1)
				tweenShakeStrong.Restart();
			else if (arg.strength == 2)
				tweenShakeVeryStrong.Restart();
		}
  }
```

3. Добавьте подписку к вашему диспетчеру сигналов.
```csharp
  public class ProcessingShakeCamera : IDisposable, IMustBeWipedOut, IReceive<SignalCameraShake> 
  {
	
	public ProcessingShakeCamera()
		{
		    // подписка этого объекта на глобальный диспетчер сигналов.
			ProcessingSignals.Default.Add(this);
	        }
		
	public void HandleSignal(SignalCameraShake arg)
		{
			if (arg.strength == 0)
				tweenShakeAverage.Restart();
			else if (arg.strength == 1)
				tweenShakeStrong.Restart();
			else if (arg.strength == 2)
				tweenShakeVeryStrong.Restart();
		}
  }
```
 4. Добавьте функционал отписки
```csharp
  public class ProcessingShakeCamera : IDisposable, IMustBeWipedOut, IReceive<SignalCameraShake> 
  {
	
	public ProcessingShakeCamera()
		{
		    // подписка этого объекта на глобальный диспетчер сигналов.
			ProcessingSignals.Default.Add(this);
	        }
		
	public void HandleSignal(SignalCameraShake arg)
		{
			if (arg.strength == 0)
				tweenShakeAverage.Restart();
			else if (arg.strength == 1)
				tweenShakeStrong.Restart();
			else if (arg.strength == 2)
				tweenShakeVeryStrong.Restart();
		}
		
		// Нам не нужно чтобы объект принимал сигоналы когда он уничтожен.
			public void Dispose()
		{
		        // Отписка
			ProcessingSignals.Default.Remove(this);
		}
		
  }
 ``` 
  Обратите внимание, что вам не нужно реализовывать логику подписки/отписки, которая наследуется от класса behavior или actor.
  Просто добавьте интерфейс IReceive :
  ```csharp
  	public class DecorateDamageBlink : Behavior, IReceive<SignalDamage>
	{
	 
		public void HandleSignal(SignalDamage val)
		{
			Blink();
		}
	
	}
  
 ``` 


## <a id="Interfaces overivew"></a>**Обзор интерфейсов**
Фреймворк содержит в себе несколько интерфейсов для расширения функциональности сущностей.

### ITick
Фреймворк использует одно обновление monobehaviour для *ВСЕХ* сущностей. Поэтому мы не используем никаких методов обновления в акторах/поведениях. 
Вместо этого мы помечаем акторов и поведения интерфейсами для определения типа обновления. Используйте Tick, если у вас есть код, который должен выполняться каждый кадр.

```csharp
public class BehaviorExample : Behavior, ITick{
    public override void OnTick() { }
}
```
### ITickFixed
Используйте его, когда у вас есть код, который должен работать через определенное количество кадров.

```csharp
public class BehaviorExample : Behavior, ITickFixed{
    public override void OnTickFixed() { }
}
```
### ITickLate
Используйте его, когда у вас есть код, который должен работать после всех других обновлений.

```csharp
public class BehaviorExample : Behavior, ITickLate{
    public override void OnTickLate() { }
}
``` 

 ### IData
Используйте его, когда вы хотите отметить класс как контейнер данных. Помните, что вам нужно использовать атрибут [System.Serializable] для контейнеров данных.

```csharp
[System.Serializable]
public class DataExample : IData{
    public override void Dispose() { }
}
``` 

 ### ISetup
Иногда необходима настройка компонента данных после запуска приложения. Наследуйте компонент данных от интерфейса ISetup, чтобы предоставить дополнительную настройку. Когда они будут добавлены к актору он проверит все компоненты на наличие интерфейса ISetup и запустит их.
```csharp
[System.Serializable]    
public class DataRender: ISetup, IData
{
	public MaterialPropertyBlock matPropBlock;
	public int ID = 0;
 
	public void Setup(Actor actor)
	{
			var rend = actor.Get<SpriteRenderer>("view");
			matPropBlock = new MaterialPropertyBlock();
			rend.GetPropertyBlock(matPropBlock);
	}

	public void Dispose()
	{
		source = null;
	}
}
```

### IMustBeWipedOut
Интерфейс IMustBeWipedOut отмечает обработчики, которые должны быть удалены из Тулбокса при изменении сцены.
```csharp
  public class ProcessingShakeCamera : IDisposable, IMustBeWipedOut 
  {
  }
```

### IReceive<T>
Интерфейс IReceive<T> используется, когда вы хотите, чтобы объект получал сигнал с типом T от локального диспетчера сигналов. IReceive<T> обычно используется внутри акторов для местной связи.
```csharp
  public class ProcessingShakeCamera : IDisposable, IMustBeWipedOut, IReceive<SignalCameraShake> 
  {
	public void HandleSignal(SignalCameraShake arg)
		{
			if (arg.strength == 0)
				tweenShakeAverage.Restart();
			else if (arg.strength == 1)
				tweenShakeStrong.Restart();
			else if (arg.strength == 2)
				tweenShakeVeryStrong.Restart();
		}
  }
```

### IReceiveGlobal<T>
Интерфейс IReceiveGlobal<T> используется, когда вы хотите, чтобы объект получал сигнал с типом T от глобального диспетчера сигналов.
```csharp
  public class ProcessingShakeCamera : IDisposable, IMustBeWipedOut, IReceiveGlobal<SignalCameraShake> 
  {
	public void HandleSignal(SignalCameraShake arg)
		{
			if (arg.strength == 0)
				tweenShakeAverage.Restart();
			else if (arg.strength == 1)
				tweenShakeStrong.Restart();
			else if (arg.strength == 2)
				tweenShakeVeryStrong.Restart();
		}
  }
```
## <a id="Toolbox"></a>Toolbox
Toolbox это синглтон, который содержит все обработчики, глобальные данные и все, что вы хотите получить от глобального доступа.
Думайте о тулбоксе как о " глобальном акторе."

Чтобы добавить новый экземпляр класса в тулбокса, используйте метод Add
Пример:

```csharp
Toolbox.Add<ProcessingInputConnect>();
```

Чтобы получить что-то из тулбокса, используйте метод Get
Пример:

```csharp
data = Toolbox.Get<DataGameSession>();
```

## <a id="Processings"></a>Обработчики
Обработчики более известны как "менеджеры", "контроллеры". Обработчики - это классы, которые могут использоваться как системы в ECS или выполнять некоторую глобальную работу. Например скрипт следования камеры является хорошим кандидатом для обработчика.

Существует несколько готовых обработчиков во фреймворке. Вы можете найти их в StarterKernel. Лучшее место для добавления пользовательских обработчиков это Starter скрипты или pluggables.

Обработчики должны жить только внутри тулбокса.

### ProcessingBase
Как правило, обработчики должны быть унаследованы от ProcessingBase, но можно использовать их без него.
ProcessingBase необходим для использования скрипта в качестве ECS системы. Кроме того, он автоматизирует процедуру подписки/отписки на сигналы.

```csharp
public class ProcessingGroupEnemies : ProcessingBase
```

### IMustBeWipedOut
Интерфейс IMustBeWipedOut говорит тулбоксу, что этот обработчик должен быть уничтожен при изменении сцены. Обычно он используется со всеми "локальными" сценариями обработки, связанными только с одной сценой. Иногда лучше уничтожить объект и воссоздать его на новой сцене.

```csharp
public class ProcessingGroupEnemies : ProcessingBase, IMustBeWipedOut
```
### IDisposable
Используйте интерфейс IDisposable, если вы хотите очистить объект обработки перед его уничтожением.
```csharp
public class ProcessingShakeCamera : IDisposable, IMustBeWipedOut
{

	    private Tween twShakeFromShootCamera;
		private Tween twShakeAverage;
		private Tween twShakeStrong;
		private Tween twShakeVeryStrong;


		public ProcessingShakeCamera()
		{
			ProcessingSignals.Default.Add(this);
                }

	        public void Dispose()
		{
			ProcessingSignals.Default.Remove(this);
			twShakeFromShootCamera.Kill();
			twShakeAverage.Kill();
			twShakeStrong.Kill();
		}
}
``` 
Не используйте IDisposabl при наследовании от ProcessingBase. Он уже включен в него и вы получаете виртуальный метод
OnDispose для очистки.


### Обновление Обработчиков
Не забудьте использовать интерфейсы ITick, ITickFixed, и ITickLate с обработчиками, которые вы хотите обновлять каждый кадр.
Использовать ProcessingUpdate.Default.Add, чтобы зарегистрировать этот объект как Tickable.
```csharp
ProcessingUpdate.Default.Add(this);
``` 

```csharp
// Не забывайте помечать тип обновлений. Здесь мы используем ITickLate
public class ProcessingCameraFollow : ProcessingBase, ITickLate, IMustBeWipedOut{
	public ProcessingCameraFollow()
		{
			transformCamera = Camera.main.transform;
			// используйте ProcessingUpdate.Default.Add для регистрации объекта как Tickable. 
			// В нашем примере он будет добавлен как TickLate
			ProcessingUpdate.Default.Add(this);
		}
}
```

## Обработчики фреймворка
Фреймворк не может работать без некоторых подготовленных обработчиков и вы должны о них знать.

### ProcessingUpdate
Важный обработчик, который контролирует *ВСЕ* обновления в игре. Когда ProcessingUpdate создается он добавляет ComponentUpdate monobehavior внутрть корневого объекта [KERNEL] для получения методов обновления Unity. Все акторы, таймеры, обработчики должны работать от ProcessingUpdate.

Тогда как обновления Monobehavior могут быть использованы только в наследующих его компонентах, вы можете использовать ProcessingUpdate с *ЛЮБЫМ* скриптом.
Вы можете сделать это в 2 шага:
1. Унаследуйтесь от нужных вам интерфейсов.
* ITick для Update
* ITickFixed для FixedUpdate
* ITickLate для LateUpdate
2. Вызовите *ProcessingUpdate.Default.Add(this);* в любом месте внутри скрипта, чтобы проинициализировать его.
3. Обычно все обновления уничтожаются при смене сцены, но если вам нужно сделать это раньше вызовите *ProcessingUpdate.Default.Remove(this);*


```csharp
public class MyCustomClass : ITick{

 public MyCustomClass(){
   ProcessingUpdate.Default.Add(this);
 }
 
 public void Tick(){
			 
 }

}
```

### <a id="ProcessingSceneLoad"></a>Как сменить сцену
Для начала добавьте все нужные сцены в окне Build Settings.
Затем сгенерируйте имена сцен:

[![https://gyazo.com/8507135cf74cf0dd1c4b9db90363a6ad](https://i.gyazo.com/8507135cf74cf0dd1c4b9db90363a6ad.gif)](https://gyazo.com/8507135cf74cf0dd1c4b9db90363a6ad)

Теперь сменяйте сцены используя ProcessingSceneLoad.To(int level).


```csharp
// пример уровная с ID 2
int level = 2;
ProcessingSceneLoad.To(level)
```


## <a id="Object pooling"></a>Пул объектов
Каждый раз при создании/удалении объекта для этого выделяется память. Чем сложнее объект тем больше памяти выделяется для него. Это не так сложно созда объект один или несколько раз, но когда вам нужно создавать сотни объектов или вам нужно создавать их быстро вам нужно будет использовать пул объектов. Больше информации об этом вы можете найти на [сайте Unity3d](https://unity3d.com/learn/tutorials/topics/scripting/object-pooling).

Во фреймворке существует два типа пулов :
* Для GameObject - любые относящиеся к игре объекты с классом monobehavior.
* Для объектов c# - любые простые классы c#. Например таймеры.

### Пул GameObject

Управляемый пул gameobject'ов создается с помощью скриптов ProcessingGoPool и PoolStash.
Пулы подготовлены заранее и включают в себя объекты monocached. 
Всего их существует 4 типа:

* Pool.UI - для любых относящихся к UI сущностей
* Pool.Projectiles - для любых спецэффектов и таких мелких объектов как пули.
* Pool.Entities - для gameobject'ов и акторов
* Pool.Audio - для звуковых объектов

Так же, если вам нужно, вы можете добавить новые типы пулов с помощью ProcessingGoPool.

#### Как добавить объект в пул

Шаг первый.
Выберите вашего актора или monocached объект в инспекторе. Откройте вкладку Mono. Установите задержку перед уничтожением объекта.

[![https://gyazo.com/1fc7c2a2e77a9aac8544a66712c11f01](https://i.gyazo.com/1fc7c2a2e77a9aac8544a66712c11f01.gif)](https://gyazo.com/1fc7c2a2e77a9aac8544a66712c11f01)

Все. Теперь при попытке уничтожения объекта он будет деактивировать и отправлен в выбранный пул.
На сцене вы можете заметить объект [POOLS]. Этот объект содержит все деактивированые сущности.

[![https://gyazo.com/246ca65b49467779f106e4482be4b4e1](https://i.gyazo.com/246ca65b49467779f106e4482be4b4e1.gif)](https://gyazo.com/246ca65b49467779f106e4482be4b4e1)

Шаг второй. ( Опционально )
В случае если вам нужно добавить какую-то определенную логику при появлении/уничтожении объекта наследуйтесь от интерфейса IPoolable.
Это нужно когда вы хотите сбросить состояние объектов. Например вам не нужно что бы ваш враг появлялся с нулевым HP.

```csharp
public class ActorEnemy : Actor, ITick, IPoolable
```

Затем добавьте override методы в поведения (behaviour), которые используются с этим актором:

```csharp
protected override void OnSpawn(){
}
```
```csharp
protected override void OnDespawn(){
}
```

Когда вы используете override из класса Actor не забудьте добавить base.OnSpawn()/OnDespawn()
Вам нужно cделать это т.к. базовый класс Actor зациклен через поведения и передает им методы OnSpawn()/OnDespawn().
```csharp
protected override void OnSpawn(){
base.OnSpawn();
}
```
```csharp
protected override void OnDespawn(){
base.OnDespawn();
}
```
Таким образом, если вы тщательно планируете и проектируете, вы можете использвать пулы даже для очень сложных объектов.
### Компонент PoolRegister

Если вы добавили объекты в режиме редактирования то объекты не смогут попасть в пулы просто так, их нужно будет зарегистрировать для дальнейшего использования с пулом. Для этого используйте компонент PoolRegister.
Обычно я прикрепляю его к объекту [Setup]. Он определяет узлы пула: задает тип пула, префаб объекта из проекта ( не со сцены ) и список всех готовых клонов на месте сцене. В будущем я планирую это автоматизировать.

[![https://gyazo.com/51f7661dc970da82aa48faac0feffdfc](https://i.gyazo.com/51f7661dc970da82aa48faac0feffdfc.png)](https://gyazo.com/51f7661dc970da82aa48faac0feffdfc)

### Временный пул
Вы можете создать специальный временный пул для работы с ним. Это полезно когда вы хотите лениво активировать/деактивировать специфичные группы сущностей.

```csharp
ProcessingGoPool.AddToTemp(Pool.Entities, gameobject);
```

```csharp
ProcessingGoPool.ReleaseTemp(Pool.Entities);
```

## <a id="Creating and destroying new objects"></a>Создание и уничтожение новых объектов

### Создание routine
Чтобы использовать все возможности системы пулов и быть уверенным что объекты появлятся в нужных местах, я написал специальные методы для создания объектов.
В *ЛЮБОМ* скрипте вы можете просто использовать
```csharp
var pool = Pool.Entities;
var obj = this.Populate(pool, prefab);
```
Вы также можете добавить дополнительные параметры:
```csharp
var pool = Pool.UI;
var obj = this.Populate(pool, prefab, Vector3.zero, Quaternion.identity, null, WorldParenters.Level);
```
Вы можете создавать объекты из Resources добавляя string id.

```csharp
var pool = Pool.UI;
var obj = this.Populate(pool, "myObject" , Vector3.zero, Quaternion.identity, null, WorldParenters.UI);
```
Используемые параметры :
Pool - тип пула. Используйте Pool.None если вы не хотите спавнить объект в какой-либо пул.
Prefab или string id - объект, который вы хотите создать. 
Position - позиция объека. По умолчанию Vector3.Zero.
Rotation - поворот объекта. По умолчанию Quaternion.identity.
Parent - родительский объект. Используйте этот параметр если вы хотите установить родительский объект.
WorldParenters - По умолчанию WorldParenters.Level. Создаваемый объект будет помещен внутрь этого компонента, если не был задан родительский объект. 

По умолчанию объект Dynamic внутри [SCENE].
[![https://gyazo.com/4d3346f3fe63bb626af6ab6884271146](https://i.gyazo.com/4d3346f3fe63bb626af6ab6884271146.png)](https://gyazo.com/4d3346f3fe63bb626af6ab6884271146) 

Когда вы создаете объект из string ID начинает работать ProcessingResources. Он смотрит внутрь папки Resources/Prefabs и пытается найти нужный объект. После этого ProcessingResources кэширует его и добавляет в логику создания. В следующий раз он выдваст вам этот объект из кеша вместо того чтобы снова смотреть внуть папки Resources.

[![https://gyazo.com/025bca594dca7fdd3e35465bff05cb10](https://i.gyazo.com/025bca594dca7fdd3e35465bff05cb10.png)](https://gyazo.com/025bca594dca7fdd3e35465bff05cb10)

### Уничтожение routine

Что бы уничтожить актора или объект monocached используйте метод HandleDestroyGO().
```csharp
actor.HandleDestroyGO()
```
Если объект относится к пулу он будет деактивирован для дальнейшего использования. Если же объект не относится к какому-либо пулу он будет уничтожен.
Вы можете отсрочить его уничтожение, добавив DestroyDelay Time в инспекторе.

[![https://gyazo.com/49613234129a49a1a9a923a863225618](https://i.gyazo.com/49613234129a49a1a9a923a863225618.gif)](https://gyazo.com/49613234129a49a1a9a923a863225618)

### OnBeforeDestroy

Используйте метод override OnBeforeDestroy() для добавления логики актору до его уничтожения. Это полезно использовать для добавления разных эффектов. Так же с помощью OnBeforeDestroy можно сбросить данные если объект добавлен в пул.

```csharp
protected override void OnBeforeDestroy()
```	


## Таймеры

Таймеры это отличное решение для отложенных действий. Я очень рекомендую использовать их вместо корутинов ( сопорограммы ) если вам нужно отложить лишь одно действие.

Существует два способа использования таймеров:
* Вы можете создавать новый Таймер каждый раз, когда вам нужно из пула таймеров
* Вы можете кэшировать таймер и использовать его повторно.

Установите время через которое таймер выполнит действие и само действие. Таймеры автоматически удаляются после того как они сработают.

Примеры таймеров:
```csharp
// Создайте новый таймер из пула.
Timer.Add(0.1f, actor.HandleDestroyGO); 
// Создайте и кешируйте таймер. В этом случает таймер ну будет работать до использования метода Restart.
var alarm = new Timer(() => { Debug.Log("Alarm"); }, 10f);
// Включаем таймер.
alarm.Restart();
```

```csharp
 Timer.Add(0.1f, ()=>
    {
      Debug.Log("Killed");
      actor.HandleDestroyGO();
    }); 
```

### Метод AddID

Вы можете добавить ID к таймеру. После этого вы сможете сортировать таймеры и получать список таймеров с одинаковым ID. Для ID можно использовать любой объект.

```csharp
  Timer.Add(0.1f, actor.HandleDestroyGO).AddID(actor);
```

Например, вы можете найти все таймеры замороженных акторов и изменить timeScale.
```csharp
var timers = Timer.FindAllTimers(actor);
	 
	if (timers != null)
	 for (var i = 0; i < timers.Count; i++)
	    {
		timers[i].timeScale = 0.5f;
	    }
```
### Метод Restart

Вы можете кешировать таймер для дальнейшего использования.
```csharp
 private Timer timerBlink;
 timerBlink = new Timer(BlinkFinish, 0.15f);
 
 void Blink(){
 timerBlink.Restart();
 }
```
Вы можете изменить время или даже действие во время перезапуска

```csharp
 private Timer timerBlink;
 timerBlink = new Timer(BlinkFinish, 0.15f);
 
 void Blink(){
 timerBlink.Restart(10f);
 timerBlink.Restart(10f, AnotherAction );
 }
 void AnotherAction(){
 }
```

### Метод Kill
Если вы хотите уничтожить таймер используйте метод Kill.
```csharp
timerBlink.Kill();
 ```
 Обычно вам нужно делать это внутри метода OnDispose.
 ```csharp
 protected override void OnDispose()
  {
    timerBlink.Kill();
  }
 ```
 Метод OnDispose предоставляется в поведениях по умолчанию.

## <a id="Blueprints"></a>Схемы (Blueprint)
Схемы это ScriptableObject, который используется для определения схожих данных для акторов. 
Их Настройка аналогична настройке акторов.

### Как создать схему
Шаг 1.
Создайте новый скрипт, наследованный от Вlueprint. 
Шаг 2.
Добавтье тег [CreateAssetMenu] с параметрами fileName и menuName.
Шаг 3.
Определите нужные вам компоненты данных и добавьте их с помощью метода установки в контейнер схемы.


 ```csharp
	[CreateAssetMenu(fileName = "BlueprintCreature", menuName = "Blueprints/BlueprintCreature")]
	public class BlueprintCreature : Blueprint
	{
		[FoldoutGroup("Setup")]
		public DataCreature dataCreature;
		
		[FoldoutGroup("Setup")]
		public DataDeathAnimations dataDeathAnimations;


		public override void Setup()
		{
			Add(dataCreature);
			Add(dataDeathAnimations);
		}
	}
 ```
Шаг 4. Создайте новый объект со схемой в проекте.

[![https://gyazo.com/13c79e46e32bd94b19b1db89dac43306](https://i.gyazo.com/13c79e46e32bd94b19b1db89dac43306.gif)](https://gyazo.com/13c79e46e32bd94b19b1db89dac43306)

Шаг 5. Создайте шаблон данных схем для всех ваших акторов ( нужно сделать это всего один раз ) и добавьте этот компонент ко всем нужным акторам.

```csharp
	[Serializable]
	public class DataBlueprint : IData
	{
		public Blueprint blueprint;
 
		public void Dispose()
		{
 
			blueprint = null;
		}

		public T Get<T>() where T : class
		{
			return blueprint.Get<T>();
		}
	  
	}
  ```
Шаг 6. Назначьте вашему актору нужную схему через инспектор.
  
  [![https://gyazo.com/c6e52a666f9d2b0a6a3c005bcef9d18d](https://i.gyazo.com/c6e52a666f9d2b0a6a3c005bcef9d18d.gif)](https://gyazo.com/c6e52a666f9d2b0a6a3c005bcef9d18d)
  
Шаг 7. Найдите Blueprints внутри папки Resources изагрузите туда вашу новую схему.
Вы можете автоматизировать этот процесс нажав на "populate blueprints" на панели инструментов. В этом случае все ваши схемы будут лежать в папке Assets/[2]Content/Blueprints.

[![https://gyazo.com/7472fbc529e2e2b9f58b8f35b09a7c18](https://i.gyazo.com/7472fbc529e2e2b9f58b8f35b09a7c18.gif)](https://gyazo.com/7472fbc529e2e2b9f58b8f35b09a7c18)

[![https://gyazo.com/35b1b3c0426abe14278afe0fa107c2b8](https://i.gyazo.com/35b1b3c0426abe14278afe0fa107c2b8.gif)](https://gyazo.com/35b1b3c0426abe14278afe0fa107c2b8)

### Как использовать схемы в коде?
Это легко и просто : используйте метод Get внутри ваших поведений.

```csharp
// Get<DataBlueprint>() возвращает схему.
// Get<DataWeapon> возвращает нужные данные из схемы.
var weaponData = Get<DataBlueprint>().Get<DataWeapon>();
```
  
### Когда нужно использовать схемы ? 
Все переменные, добавляемые вами к gameobject'ам чего-то стоят. Например, создание 1 000 000 объектов с одной целочисленной переменной займет около 4МВ памяти. Схема создается всего 1 раз, после чего её могут использовать все копии ваших акторов. Например вам надо добавить звук для вашего монстра. Вы можете использовать схему монстра и задать звук в ней. В таком случает будет не важно сколько копий монстра вы поместите на сцену, ведь их звуки будут находиться в схеме, а не в каждом из них. 
 
## <a id="Tags"></a>Теги
Теги это связующее звено для вашей игры: Вы можете отличать нужных вам акторов или использовать их как аргументы для ваших сигналов. Теги это простые целочисленные (INT) константы.

### Как добавлять
Шаг 1. 
Создайте новый static скрипт, названный Tag ( или так как вам надо ). 
Я предпочитаю использовать partial классы для разделения моих тегов по разным файлам.
Назначьте вашим тегам уникальные ID. 
```csharp
public static partial class Tag
	{
		 public const int SignalStasisOn = 10001;
		 public const int SignalStasisOff = 10002;
        }
```	

```csharp
public static partial class Tag
	{
		 public const int WeaponGun = 9000;
		 public const int WeaponLaser = 9001;
        }
```	

[![https://gyazo.com/0eb286e0d8b2712b9b3aee03eaaec9c9](https://i.gyazo.com/0eb286e0d8b2712b9b3aee03eaaec9c9.png)](https://gyazo.com/0eb286e0d8b2712b9b3aee03eaaec9c9)

Шаг 2.
Добавьте [TagField(categoryName = "ВАШЕИМЯ")] до тега. Используйте '/' для добавления тегов в отдельные группы.
```csharp
	public static partial class Tag
	{
		[TagField(categoryName = "Weapons")] public const int WeaponGun = 9000;
		[TagField(categoryName = "Weapons/BigGuns")] public const int WeaponLaser = 9001;
	}
```
Шаг 3.
Добавьте тег к вашему актору. Для этого используйте tags.Add(ВАШ_ТЕГ);
```csharp
public class ActorPlayer : Actor{
	protected override void Setup()
		{
			Add(dataAnimationState);
			Add(dataCurrentWeapon);
			// всегда добавляйте теги в конце настроек актора.
			tags.Add(Tag.GroupPlayer);
		}
}
```
Шаг 4.
Вы можете редактировать ваши теги из инспектора. Для этого добавьте int переменную там, где вам надо и прикрепите атрибут
[TagFilter(typeof(ТИП_КЛАСА_С_ТЕГАМИ))]

```csharp
public class ActorPlayer : Actor{
[TagFilter(typeof(Tag))] public int tag;
	protected override void Setup()
		{
			Add(dataAnimationState);
			Add(dataCurrentWeapon);
			// всегда добавляйте теги в конце настроек актора.
			tags.Add(tag);
		}
}
```
[![https://gyazo.com/e3c0c4d009209b46df72975305a6e936](https://i.gyazo.com/e3c0c4d009209b46df72975305a6e936.gif)](https://gyazo.com/e3c0c4d009209b46df72975305a6e936) 
 
 ### ProcessingTags
 Акторы содержат специальный компонент processingTags. 
 
 ```csharp
 // Добавление одного тега.
 tags.Add(tag);
```
 ```csharp
 // Добавление нескольких тегов.
 tags.Add(tag, tag2, tag3);
```
 ```csharp
  // Удаление одного тегда.
 tags.Remove(tag);
```
 ```csharp
   // Удаление всех похожих тегов.
 tags.RemovAll(tag);
```
```csharp
   // должен быть указанный тег.
 bool valid = tags.Contain(tag);
```
 ```csharp
   // должен быть как минимум один тег.
 bool valid = tags.ContainAny(tag,tag2);
```
 ```csharp
   // должны быть все теги.
 bool valid = tags.ContainAll(tag,tag2);
```

### Как использовать
Вы можете добавлять одни и те же теги актору. Это полезно в случае, когда у вас есть несколько действий с одинаковой логикой, и вы хотите проверить что-то. 

 ```csharp
 // Добавление тега stun от могучего молота судьбы.
 tags.Add(Tag.Stunned);
 // Добавление тег stun от упавшего дерева.
 tags.Add(Tag.Stunned);
// Удаление тега, вызванного могучим молотом судьбы. 
 tags.Remove(Tag.Stunned);
 bool condition_stunned = tags.Contain(Tag.Stunned);  
```
В примере выше condition_stunned будет истинным, т.к. нужный тег был дважды добавлен, но удален только один раз.

## <a id="ECS"></a>ECS
Простой ECS паттерн для работы с акторами. В данный момент мой подход может быть использован только с классами акторов и он далеко не так хорош как чистый ECS подход и он использует больше структурирования для увеличения производительности.

### Обработчики ( aka системы )
Обработчиками я называю все системы или глобальные "контролеры".

Когда вам надо активировать ECS наследуйте ваши обработчики от ProcessingBase

```csharp
public class ProcessingCameraFollow : ProcessingBase, ITick, IMustBeWipedOut
```
Для использования ваших обработчиков вам нужно добавить их в тулбокс. Обычно я делаю это в starter скриптах.

```csharp
	public class StarterLv1 : Starter
	{
		[FoldoutGroup("Setup"), SerializeField, HideInInspector]
		private DataLevel dataLevel;

		protected override void Setup()
		{
			Toolbox.Get<DataGameSession>().currentLevel = 1;

			Toolbox.Add<ProcessingGroupPlayers>();
			Toolbox.Add<ProcessingGroupEnemies>();

			Toolbox.Add<ProcessingSortDepth>();
			Toolbox.Add<ProcessingShakeCamera>();
			Toolbox.Add<ProcessingCameraFollow>();

			Toolbox.Add<ProcessingInputConnect>();
			Toolbox.Add<ProcessingMenuHome>();

		}
	}
```
Запомните что если вам надо вы можете наследоваться от класса Starter.

### Обработчики групп
Когда новая сущность актора добавляется в ProcessingEntities скрипт решает в какую группу актеров он должен быть помещен.
Группы это листы с акторами, имеющими общий фильтр.


```csharp
public class ProcessingCameraFollow : ProcessingBase, ITick, IMustBeWipedOut{

private Group groupPlayers;

}
```

### Фильтры
Для заполнения вашей группы вам нужно добавить фильтры. Думайте о фильтре как о замке. Если ваш ключи подходит к замку - актор добавляется в группу. Вы можете фильтровать акторов по типу компонентов данных или по тегам.

#### Фильтр GroupBy
Для заполнения группы добавьте атрибут GroupBy на переменной в которой вы будете хранить эту группу.
Все ваши GrouBy фильтры должны быть действительными для добавления акторов в группы.
```csharp
public class ProcessingCameraFollow : ProcessingBase, ITick, IMustBeWipedOut{
[GroupBy(typeof(DataPlayer))]
private Group groupPlayers;
}
```
Вы можете использовать несколько фильтров :

```csharp
public class ProcessingCameraFollow : ProcessingBase, ITick, IMustBeWipedOut{
[GroupBy(typeof(DataPlayer), typeof(DataKnight) )]
private Group groupPlayersKnights;
}
```

##### Использование тегов вместо типов
Вам не обязательно использовать типы компонентов данных для фильтрации. Вместо них вы можете использовать теги.
Тег это простая целочисленная (int) константа. Он очень поход на теги для GameObject'ов из Unity3D, но он более мощный.
```csharp
// создайте static класс Tag и добавьте все ваши константы сюда.
	public static partial class Tag
	{
		[TagField(categoryName = "Groups")] public const int GroupPlayer = 2001;
		[TagField(categoryName = "Groups")] public const int GroupEnemy = 2002;
		[TagField(categoryName = "Groups")] public const int GroupPlayerSpawner = 2003;
		[TagField(categoryName = "Groups")] public const int GroupDragable = 2004;
		[TagField(categoryName = "Groups")] public const int GroupPlayerUI = 2005;
		[TagField(categoryName = "Groups")] public const int GroupBorders = 2006;
		[TagField(categoryName = "Groups")] public const int GroupCameraStartPosition = 2007;
		[TagField(categoryName = "Groups")] public const int GroupCounterAttacked = 2008;
	}
```

```csharp
public class ProcessingCameraFollow : ProcessingBase, ITick, IMustBeWipedOut{
[GroupBy(Tag.GroupPlayer)]
private Group groupPlayers;
}
```
```csharp
public class ActorPlayer : Actor{
	protected override void Setup()
		{
			Add(dataAnimationState);
			Add(dataCurrentWeapon);
			// обычно теги добавляются в конце настройки вашего актора.
			tags.Add(Tag.GroupPlayer);
		}
}
```
#### Фильтр GroupExclude

Вы можете конкретизировать, добавив фильтр GroupExclude. Если какой-то актор из группы будет содержать указанный тег то он будет из нее исключен.

```csharp
public class ProcessingCameraFollow : ProcessingBase, ITick, IMustBeWipedOut{
[GroupBy(Tag.GroupPlayer)]
[GroupExclude(Tag.StateDead)]
private Group groupPlayersAlive;
}
```


### Событие OnGroupChanged
Вы можете добавить дополнительную логику при смене группы( когда актор добавляется в группу или удаляется из грпуппы )

 ```csharp
public class ProcessingCameraFollow : ProcessingBase, ITick, IMustBeWipedOut{
[GroupBy(Tag.GroupPlayer)]
private Group groupPlayers;

	public ProcessingCameraFollow()
	{
	   groupPlayers.OnGroupChanged += OnGroupPlayersChanged;
	}

	void OnGroupPlayersChanged()
		{	 
			 for(var i=0;i<groupPlayers.length;i++){
			    Debug.Log("Actor: " + groupPlayers.actors[i]);
			 } 
		}
}
```

### Обновление обработчиков
Для добавления обновлений в ваши обработчики наследуйте их от интерфейсов ITick, ITIckFixed, ITickLate.
Ипользуйте group.length для получения длины контейнера. Используйте group.actors[i] для получения одного из акторов группы.

 ```csharp
public class ProcessingCameraFollow : ProcessingBase, ITick, IMustBeWipedOut{
[GroupBy(Tag.GroupPlayer)]
private Group groupPlayers;

	public ProcessingCameraFollow()
	{
	   groupPlayers.OnGroupChanged += OnGroupPlayersChanged;
	}

	void OnGroupPlayersChanged()
		{	 
			 for(var i=0;i<groupPlayers.length;i++){
			    Debug.Log("Actor: " + groupPlayers.actors[i]);
			 } 
		}
		
	public void Tick()
	{
	      for(var i=0;i<groupPlayers.length;i++){
			    DoSomething(groupPlayers.actors[i]);
	         } 
	 }
	 
	 void DoSomething(Actor a){
	 }
		
}
```