﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TeacherSight : MonoBehaviour
{

    public float fieldOfViewAngle = 110f;           // Number of degrees, centred on forward, for the enemy see.
    public bool playerInSight;                      // Whether or not the player is currently sighted.

    private NavMeshAgent nav;                       // Reference to the NavMeshAgent component.
    private SphereCollider col;                     // Reference to the sphere collider trigger component.
    private Animator anim;                          // Reference to the Animator.
    private GameObject player;                      // Reference to the player.
    private Animator playerAnim;                    // Reference to the player's animator component.
	public GameObject busted;

    void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        col = GetComponent<SphereCollider>();
        anim = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
		busted.GetComponent<RawImage>().enabled = false;
    }
        

        void OnTriggerStay(Collider other)
    {
		
		//print (other);
        // If the player has entered the trigger sphere...
		if (other.gameObject == player ){//&& other.GetType() == typeof(SphereCollider)){
            // By default the player is not in sight.
            playerInSight = false;
			print ("trigger icinde");
			//print ("player in sphere");
            // Create a vector from the enemy to the player and store the angle between it and forward.
            Vector3 direction = other.transform.position - transform.position;
			direction.y = 0;
			//print ("teacher:" + transform.position + "std:" + other.transform.position);


            float angle = Vector3.Angle(direction, transform.forward);

            // If the angle between forward and where the player is, is less than half the angle of view...

			//print("angle:" + angle.ToString());
			//print("direction:" + direction);
			if (angle < fieldOfViewAngle * 0.5f)
            //if (true)
            {
                RaycastHit hit;
				print ("angle icinde");
                // ... and if a raycast towards the player hits something...
				if (Physics.Raycast(transform.position + transform.up, direction.normalized, out hit, col.radius))
                {
					print ("in raycast");
					print (hit.collider.tag);
					//Debug.DrawLine(Vector3.zero, new Vector3(1, 0, 0), Color.red);
					//Debug.DrawLine(transform.position, other.transform.position, Color.red, 300.0f, true);
                    // ... and if the raycast hits the player...
					if (hit.collider.tag == "Player")
                    {
                        // ... the player is in sight.
                        playerInSight = true; //Now we need to kill the game somehow
						//print("raycast hit");
						print("died");
						busted.GetComponent<RawImage>().enabled = true;
                        //Application.Quit(); //Why doesn't this happen?
                    }
                }
            }
        }
    }
    //void OnTriggerEnter(Collider other)
    //{
        
        //    if (other.gameObject == player)
        //    {
        //        //change music, ect.
        //    }
    //}

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject == player)
    //    {
    //        //change music back, ect.
    //    }
    //}
}
