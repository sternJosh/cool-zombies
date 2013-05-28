using UnityEngine;
using System.Collections;

public abstract class CharacterClass : MonoBehaviour {
	
	private string name;
	
	//hit points and vit points
	private int hitPoints;
	private int vitPoints;
	
	//defense score. This is mostly a placeholder for the purposes of testing.
	private int defense;
	
	//attributes
	
	private int intel;
	private int composure;
	private int dex;
	private int con;
	private int perc;
	private int str;
	
	//skills
	/* should be implemented in a subclass
	private int longGun;
	private int handGun;
	private int bows;
	private int climb;
	private int acrobatics;
	*/
	//etc...
	
	//feats
	/* should be implemented in a subclass
	private bool fastMove; //for example...
	private bool headHunter;
	*/
	//empty constructor
	public CharacterClass()
	{
		
	}
	
	//move the character to a new point on the grid
	private void move()
	{
		
	}
	
	//the character dies
	private void die()
	{
		print (name + " has died.");
	}
	
	//getters
	
	public string getName()
	{
		return name;	
	}
	
	public int getHP()
	{
		return hitPoints;	
	}
	
	public int getVP()
	{
		return vitPoints;
	}
	
	public int getInt()
	{
		return intel;	
	}
	
	public int getComp()
	{
		return composure;
	}
	
	public int getDex()
	{
		return dex;	
	}
	
	public int getCon()
	{
		return con;	
	}
	
	public int getPerc()
	{
		return perc;	
	}
	
	public int getStr()
	{
		return str;	
	}
	
	public int getDefense()
	{
		return defense;	
	}
	
	//setters
	
	public void setName(string n)
	{
		name = n;	
	}
	
	public void setHP(int hp)
	{
		hitPoints = hp;
	}
	
	public void setVP(int vp)
	{
		vitPoints = vp;	
	}
	
	public void setInt(int i)
	{
		intel = i;	
	}
	
	public void setComp(int comp)
	{
		composure = comp;	
	}
	
	public void setDex(int d)
	{
		dex = d;	
	}
	
	public void setCon(int c)
	{
		con = c;	
	}
	
	public void setPerc(int p)
	{
		perc = p;	
	}
	
	public void setStr(int s)
	{
		str = s;	
	}
	
	public void setDefense(int d)
	{
		defense = d;	
	}
	
	
	//Decide whether an attack hits, and if it does, take the damage.
	//If the damage is enough to kill the character, go ahead and die.
	public void receiveAttack(int attack, int dmg)
	{
		if (attack >= this.defense) //hit
		{
			//deplete hitpoints first. Right?
			if (hitPoints >= dmg)
			{
				hitPoints -= dmg;	
			}
			else if (hitPoints < dmg) //not enough hit points to absorb full damage
			{	
					dmg -= hitPoints;
					hitPoints = 0;
					if (vitPoints > dmg) //not going to die yet
					{
						vitPoints -= dmg;	
					}
					else //the attack did enough damage to kill the target
					{
						this.die ();	
					}
			}
		}
	}
}