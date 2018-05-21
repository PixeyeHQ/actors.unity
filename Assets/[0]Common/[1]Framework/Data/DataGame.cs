/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/11/2018  9:08 PM
================================================================*/

using System;
using UnityEngine;
namespace Homebrew{

public abstract class DataGame : ScriptableObject, IDisposable
{
	public virtual void Dispose()
	{
	}
}

}