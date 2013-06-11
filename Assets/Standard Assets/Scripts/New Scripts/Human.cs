using UnityEngine;
using System.Collections;



public class Human : CharacterClass {
	
	public static readonly int numFeats;
	
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
	private bool[] feats;
	
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
	/*
	public bool hasFastMove()
	{
		return fastMove;	
	}
	
	public bool hasHeadHunter()
	{
		return headHunter;	
	}
	*/
	
	public bool readFeats(int featID)
	{
		return feats[featID];	
	}
	
	public bool[] getFeats()
	{
		return feats;	
	}
	
	public int getWeight()
	{
		return weight;	
	}
	
	public int getCapacity()
	{
		return capacity;	
	}
	
	public Weapon getWeapon()
	{	
		return equippedWeapon;
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
	/*
	public void setFastMove(bool fm)
	{
		fastMove = fm;	
	}
	
	public void setHeadHunter(bool hh)
	{
		headHunter = hh;	
	}
	*/
	public void setFeat(int ID, bool value)
	{
		feats[ID] = value;	
	}
	
	public void setWeight(int w)
	{
		weight = w;	
	}
	
	public void setCapacity(int c)
	{
		capacity = c;	
	}
	
	//this should be handled differently later on
	public void setWeapon(Weapon wep)
	{
		equippedWeapon = wep;	
	}
	
	
	
	//use the currently equipped gun to damage an enemy within range
	//I think this should only be called after we've already verified that the target is valid, in range, all that stuff
	public override void shoot(CharacterClass target)
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
	
	
	public override CharacterClass[] findTargets(CharacterClass[] targets)
	{
		print("trying to find targets");
		int j = 0;
		int thisX = this.getLocation().x; 
		int thisY = this.getLocation().y;
		for (int i = 0; i < GameController.controller.numChars; i++)
		{
			
		CharacterClass ch = GameController.controller.chars[i];
			if (ch != this) //since this character is in the array, we need to make sure we don't try to shoot ourself.
			{
				int targX = ch.getLocation().x;
				int targY = ch.getLocation().y;
				int sqrDifX = (targX - thisX) * (targX - thisX);
				int sqrDifY = (targY - thisY) * (targY - thisY);
				//the below formula isn't quite right
				if (Mathf.Sqrt ((sqrDifX + sqrDifY)) <= getWeapon ().getRange ()) //the character is within range
				{
					targets[j] = ch;
					j++;
					print ("Found a seemingly valid target");
				}
				else 
				{
					print ("This target is invalid for one reason or another");	
				}
			}
			else 
			{
				print ("you can't shoot yourself, now can you?");	
			}
		}
		return targets;
		
		
		
	}
}
