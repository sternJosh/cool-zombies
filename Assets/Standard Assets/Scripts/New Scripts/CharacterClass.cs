using UnityEngine;
using System.Collections;

public abstract class CharacterClass : MonoBehaviour {
	
	//hit points and vit points
	private int hitPoints;
	private int vitPoints;
	
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
		
	}
	
	//getters
	
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
	
	//setters
	
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
		dex = do;	
	}
	
	public void setCon(int c)
	{
		con = c;	
	}
	
	public void setPerc(int p)
	{
		perc = p;	
	}
	
	public void getStr(int s)
	{
		str = s;	
	}