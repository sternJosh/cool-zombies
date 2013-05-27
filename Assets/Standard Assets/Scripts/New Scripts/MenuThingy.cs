using UnityEngine;
using System.Collections;


public class MenuThingy : MonoBehaviour {

	void OnGUI () {
		if (GUI.Button (new Rect (10,10,150,100), "Move Up 2")) {
			//print ("You moved up 2");
			print ("The current camera is: " + CharacterCameraController.curCam);
			moveUp2 (CharacterCameraController.curCam);
		}
		
	}
	
	void moveUp2(int cur)
	{
		GameObject character = CharacterCameraController.chars[cur];
		character.transform.Translate (new Vector3(0, 0, 2));
		print ("you are trying to move up 2");
	}
}

