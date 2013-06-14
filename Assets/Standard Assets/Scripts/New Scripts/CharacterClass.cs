using UnityEngine;
using System.Collections;

public class CharacterClass : MonoBehaviour {
	
	private string charName;
	public Tile location;
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
	
	private int movement;
	
	public CharacterClass()
	{
		
	}
	
	//move the character to a new point on the grid
	//assumes the tile has already been confirmed as valid
	public virtual void move(Tile target)
	{
		setLocation (target);
	}
	
	//the character dies
	private void die()
	{
		print (charName + " has died.");
		GameController.controller.removeCharacter (this);
	}
	
	//getters
	
	public int getMovement()
	{
		return movement;	
	}
	
	public Tile getLocation()
	{
		return location;	
	}
	
	
	public string getName()
	{
		return charName;	
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
	
	public void setMovement(int m)
	{
		movement = m;	
	}
	
	public void setLocation(Tile loc)
	{
		location = loc;	
	}
	
	public void setName(string n)
	{
		charName = n;	
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
			print (getName () + " just got hit. ouch");
			//deplete hitpoints first. Right?
			if (hitPoints >= dmg)
			{
				hitPoints -= dmg;	
				print (getName () + " now has " + getHP () + " HP remaining");
			}
			else if (hitPoints < dmg) //not enough hit points to absorb full damage
			{	
					dmg -= hitPoints;
					hitPoints = 0;
					if (vitPoints > dmg) //not going to die yet
					{
						vitPoints -= dmg;
						print (getName () + " now has " + getVP () + " VP remaining");
					}
					else //the attack did enough damage to kill the target
					{
						this.die ();	
					}
			}
		}
		else
		{
			print(getName() + " avoided an attack");	
		}
	}
	
	IEnumerator startTurn()
	{
		yield return null;
	}
	
	public virtual IEnumerator drawMenu()
	{
		yield return null;
	}
	
	public virtual void doAThing()
	{
		print ("is this the one?");
	}
	
	public virtual CharacterClass[] findTargets(CharacterClass[] targets)
	{
		return targets;
	}
	
	public Tile[] findReachableTiles()
	{
		int x = getLocation ().x;
		int y = getLocation ().y;
		
		int mapX = GameController.controller.mapX;
		int mapY = GameController.controller.mapY;
		Tile[] reachable = new Tile[mapX * mapY];
		print (mapX);
		print (mapY);
		int count = 0;
		//this is such a stupid algorithm. it will be made less stupid at a later date.
		//also, this doesn't account for impassable terrain. so the real algorithm will have to be much more sophisticated.
		for (int i = 0; i < mapX; i++)
		{
			print ("get into loop at all?");
			for (int j = 0; j < mapY; j++)
			{
				print ("checking a tile");
				int sqrX = (x - i) * (x - i);
				int sqrY = (y - j) * (y - j);
				//the below formula isn't quite right.
				if (Mathf.Sqrt(sqrX + sqrY) <= movement) //tile is within movement range. should mark as reachable
				{
					print ("found a reachable tile");
					reachable[count] = GameController.controller.map[i, j];
					count++;
				}
				else
				{
					print ("tile wasn't reachable");
				}		
			}
		}
		print (count);
		return reachable;
	}
	
	public virtual void shoot(CharacterClass target)
	{
		
	}
}