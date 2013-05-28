using UnityEngine;
using System.Collections;

public class Gun : Weapon {
	
	//statistics
	private int range;
	private bool isLong;
	private bool isHand;
	
	//default constructor
	public Gun()
	{
		setRange (10);
		setWeight (10);
		setIsLong (true);
		setIsHand (false);
		setMinDmg (7);
		setMaxDmg (15);
		setBaseAccuracy (10);
	}
	
	/**************
	 *  ACCESSORS *
	 **************/
	
	//getters
	public int getRange()
	{
		return range;	
	}
	
	public bool getLong()
	{
		return isLong;	
	}
	
	public bool getHand()
	{
		return isHand;	
	}
	
	//setters
	public void setRange(int r)
	{
		range = r;	
	}
	
	public void setIsLong(bool l)
	{
		isLong = l;	
	}
	
	public void setIsHand(bool h)
	{
		isHand = h;	
	}
}
