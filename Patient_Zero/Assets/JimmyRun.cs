using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JimmyRun : MonoBehaviour
{

    public Transform[] waypoints;
    private int destPoint = 0;
    private NavMeshAgent agent;
    private Animator anim;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

        agent.autoBraking = false;
        anim.SetBool("isRunning", false);


        GotoNextPoint();
    }


    void GotoNextPoint()
    {
        if (waypoints.Length == 0)
        {
            return;
        }
        agent.destination = waypoints[destPoint].position;
        destPoint = (destPoint + 1) % waypoints.Length;
        anim.SetBool("isRunning", true);
    }


    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }
}
