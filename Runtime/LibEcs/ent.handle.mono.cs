using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
  public partial struct ent
  {
    //===============================//
    // Get Mono From Entity
    //===============================//

    /// <summary>
    /// Returns the transform linked to the entity.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Returns the transform linked to the entity.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T GetMono<T>()
    {
      return managed.transform.GetComponentInChildren<T>();
    }

    /// <summary>
    /// Returns the transform linked to the entity.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Returns the transform linked to the entity.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T GetMono<T>(int index1) where T : Component
    {
      return managed.transform.GetChild(index1).GetComponent<T>();
    }

    /// <summary>
    /// Returns the transform linked to the entity.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Returns the transform linked to the entity.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T GetMono<T>(int index1, int index2) where T : Component
    {
      return managed.transform.GetChild(index1).GetChild(index2).GetComponent<T>();
    }

    /// <summary>
    /// Returns the transform linked to the entity.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Returns the transform linked to the entity.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T GetMono<T>(string path)
    {
      return managed.transform.Find(path).GetComponent<T>();
    }

    /// <summary>
    /// Returns the transform linked to the entity.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Returns the transform linked to the entity.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T GetMono<T>(params int[] path) where T : Component
    {
      var transform = managed.transform;
      foreach (var sibling in path)
        transform = transform.GetChild(sibling);

      return transform.GetComponent<T>();
    }

    /// <summary>
    /// Returns the transform linked to the entity.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Returns the transform linked to the entity.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Component GetMono(Type t, params int[] path)
    {
      var transform = managed.transform;
      foreach (var sibling in path)
        transform = transform.GetChild(sibling);
      return transform.GetComponent(t);
    }
  }
}