/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       16/09/2017 02:45
================================================================*/

 
using UnityEngine;

namespace Homebrew{


public abstract class Factory : ScriptableObject, IMustBeWipedOut
{
	public virtual T Spawn<T>(Vector3 pos, Quaternion rot) where T : class
	{
		return default(T);
	}
	
	public virtual Transform Spawn(int id)
	{
		return null;
	}
}
}