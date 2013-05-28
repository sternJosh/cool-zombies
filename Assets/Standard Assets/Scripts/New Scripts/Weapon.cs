using UnityEngine;
using System.Collections;

public abstract class Weapon : MonoBehaviour {
	
	private int ID;
	
	//statistics
	private int maxDmg;
	private int minDmg;
	private int weight;
	private int baseAccuracy;
	
	//empty constructor
	public Weapon()
	{
	
	}
	
	/*************
	 * ACCESSORS *
	 *************/
	
	//getters
	public int getID()
	{
		return ID;	
	}
	
	public int getMaxDmg()
	{
		return maxDmg;	
	}
	
	public int getMinDmg()
	{
		return minDmg;	
	}
	
	public int getWeight()
	{
		return weight;
	}
	
	public int getBaseAccuracy()
	{
		return baseAccuracy;	
	}
	
	//setters
	public void setID(int id)
	{
		ID = id;	
	}
	
	public void setMaxDmg(int max)
	{
		maxDmg = max;	
	}
	
	public void setMinDmg(int min)
	{
		minDmg = min;	
	}
	
	public void setWeight(int w)
	{
		weight = w;	
	}
	
	public void setBaseAccuracy(int ba)
	{
		baseAccuracy = ba;	
	}
}
