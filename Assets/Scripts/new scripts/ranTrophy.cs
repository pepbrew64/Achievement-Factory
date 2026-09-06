using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ranTrophy : MonoBehaviour
{
    //enables to add as many ponts we want
    [SerializeField] private Transform[] _Points;
    //holds the current piont variable
    private int nextPoint;
    //crates the navMesh agent variable
    private NavMeshAgent agent;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //puts the component of NavMeshAgent into the agent variable
        agent = GetComponent<NavMeshAgent>();
        //see if NavMeshAgent is there
        if (agent == null)
        {
            Debug.Log("agent is null");
        }

        //tuns off autoBraking
        agent.autoBraking = false;

        //activate the Function
        toNextPoint();

    }

    private void toNextPoint()
    {
        //gets a random pont from the _Ponts variable and puts it into the nextPont variable
        nextPoint = Random.Range(0, _Points.Length);
        //puts the points position into the agent variable
        agent.destination = _Points[nextPoint].position;
        //Choose which point to go next and put it into the nextPont variable
        nextPoint = (nextPoint + 1) % Random.Range(0, _Points.Length);
    }

    // Update is called once per frame
    void Update()
    {
        //see if the gameObject is close to the point
        if (!agent.pathPending && agent.remainingDistance < 0.5)
        {
            //activate the Function
            toNextPoint();
        }
    }
}
