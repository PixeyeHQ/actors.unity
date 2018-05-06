/*===============================================================
Product:    Unity3dTools
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/6/2018 2:27 PM
================================================================*/


using UnityEngine;

namespace Homebrew
{
	public class ComponentUpdate : MonoBehaviour
	{
		private ProcessingUpdate mngUpdate;

		public void Setup(ProcessingUpdate mngUpdate)
		{
			this.mngUpdate = mngUpdate;
		}

		private void Update()
		{
			mngUpdate.Tick();
		}

		private void FixedUpdate()
		{
			mngUpdate.TickFixed();
		}

		private void LateUpdate()
		{
			mngUpdate.TickLate();
		}
	}
}