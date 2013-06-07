using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	private bool occupied;  //is there already a character here?
	private bool passable;
	private int height;
	public int x;
	public int y;
	
	public Tile()
	{
		occupied = false;
		passable = true;
		height = 0;
		x = 0;
		y = 0;
	}
	
	public Tile(int x, int y)
	{
		occupied = false;
		passable = true;
		height = 0;
		this.x = x;
		this.y = y;
	}
		
	public bool getOccupied()
	{
		return occupied;
	}
	
	public bool getPassable()
	{
		return passable;	
	}
	
	public int getHeight()
	{
		return height;	
	}
	
	public void setOccupied(bool value)
	{
		occupied = value;	
	}
	
	public void setPassable(bool value)
	{
		passable = value;	
	}
	
	public void setHeight(int h)
	{
		height = h;	
	}
	
}
