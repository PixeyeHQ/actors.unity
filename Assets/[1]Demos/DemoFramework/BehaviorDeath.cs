using System.Collections;
using System.Collections.Generic;
using Homebrew;
using UnityEngine;

public class BehaviorDeath : BehaviorBase, ITick
{
	private DataHealth dataHealth;

	public override void Setup()
	{
		dataHealth = actor.Get<DataHealth>();
	}


	public override void OnTick()
	{
		Debug.Log("Current HP: " + dataHealth.HP);
		if (dataHealth.HP == 0)
			actor.HandleDestroyGO();
	}

	protected override void OnDispose()
	{
		dataHealth = null;
	}
}