using UnityEngine;
using System.Collections;

public class TeacherPatrol : MonoBehaviour {

    public Transform[] points;
    private int destPoint;
    private NavMeshAgent agent;
    private int turn = 1;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        //could be false if we want
        agent.autoBraking = true;
        destPoint = 1;
        GotoNextPoint();
    }


    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = points[destPoint].position;


        
       
       int Randomnumber = (int)(Random.value * 10);
       if (Randomnumber < 1)
                turn *= -1;
        
        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        int newPoint = (destPoint + turn);
        if (newPoint < 0)
        {
            newPoint = points.Length + newPoint;
        }
        destPoint = (newPoint) % points.Length;
        
    }


    void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }
}
