using UnityEngine;
using System.Collections;

public class Gun : Weapon {
	
	//statistics
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

	public bool getLong()
	{
		return isLong;	
	}
	
	public bool getHand()
	{
		return isHand;	
	}
	
	//setters
	
	public void setIsLong(bool l)
	{
		isLong = l;	
	}
	
	public void setIsHand(bool h)
	{
		isHand = h;	
	}
}
