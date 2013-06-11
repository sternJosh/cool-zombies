using UnityEngine;
using System.Collections;

public class PCActionMenu : MonoBehaviour {

	public static PCActionMenu menu;
	
	//these all get set from the Tile class when it gets selected
	public string selector = "default";
	public Tile currentTile;
	public CharacterClass targetCharacter;
	
	public CharacterClass[] targets;
	public Tile[] reachable;
	
	void Awake()
	{
		menu = this;	
	}
	
	void  OnGUI() {
		if (selector == "")
		{
			//do nothing	
		}
		
		else if (selector == "default")
		{
			GUI.Box (new Rect(10, 10, 100, 100), "Action Menu");
			if(GUI.Button (new Rect(22.5F, 35, 75, 15), "Move"))
			{
				reachable = GameController.controller.currentChar.findReachableTiles();
				markReachableTiles(reachable);
				selector = "displayReachable";
			
			}
			if(GUI.Button (new Rect(22.5F, 55, 75, 15), "Attack"))
			{
				targets = new CharacterClass[GameController.controller.numChars];
				targets = GameController.controller.currentChar.findTargets(targets);	
				markValidTargets (targets);
				selector = "displayTargets";
			}
		}
		
		else if(selector == "displayReachable")
		{
			print ("display reachable?");
			GUI.Box (new Rect(10, 10, 155, 150), "Select a tile to move to");
			if(GUI.Button (new Rect(22.5F, 35, 135, 15), "Cancel Move Action"))
			{
				unMarkTiles(reachable);
				selector = "default";	
			}
		}
		
		else if(selector == "displayTargets")
		{
			print("display targets?");
			GUI.Box (new Rect(10, 10, 155, 150), "Select an enemy to attack");
			if(GUI.Button (new Rect(22.5F, 35, 135, 15), "Cancel Attack Action"))
			{
				unMarkTargets(targets);
				selector = "default";	
			}
		}
		
		else if(selector == "move")
		{
			GUI.Box(new Rect(150, 10, 100, 100), "Move to this location?");
				if(GUI.Button (new Rect(162.5F, 55, 75, 15), "Confirm"))
				{
					GameController.controller.currentChar.move (currentTile);	
				}
				if(GUI.Button (new Rect(162.5F, 75, 75, 15), "Cancel"))
				{
					selector = "default";	
				}
		}
		
		else if (selector == "attack")
		{
			GUI.Box(new Rect(150, 10, 100, 100), "Attack this target?");
				if(GUI.Button (new Rect(162.5F, 55, 75, 15), "Confirm"))
				{
					GameController.controller.currentChar.shoot (targetCharacter);	
				}
				if(GUI.Button (new Rect(162.5F, 75, 75, 15), "Cancel"))
				{
					selector = "default";	
				}
		}
	}
	
	public void markReachableTiles(Tile[] reachable)
	{
		print ("length of reachable is: " + reachable.Length);
		for (int i = 0; i < reachable.Length - 1; i++)
		{
			if (reachable[i] != null)
			{
				print(i);
				Tile theTile = reachable[i];
				print ("copy the tile okay?");
				theTile.transform.renderer.material.color = Color.cyan;
				theTile.setMoveAccessed (true);
				theTile.setAttackAccessed (false);
			}
			else
			{
				return;	
			}
			
		}
	}
	
	public void markValidTargets(CharacterClass[] targets)
	{
		for (int i = 0; i < targets.Length - 1; i++)
		{
			print (i);
			int x = targets[i].getLocation().x;
			int y = targets[i].getLocation().y;
			Tile theTile = GameController.controller.map[x, y];
			theTile.transform.renderer.material.color = Color.red;
			theTile.setAttackAccessed (true);
			theTile.setMoveAccessed (false);
		}
	}
	
	public void unMarkTiles(Tile[] tiles)
	{
		print ("Is this getting called?");
		for (int i = 0; i < tiles.Length; i++)
		{
			if (tiles[i] != null)
			{
				Tile theTile = tiles[i];
				theTile.transform.renderer.material.color = Color.grey;
			}
			else
			{
				return;	
			}
		}
	}
	
	public void unMarkTargets(CharacterClass[] targets)
	{
		for (int i = 0; i < targets.Length - 1; i++)
		{
			Tile theTile = targets[i].getLocation ();
			theTile.transform.renderer.material.color = Color.grey;
		}
	}
	
	
}
