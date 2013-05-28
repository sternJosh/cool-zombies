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
		setFastMove(false);
		setHeadHunter(false);
		setName ("TestPC");
	}
	
	
	
}
