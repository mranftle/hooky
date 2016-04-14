using UnityEngine;
using System.Collections;

public class wholeMapController : MonoBehaviour {

	public Camera treasureMapCamera;

	// Use this for initialization
	void Start () {
		treasureMapCamera.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Tab))
		{
			treasureMapCamera.enabled = !treasureMapCamera.enabled;
			if (Time.timeScale == 0) {
				Time.timeScale = 1;
			} else {
				Time.timeScale = 0;
			}
		}
	}
}
