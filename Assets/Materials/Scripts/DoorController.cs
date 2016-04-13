using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour
{
    public bool isDoorOpen = false;
    Vector3 DoorPosition;
    Vector3 pivot;

    // Use this for initialization
    void Start()
    {
        DoorPosition = this.transform.position;
        pivot = DoorPosition;
        pivot.z += 1.4f;

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            if (!isDoorOpen)
            {
                print("The door should open");
                transform.RotateAround(pivot, Vector3.up, -90);
                isDoorOpen = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (isDoorOpen)
        {
            print("The door should close");
            transform.RotateAround(pivot, Vector3.up, 90);
            isDoorOpen = false;
            //this.transform.position=DoorPosition;
        }
    }

}





//bool isDoorOpen = false;
//Vector3 DoorPosition;
//Vector3 pivot;

//// Use this for initialization
//void Start()
//{
//    DoorPosition = this.transform.position;
//    pivot = DoorPosition;
//    pivot.z += 1.3f;

//}

//// Update is called once per frame
//void Update()
//{

//    Vector3 PlayerPosition = GameObject.Find("Player").transform.position;


//    if (Vector3.Distance(PlayerPosition, DoorPosition) < 9f && isDoorOpen == false)
//        {
//            print("The door should open");
//            transform.RotateAround(pivot, Vector3.up, -90);
//            isDoorOpen = true;
//        }

//        if (Vector3.Distance(PlayerPosition, DoorPosition) > 11f && isDoorOpen == true)
//        {
//            print("The door should close");
//            transform.RotateAround(pivot, Vector3.up, 90);
//            isDoorOpen = false;
//        }


//    }


//}

