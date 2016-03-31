using UnityEngine;
using System.Collections;

public class TeacherFootStep : MonoBehaviour {

	//CharacterController cc;
	private NavMeshAgent nav;
	private AudioSource footstepaudio; 
	private float distance;
	private GameObject player;
	public ulong footSoundFrequency;

	// Use this for initialization
	void Start () {
		//cc = GetComponent<CharacterController> (); 
		nav = GetComponent<NavMeshAgent>(); 
		footstepaudio = GetComponent<AudioSource> (); 
		player = GameObject.FindWithTag("Player");
	}

	// Update is called once per frame
	void Update () {
		distance = Vector3.Magnitude(transform.position - player.transform.position);

		if (distance <= 25 && nav.velocity.magnitude >0 && GetComponent<AudioSource>().isPlaying == false) {
			footstepaudio.Play (44100/footSoundFrequency);  
		}
		//		else if (cc.velocity.magnitude > 4f && GetComponent<AudioSource>().isPlaying == false) {
		//			GetComponent<AudioSource>().Play (44100/4);  
		//		}
	}
}
