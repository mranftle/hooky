using UnityEngine;
using System.Collections;

public class DirectionController : MonoBehaviour {

	public GameObject player;
	public Texture2D directionArrow;
	public Camera overallCamera;
	public Rect arrowRect;
	public GameObject target;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update() {

		if (GameObject.Find ("Player").GetComponent<PlayerController> ().password == false) {
			target = GameObject.FindGameObjectWithTag ("Password");
		}
		else if (GameObject.Find ("Player").GetComponent<PlayerController> ().grade == false) {
			target = GameObject.FindGameObjectWithTag ("Computer");
		}
		else if (GameObject.Find ("Player").GetComponent<PlayerController> ().solution == false) {
			target = GameObject.FindGameObjectWithTag ("Solution");
		}
		else {
			target = GameObject.FindGameObjectWithTag ("Key");
		}
	}

	void OnGUI () {
		//Get the targets position on screen into a Vector3
		Vector3 targetPos = overallCamera.WorldToViewportPoint (target.transform.position);
		//Get the middle of the screen into a Vector3
		Vector3 screenMiddle = new Vector3(overallCamera.pixelRect.xMin + (overallCamera.pixelWidth/2), overallCamera.pixelRect.yMin + (overallCamera.pixelHeight/2), 0); 
		//Compute the angle from screenMiddle to targetPos
		float tarAngle = (Mathf.Atan2(targetPos.x-screenMiddle.x,overallCamera.pixelHeight-targetPos.y-screenMiddle.y) * Mathf.Rad2Deg)+90;
		if (tarAngle < 0) tarAngle +=360f;

		//Calculate the angle from the camera to the target
		Vector3 targetDir = target.transform.position - player.transform.position;
		Vector3 forward = player.transform.forward;
		float angle = Vector3.Angle(targetDir, forward);
		//If the angle exceeds 90deg inverse the rotation to point correctly
		if(angle < 90){
			transform.localRotation = Quaternion.Euler(-tarAngle,90,270);
		} else {
			transform.localRotation = Quaternion.Euler(tarAngle,270,90);
		}
	}
}
