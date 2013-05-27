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
	
	