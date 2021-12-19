using System;
using System.Diagnostics;
//using Pixeye.Actors.Debugger;

namespace Pixeye.Actors
{
  public unsafe partial struct ent
  {
    [Conditional("ACTORS_DEBUG")]
    internal static void DebugCheckLimits(int len, ent entity)
    {
      if (len == EcsTags.Capacity)
      {
        LayerKernel.Debugger.Log(LogType.TAGS_LIMIT_REACHED, entity, EcsTags.Capacity);
        throw new ArgumentException();
      }
    }
    
    /// for a visual debugger. Doesn't affect the logic of the framework
    // [Conditional("ACTORS_DEBUG")]
    // internal static void SendDataToVisualDebugger(Debugger.TagActions action, int tagID, ent entity)
    // {
    //   TagOperation op;
    //   op.Entity = entity;
    //   op.Action = action;
    //   op.Arg    = tagID;
    //   
    //   var instance = Debugger.ActorsDebugger.Instance;
    //   if(instance != null)
    //     instance.ProcessorDebug?.ExecuteTagDebug(ref op, entity.layer.ID - 1);
    // }
    

    /// Add one tag from the subset.
    public void Set(int tagID)
    {
      var     _meta  = meta;
      ref var buffer = ref _meta->tags;

      int len = buffer.length;
      var tID = (ushort) tagID;
      for (var index = 0; index < len; index++)
      {
        if (buffer.tags[index] == tID)
        {
          unchecked
          {
            buffer.size[index] += 1;
          }

          //SendDataToVisualDebugger(TagActions.Add, tagID, this);
          
          return;
        }
      }

      DebugCheckLimits(len, this);
      
      //SendDataToVisualDebugger(TagActions.Add, tagID, this);

      buffer.SetElement(buffer.length, tagID);

      if (!_meta->isDirty)
      {
        HandleChanges(tagID);
      }
    }

    /// Add one tag from the subset.
    public void Set(params int[] tagsID)
    {
      var     _meta   = meta;
      var     isDirty = _meta->isDirty;
      ref var buffer  = ref _meta->tags;

      int len = buffer.length;

      for (var i = 0; i < tagsID.Length; i++)
      {
        var tID        = (ushort) tagsID[i];
        var allowToAdd = true;
        for (var index = 0; index < len; index++)
        {
          if (buffer.tags[index] == tID)
          {
            unchecked
            {
              buffer.size[index] += 1;
            }
            
            //SendDataToVisualDebugger(TagActions.Add, tID, this);

            allowToAdd = false;
            break;
          }
        }

        if (!allowToAdd) continue;

        DebugCheckLimits(buffer.length, this);
        buffer.SetElement(buffer.length, tID);
        
        //SendDataToVisualDebugger(TagActions.Add, tID, this);

        if (!isDirty)
        {
          HandleChanges(tID);
        }
      }
    }

    /// Remove one tag from the subset.
    public void Remove(int tagID)
    {
      var     _meta  = meta;
      ref var buffer = ref _meta->tags;
      int     len    = buffer.length;

      for (var index = 0; index < len; index++)
      {
        if (buffer.tags[index] == tagID)
        {
          if (--buffer.size[index] == 0)
          {
            buffer.RemoveAt(index);
            HandleChanges(tagID);
          }

          //SendDataToVisualDebugger(TagActions.Remove, tagID, this);
          
          return;
        }
      }
    }

    /// Remove one tag from the subset.
    public void Remove(params int[] tagsID)
    {
      var     _meta  = meta;
      ref var buffer = ref _meta->tags;
      var     len    = buffer.length;

      for (var i = 0; i < tagsID.Length; i++)
      {
        var tID = (ushort) tagsID[i];
        for (var index = 0; index < len; index++)
        {
          if (buffer.tags[index] == tID)
          {
            if (--buffer.size[index] == 0)
            {
              buffer.RemoveAt(index);
              HandleChanges(tID);
            }
            
            //SendDataToVisualDebugger(TagActions.Remove, tID, this);
          }
        }
      }
    }

    /// Remove all tags from the subset.
    public void RemoveAll(int tagID)
    {
      var     _meta  = meta;
      ref var buffer = ref _meta->tags;
      int     len    = buffer.length;
      var     tID    = (ushort) tagID;

      for (var index = 0; index < len; index++)
      {
        if (buffer.tags[index] == tID)
        {
          buffer.size[index] = 0;
          buffer.RemoveAt(index);
          HandleChanges(tID);
          //SendDataToVisualDebugger(TagActions.RemoveAll, tID, this);
          return;
        }
      }
    }

    /// Remove all tags from the subset.
    public void RemoveAll(params int[] tagsID)
    {
      var     _meta  = meta;
      ref var buffer = ref _meta->tags;
      var     len    = buffer.length;

      for (var i = 0; i < tagsID.Length; i++)
      {
        var tID = (ushort) tagsID[i];
        for (var index = 0; index < len; index++)
        {
          if (buffer.tags[index] == tID)
          {
            buffer.size[index] = 0;
            buffer.RemoveAt(index);
            HandleChanges(tID);
            //SendDataToVisualDebugger(TagActions.RemoveAll, tID, this);
            break;
          }
        }
      }
    }

    /// Remove all tags from every subset.
    public void RemoveAllTags()
    {
      ref var buffer = ref meta->tags;
      var     len    = buffer.length;

      for (var i = 0; i < len; i++)
      {
        var tID = buffer.tags[i];
        buffer.size[i] = 0;
        buffer.tags[i] = 0;
        buffer.length--;
        HandleChanges(tID);
      }
      
      //SendDataToVisualDebugger(TagActions.ClearTags, -1, this);
    }

    internal void HandleChanges(int tagID)
    {
      if (meta->isDirty) return;
      var ecs        = managed.layer.processorEcs;
      var indexGroup = ecs.familyTags.TryGetValue(tagID);
      if (indexGroup == -1) return;
      ecs.SetOperation(this, indexGroup, ProcessorEcs.Action.ChangeTag);
    }
  }
}