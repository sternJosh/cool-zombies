using UnityEngine;
using System.Collections;

public class NPC : Human {

	private void humanAI()
	{
		//super complicated stuff
		//team tactics and whatnot
	}
	
	public NPC()
	{
		print("Creating default NPC");
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
		feats= new bool[numFeats];
		setName ("TestPC");
	}
}
