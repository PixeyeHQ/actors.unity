/*===============================================================
Product:    Shoot off their lumps
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       20/12/2017 10:18
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

		private void OnDestroy()
		{
			mngUpdate = null;
		}
	}
}