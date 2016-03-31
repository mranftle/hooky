using UnityEngine;
using System.Collections;

public class DeanPatrol : MonoBehaviour {

    private NavMeshAgent nav;                       // Reference to the NavMeshAgent component.
    private SphereCollider col;                     // Reference to the sphere collider trigger component.
    private GameObject player;                      // Reference to the player.


    // Use this for initialization
    void Start () {
        nav = GetComponent<NavMeshAgent>();
        col = GetComponent<SphereCollider>();
        player = GameObject.FindWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        nav.destination = player.transform.position;
	}
}
