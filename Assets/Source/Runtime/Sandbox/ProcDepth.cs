using System.Collections;
using System.Collections.Generic;
using Pixeye;
 
using UnityEngine;

public class ProcDepth : MonoBehaviour
{

	public float ratio = 0.01f;

	[Reorderable("TEST")]
	public List<int> tests;
	 
	void Update()
	{ 
		 var pos = transform.position;
		pos.z = pos.y;
		transform.position = pos;
	}

 
	void Recursion()
	{
		Recu(transform);
	}

 
	void ChageDepths()
	{
		var transforms = gameObject.GetComponentsInChildren<Transform>();
		var depth      = 0.0f;
		for ( int i = 0; i < transform.childCount; i++ )
		{
			transform.GetChild(i);

			var transformCached = transforms[i];
			var pos             = transformCached.position;

			
			pos.z = depth -= ratio;
			transformCached.position = pos;
		}
	}

	void Recu(Transform part)
	{
		Debug.Log(part);
		part.transform.position = new Vector3(0, 0, ratio -= 0.01f);
		for ( int i = 0; i < part.transform.childCount; i++ )
		{
			Recu(part.transform.GetChild(i));
		}
	}

}