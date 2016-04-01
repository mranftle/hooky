using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {

	//Pivot point to rotate the door
	public Vector3 pivot; 

	// Use this for initialization
	void Start () {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 PlayerPosition = GameObject.Find("Player").transform.position;
		Vector3 DoorPosition = this.transform.position;

		if (Vector3.Distance(PlayerPosition, DoorPosition) < 5f && (int)this.transform.eulerAngles.y == 90)
        {
             transform.RotateAround(pivot, Vector3.up, -90);
		}
		else  if(Vector3.Distance(PlayerPosition, DoorPosition) > 7f && (int)this.transform.eulerAngles.y == 0)
        {
            transform.RotateAround(pivot, Vector3.up, 90);
			if (this.tag == "Door1") 
			{
				transform.position = new Vector3(45.11f, 3.15f, -9f);
			} else 
			{
				transform.position = new Vector3(106.414f, 3.04f, -126.02f);
			}
        }
    }
}

