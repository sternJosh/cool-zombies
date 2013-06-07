using UnityEngine;
using System.Collections;

public class Zombie : CharacterClass {

	
	//stuff
	private void zombAI()
	{
		//move towards the characters.
		//eat their brains
	}
	
	public Zombie()
	{
		setHP (20);
		setVP (20);
		setStr (10);
		setDefense (50);
		setCon (10);
		setComp (10);
		setDex (10);
		setPerc (10);
		setInt (10);
		setName ("Default Zombie");
	}
	
	public void startTurn()
	{
		print(this.getName() + "'s turn");
		Time.timeScale = 0;
	}
}
