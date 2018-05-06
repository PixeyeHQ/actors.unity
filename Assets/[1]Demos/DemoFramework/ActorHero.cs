 
using Homebrew;
using UnityEngine;

public class ActorHero : Actor, ITick
{
	[Header("==Setup==")]  
	[SerializeField]
	private DataHealth dataHealth;
	
	
	protected override void Setup()
	{
		Add(dataHealth);
		Add<BehaviorDeath>();
	}
}
