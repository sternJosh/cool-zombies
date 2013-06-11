using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	private CharacterClass occupied;  //is there already a character here?
	private bool passable;
	private bool moveAccessed; //is this currently an eligible tile to move to?
	private bool attackAccessed; //is this currently an eligible tile to attack?
	private int height;
	public int x;
	public int y;
	
	public Tile()
	{
		occupied = null;
		passable = true;
		height = 0;
		x = 0;
		y = 0;
	}
	
	public Tile(int x, int y)
	{
		occupied = null;
		passable = true;
		height = 0;
		this.x = x;
		this.y = y;
		moveAccessed = false;
		attackAccessed = false;
	}
		
	public bool getMoveAccessed()
	{
		return moveAccessed;	
	}
	
	public bool getAttackAccessed()
	{
		return attackAccessed;
	}
	
	public CharacterClass getOccupied()
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
	
	public void setOccupied(CharacterClass character)
	{
		occupied = character;	
	}
	
	public void setPassable(bool value)
	{
		passable = value;	
	}
	
	public void setHeight(int h)
	{
		height = h;	
	}
	
	public void setMoveAccessed(bool value)
	{
		moveAccessed = value;	
	}
	
	public void setAttackAccessed(bool value)
	{
		attackAccessed = value;	
	}
	
	void OnMouseDown()
	{
		if (moveAccessed)
		{	
			PCActionMenu.menu.selector = "move";
			PCActionMenu.menu.currentTile = this;
		}
		else if (attackAccessed)
		{
			PCActionMenu.menu.selector = "attack";	
			PCActionMenu.menu.targetCharacter = this.getOccupied ();
		}
		else
		{
			return;	
		}
	}
	
	
	
}
