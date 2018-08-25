//   Project : Battlecruiser3.0
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 8/19/2018

using System;
using System.Collections;
using System.Collections.Generic;
using Homebrew;


public abstract class Behavior : IEnumerable
{
    public static Dictionary<int, Behavior> behaviors =
        new Dictionary<int, Behavior>(EngineSettings.MinBehaviors, new FastDict());

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


    public void AddElement(int id)
    {
        if (actor_ids.Length <= length)
        {
            var len = length == 0 ? EngineSettings.MinComponents : length << 1;
            Array.Resize(ref actor_ids, len);
        }

        actor_ids[length++] = id;
        OnEnable(Actor.entites[id]);
    }

    public void RemoveElement(int id)
    {
        for (var i = 0; i < length; i++)
        {
            if (actor_ids[i] != id) continue;
            length--;
            Array.Copy(actor_ids, i + 1, actor_ids, i, length - i);
            OnDisable(Actor.entites[id]);
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
    }
}


public struct ActorEnum : IEnumerator
{
    public int[] actors;


    int position;
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

public interface IBehavior : IDisposable
{
}