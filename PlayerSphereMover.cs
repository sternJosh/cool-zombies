using UnityEngine;
using System.Collections;

public class PlayerSphereMover : MonoBehaviour {
	public GameObject sphere;
	// Use this for initialization
	void Start () {
		sphere = GameObject.FindGameObjectWithTag("NewTag");
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			sphere.transform.position += new Vector3(0, 0, 1);	
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			sphere.transform.position += new Vector3(0, 0, -1);	
		}
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			sphere.transform.position += new Vector3(-1, 0, 0);
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			sphere.transform.position += new Vector3(1, 0, 0);	
		}
	}
}
