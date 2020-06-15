using UnityEngine;
 
namespace Pixeye.Actors
{
  public interface IPooledLayer
  {
    void ClearNodes();
    void AddToNode(GameObject prefab, GameObject instance, int pool);
  }
}