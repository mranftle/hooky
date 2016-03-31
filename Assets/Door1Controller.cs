using UnityEngine;
using System.Collections;

public class Door1Controller : MonoBehaviour {



	bool isDoorOpen = false;

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	


		Vector3 PlayerPosition = GameObject.Find ("Player").transform.position;
		Vector3 DoorPosition = this.transform.position;

		Vector3 pivot = DoorPosition;

		pivot.z = -8f;



		if (Vector3.Distance (PlayerPosition, DoorPosition) < 6f && isDoorOpen == false) {

			transform.RotateAround (pivot, Vector3.up, -90);
			isDoorOpen = true;
		} 

		if (Vector3.Distance (PlayerPosition, DoorPosition) > 10f && isDoorOpen == true) {
			transform.RotateAround(pivot, Vector3.up,90);
			transform.position = new Vector3 (45.11f, 3.15f, -9f);
			isDoorOpen = false;
		}


	}
		


}
