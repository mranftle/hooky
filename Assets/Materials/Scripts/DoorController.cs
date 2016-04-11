using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour
{



    bool isDoorOpen = false;
    Vector3 DoorPosition;

    // Use this for initialization
    void Start()
    {
        DoorPosition = this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

            Vector3 PlayerPosition = GameObject.Find("Player").transform.position;
           

            Vector3 pivot = DoorPosition;

            pivot.z += 1.3f;



            if (Vector3.Distance(PlayerPosition, DoorPosition) < 10f && isDoorOpen == false)
            {
                print("The door should open");
                transform.RotateAround(pivot, Vector3.up, -90);
                isDoorOpen = true;
            }

            if (Vector3.Distance(PlayerPosition, DoorPosition) > 11f && isDoorOpen == true)
            {
                transform.RotateAround(pivot, Vector3.up, 90);
                transform.position = DoorPosition;
                isDoorOpen = false;
            }


        }


    }

