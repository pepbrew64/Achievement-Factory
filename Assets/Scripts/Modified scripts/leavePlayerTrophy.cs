using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class leavePlayerTrophy : MonoBehaviour
{
    //enables to add as many ponts we want
    [SerializeField] private Transform[] goToPonts;
    //holds the current piont variable
    private int nextTrophyPoint;
    //crates the navMesh agent variable
    private NavMeshAgent trophyAgent;
    //allows for the spin speed to be changed
    [SerializeField] float turn = 0f;

    private void Start()
    {
        //puts the component of NavMeshAgent into the agent variable
        trophyAgent = GetComponent<NavMeshAgent>();
        //see if NavMeshAgent is there
        if (trophyAgent != null) 
        {
            Debug.Log("trophyAgent is null");
        }

        //tuns off autoBraking
        trophyAgent.autoBraking = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        //see if the gameObject has the Player tag
        if (other.gameObject.tag == "Player")
        {

            //activate the Function
            toNextPont();
        }
    }

    private void toNextPont()
    {
        //gets a random pont from the goToPonts variable and puts it into the nextTrophyPoint variable
        nextTrophyPoint = Random.Range(0, goToPonts.Length);
        //puts the points position of the next into the trophyAgent variable
        trophyAgent.destination = goToPonts[nextTrophyPoint].position;
        //Choose which point to go next and put it into the nextTrophyPoint variable
        nextTrophyPoint = (nextTrophyPoint + 1) % Random.Range(0, goToPonts.Length);
        //Truns the gameObject
        transform.Rotate(0, turn, 0);
    }
}
