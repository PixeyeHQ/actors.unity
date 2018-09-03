//   Project : Battlecruiser3.0
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 8/19/2018

using System;
using System.Collections;
using System.Collections.Generic;
using Homebrew;

public abstract class Behavior : IEnumerable, IDisposable
{
    public static Dictionary<int, Behavior> behaviors =
        new Dictionary<int, Behavior>(EngineSettings.MinBehaviors, new FastComparable());

    public int[] actor_ids = new int[12];
    public int length;

    public Behavior()
    {
        ProcessingUpdate.Default.Add(this);
        ProcessingSystemAttributes.Setup(this);
        ProcessingGroupAttributes.Setup(this);
        ProcessingSignals.TryAddToGlobal(this);
    }

    public static Actor GetEntity(int id)
    {
        return Actor.entites[id];
    }

    public static T Get<T>(int id, StorageType type = StorageType.Global) where T : new()
    {
        return Actor.entites[id].Get<T>(type);
    }

    public void AddElement(int id)
    {
        if (actor_ids.Length <= length)
        {
            int len = length == 0 ? EngineSettings.MinComponents : length << 1;
            Array.Resize(ref actor_ids, len);
        }

        OnEnable(Actor.entites[id]);
        actor_ids[length++] = id;
    }
    public void RemoveElement(int id)
    {
        for (int i = 0; i < length; i++)
        {
            if (actor_ids[i] != id) continue;
            OnDisable(Actor.entites[id]);
            length--;
            Array.Copy(actor_ids, i + 1, actor_ids, i, length - i);

            break;
        }
    }

    protected virtual void OnEnable(Actor actor)
    {
    }
    protected virtual void OnDisable(Actor actor)
    {
    }
    protected virtual void OnTick(Actor actor)
    {
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public ActorEnum GetEnumerator()
    {
        return new ActorEnum(actor_ids, length);
    }


    public void Tick()
    {
        foreach (var e in this)
        {
            OnTick(e);
        }
    }


    public void Dispose()
    {
        OnDispose();
    }

    protected virtual void OnDispose()
    {
    }
}


public struct ActorEnum : IEnumerator
{
    public int[] actors;


    private int position;
    private int length;

    public ActorEnum(int[] list, int length)
    {
        actors = list;
        position = -1;
        this.length = length;
    }

    public bool MoveNext()
    {
        position++;
        return position < length;
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current => Current;

    public Actor Current => Actor.entites[actors[position]];
}