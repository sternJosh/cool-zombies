using UnityEngine;
using System.Collections;

public class CamSwitcher : MonoBehaviour {
	//need to create cameraObject class which extends GameObject before this will work
	bool pressed;
	int curLoc = 1;
	public GameObject cm1;
	Vector3 v2 = new Vector3(2.009001F, 2.262367F, -0.9475138F);
	Vector3 v3 = new Vector3(1.253192F, 2.444799F, 1.380525F);
	Vector3 v4 = new Vector3(-0.04810411F, 1.737379F, 0.9908724F);
	Vector3 v1 = new Vector3(0, 2, -0.8656269F);
	Vector3 q1 = new Vector3(60, 0, 0);
	Vector3 q2 = new Vector3(60, 330, 0);
	Vector3 q3 = new Vector3(90, 330, 0);
	Vector3 q4 = new Vector3(90, 60, 0);
	//Vector3 res = new Vector3(90, 60, 0);
	// Use this for initialization
	void Start () {
		cm1 = GameObject.Find("cam1");
		/*
		q1.x = 60;
		q1.y = 330;
		q1.z = 0;
		q2.x = 90;
		q2.y = 330;
		q2.z = 0;
		q3.x = 90;
		q3.y = 60;
		q3.z = 0;
		q4.x = 60;
		q4.y = 0;
		q4.z = 0;
		*/
		/*
		tr1.position = new Vector3(2.009001F, 2.262367F, -0.9475138F);
		tr1.rotation = new Quaternion(60, 330, 0, 0);
		tranTable[0] = tr1;
		tr2.position = new Vector3(1.253192F, 2.444799F, 1.380525F);
		tr2.rotation = new Quaternion(90, 330, 0, 0);
		tranTable[1] = tr2;
		tr3.position = new Vector3(-0.04810411F, 1.737379F, 0.9908724F);
		tr3.rotation = new Quaternion(90, 60, 0, 0);
		tranTable[2] = tr3;
		tr4.position = new Vector3(0, 2, -0.8656269F);
		tr4.rotation = new Quaternion(60, 0, 0, 0);
		*/
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
			print ("stuff");
			if (curLoc != 4) 
			{
				curLoc++;	
				
			}
			else
			{
				curLoc = 1;	
			}
		
		//currentCam.gameObject.SetActive(false);
		if (curLoc == 1)
		{
			cm1.transform.position = v1;
			cm1.transform.localEulerAngles = q1;

		}
		else if (curLoc == 2)
		{
			cm1.transform.position = v2;
			cm1.transform.localEulerAngles = q2;
		}
		else if (curLoc == 3)
		{
			cm1.transform.position = v3;
			cm1.transform.localEulerAngles = q3;
		}
		else if (curLoc == 4)
		{
			cm1.transform.position = v4;
			cm1.transform.localEulerAngles = q4;
		}
		}
	}
}
