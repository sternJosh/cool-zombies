using UnityEngine;
using System.Collections;

public class PCActionMenu : MonoBehaviour {

	
	void  OnGUI() {
		GUI.Box (new Rect(10, 10, 100, 100), "Action Menu");
		if(GUI.Button (new Rect(22.5F, 35, 75, 15), "Move"))
		{
			GameController.controller.currentChar.doAThing ();
		
		}
		GUI.Button (new Rect(22.5F, 55, 75, 15), "Attack");
	}
	
	
}
