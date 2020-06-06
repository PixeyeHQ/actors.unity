using System;
using System.Diagnostics;

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

          return;
        }
      }

      DebugCheckLimits(len, this);

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

            allowToAdd = false;
            break;
          }
        }

        if (!allowToAdd) continue;

        DebugCheckLimits(buffer.length, this);
        buffer.SetElement(buffer.length, tID);

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