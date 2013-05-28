using UnityEngine;
using System.Collections;



public abstract class Human : CharacterClass {
	
	/**********
	 *  STATS *
	 **********/
	//skills
	private int longGun;
	private int handGun;
	private int bows;
	private int climb;
	private int acrobatics;
	
	//feats
	private bool fastMove; //for example...
	private bool headHunter;
	
	//equipment
	/*
	 * to do
	 */
	private Weapon equippedWeapon;
	//misc
	private int weight;
	private int capacity;
	
	//empty constructor
	public Human()
	{
		
	}
	
	/*************
	 * ACCESSORS *
	 *************/
	
	
	//getters
	public int getLongGun()
	{
		return longGun;	
	}
	
	public int getHandGun()
	{
		return handGun;	
	}
	
	public int getBows()
	{
		return bows;	
	}
	
	public int getClimb()
	{
		return climb;	
	}
	
	public int getAcrobatics()
	{
		return acrobatics;	
	}
	
	public bool hasFastMove()
	{
		return fastMove;	
	}
	
	public bool hasHeadHunter()
	{
		return headHunter;	
	}
	
	public int getWeight()
	{
		return weight;	
	}
	
	public int getCapacity()
	{
		return capacity;	
	}
	
	//setters
	
	public void setLongGun(int lGun)
	{
		longGun = lGun;	
	}
	
	public void setHandGun(int hGun)
	{
		handGun = hGun;	
	}
	
	public void setBows(int b)
	{
		bows = b;	
	}
	
	public void setClimb(int c)
	{
		climb = c;	
	}
	
	public void setAcrobatics(int a)
	{
		acrobatics = a;	
	}
	
	public void setFastMove(bool fm)
	{
		fastMove = fm;	
	}
	
	public void setHeadHunter(bool hh)
	{
		headHunter = hh;	
	}
	
	public void setWeight(int w)
	{
		weight = w;	
	}
	
	public void setCapacity(int c)
	{
		capacity = c;	
	}
	
	
	
	//use the currently equipped gun to damage an enemy within range
	//I think this should only be called after we've already verified that the target is valid, in range, all that stuff
	public void shoot(CharacterClass target)
	{
		//All of the formulas for generating the numbers here are certainly subject to change.
		//These are just quick and easy formulas so that we can have something to test with
		//Changing them should be quite easy, in general
		
		//generate a random number of damage within the range of the weapon
		int dmg = Random.Range (this.equippedWeapon.getMinDmg(), this.equippedWeapon.getMaxDmg());
		
		//generate an attack roll
		int attack = Random.Range (0, 100);
		attack += this.equippedWeapon.getBaseAccuracy ();
		attack += this.getLongGun ();
		attack += this.getDex ();
		
		target.receiveAttack(attack, dmg);
			
	}
}
