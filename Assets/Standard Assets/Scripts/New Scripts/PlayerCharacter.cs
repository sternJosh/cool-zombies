using UnityEngine;
using System.Collections;

public class PlayerCharacter : Human {
	
	
	
	private void displayActionMenu()
	{
		//give the player the option to move, shoot, etc	
	}
	
	//default constructor
	public PlayerCharacter()
	{
		print("Creating default player character");
		setInt (10);
		setComp(10);
		setDex(10);
		setCon(10);
		setPerc(10);
		setStr(10);
		setHP(20);
		setVP(20);
		setLongGun(5);
		setHandGun(5);
		setAcrobatics(5);
		setBows(5);
		setClimb(5);
		setWeight(100);
		setCapacity(150);
		bool[] feats = getFeats ();
		feats = new bool[numFeats];
		setName ("TestPC");
		setDefense (60);
		setMovement(5);
	}
	
	
	
	IEnumerator startTurn()
	{
		print (this.getName () + "'s turn");	
		StartCoroutine("drawMenu");
		print ("is this getting executed?");
		yield return null;
	}
	
	public override IEnumerator drawMenu()
	{
		print ("about to add the action menu");
		Component menu = gameObject.AddComponent ("PCActionMenu");
		print ("added the action menu");
		
		while (true)
		{
			if (Input.GetKeyDown (KeyCode.Escape))
			{
				print("trying to remove action menu");
				Destroy(menu);
				print("removed the action menu");
				yield return null;
				break;
				
			}
			yield return null;
		}
		//Destroy (menu);
		//print ("removed the action menu");
	}
	
	//public override IEnumerator move()
	//{
//		yield return null;
	//}
	
	
		
	
	
	
}
