using UnityEngine;
using System.Collections;

public class starsController : MonoBehaviour {

	GameObject player;
	public GameObject star;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		bool toCheck = false;
		if (star.Equals(GameObject.Find("passwordMissionStar") ) ){
			toCheck = player.GetComponent<PlayerController> ().password;
		}
		else if (star.Equals(GameObject.Find("gradeMissionStar") ) ) {
			toCheck = player.GetComponent<PlayerController> ().grade;
		}
		else if (star.Equals(GameObject.Find("solutionMissionStar") ) ) {
			toCheck = player.GetComponent<PlayerController> ().solution;
		}
		if ( toCheck == true) {
			Destroy (star);
		}
			
		if (star.Equals(GameObject.Find("stairMissionStar") ) ) {
			if (player.GetComponent<PlayerController> ().password == true
			    && player.GetComponent<PlayerController> ().grade == true
				&& player.GetComponent<PlayerController> ().solution == true) {
				Destroy (star);
			}
		}
	}
}