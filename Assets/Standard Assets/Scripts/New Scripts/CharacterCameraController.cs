using UnityEngine;
using System.Collections;

public class CharacterCameraController : MonoBehaviour {
	public static GameObject[] chars;
	public static GameObject char1;
	public static GameObject char2;
	public static GameObject char3;
	public static GameObject char4;
	public Camera cam1;
	public Camera cam2;
	public Camera cam3;
	public Camera cam4;
	public Camera[] cams;
	public bool pressed;
	public static int curCam;
	public static readonly int camCount = 4;
	// Use this for initialization
	void Start () {
		char1 = GameObject.FindGameObjectWithTag ("Cam1");
		char2 = GameObject.FindGameObjectWithTag ("Cam2");
		char3 = GameObject.FindGameObjectWithTag ("Cam3");
		char4 = GameObject.FindGameObjectWithTag ("Cam4");
		chars = new GameObject[10];
		chars[0] = char1;
		chars[1] = char2;
		chars[2] = char3;
		chars[3] = char4;
		//the above could obviously be handled more flexibly but this'll do for now.
		
		cams = Camera.allCameras;
		cam1 = cams[0];
		cam2 = cams[1];
		cam3 = cams[2];
		cam4 = cams[3];
		
		cam1.enabled = true;
		cam2.enabled = false;
		cam3.enabled = false;
		cam4.enabled = false;
		curCam = 1;
		
	}
	void toggleCam(int cur){
		print ("current camera before toggle: " + curCam);
		if (cur > camCount) //shouldn't happen
		{
			print ("Input invalid camera number to toggleCam function");
		}
		else if 	(cur == camCount) //should loop around to first cam
		{
			cams[cur - 1].enabled = false;
			cams[0].enabled = true;
			curCam = 1;
		}
		else //normal behavior. go to next camera
		{
			cams[cur - 1].enabled = false;
			cams[cur].enabled = true;
			curCam++;
		}
		print ("current camera after toggle: " + curCam);
	}
	// Update is called once per frame
	void Update () {
		pressed = false;
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			pressed = true;	
		}
		if (pressed)
		{
			toggleCam (curCam);
		}
	}
}
