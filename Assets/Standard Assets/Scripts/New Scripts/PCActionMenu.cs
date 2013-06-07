using UnityEngine;
using System.Collections;

public class PCActionMenu : MonoBehaviour {

	
	void  OnGUI() {
		GUI.Box (new Rect(10, 10, 100, 100), "Action Menu");
		if(GUI.Button (new Rect(22.5F, 35, 75, 15), "Move"))
		{
			Tile[] reachable = GameController.controller.currentChar.findReachableTiles();
			markReachableTiles(reachable);
		
		}
		if(GUI.Button (new Rect(22.5F, 55, 75, 15), "Attack"))
		{
			print ("button got pressed");
			CharacterClass[] targets = new CharacterClass[GameController.controller.numChars];
			targets = GameController.controller.currentChar.findTargets(targets);	
			markValidTargets (targets);
		}
	}
	
	public void markReachableTiles(Tile[] reachable)
	{
		for (int i = 0; i < reachable.Length - 1; i++)
		{
			print(i);
			Tile theTile = reachable[i];
			theTile.transform.renderer.material.color = Color.cyan;
			
		}
	}
	
	public void markValidTargets(CharacterClass[] targets)
	{
		for (int i = 0; i < targets.Length - 1; i++)
		{
			print (i);
			int x = targets[i].getX();
			int y = targets[i].getY();
			Tile theTile = GameController.controller.map[x, y];
			theTile.transform.renderer.material.color = Color.red;
		}
	}
	
	
}
