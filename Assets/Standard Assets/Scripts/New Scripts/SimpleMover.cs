using UnityEngine;
using System.Collections;

public class SimpleMover : MonoBehaviour {
	GameObject char1;
	bool pressed;
	// Use this for initialization
	void Start () {
		char1 = GameObject.Find ("Char1");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			char1.transform.Translate (new Vector3(0.1F, 0, 0));
			return;
		}
		if (Input.GetKeyDown (KeyCode.DownArrow))
		{
			char1.transform.Translate (new Vector3(-0.1F, 0, 0));
			return;
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{	
			char1.transform.Translate (new Vector3(0, 0, 0.1F));
			return;
		}	
		if (Input.GetKeyDown (KeyCode.LeftArrow))
		{
			char1.transform.Translate (new Vector3(0, 0, -0.1F));
			return;
		}
	}
}
