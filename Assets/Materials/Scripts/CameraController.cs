using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;


	void Start () {
		//player = GameObject.FindGameObjectWithTag ("Player");
		//offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
//		transform.position = player.transform.position + offset;
//		Camera.main.transform.position = new Vector3(player.transform.position.x - 2f, 2.5f, player.transform.position.z);
		//Camera.main.transform.position = new Vector3(player.transform.position.x, 3.5f, player.transform.position.z) - player.transform.forward * offset.magnitude * 1.3f;
		//Camera.main.transform.forward = player.transform.position - Camera.main.transform.position;
	}
}
