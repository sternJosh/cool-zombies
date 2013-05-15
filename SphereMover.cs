using UnityEngine;
using System.Collections;

public class SphereMover : MonoBehaviour {
	
	public GameObject obj;
	// Use this for initialization
	void Start () {
		obj = GameObject.FindWithTag("NewTag");
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.frameCount % 6 == 0)
		{
			if (obj.transform.position.x == 0 && obj.transform.position.z == 0)
			{
				
				obj.transform.position = new Vector3(0, 0, 1);
				//obj.transform.position.z = 1;
			}
			else if (obj.transform.position.x == 0 && obj.transform.position.z == 1)
			{
				obj.transform.position = new Vector3(1, 0, 0);
				//obj.transform.position.z = 0;
			}
			else if (obj.transform.position.x == 1 && obj.transform.position.z == 0)
			{
				obj.transform.position = new Vector3(1, 0, 1);
				//obj.transform.position.z = 1;
			}
			else 
			{
				obj.transform.position = new Vector3(0, 0, 0);
				//obj.transform.position.z = 0;
			}
		}
	}
}
