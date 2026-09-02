using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScore : MonoBehaviour
{
    //the variables for how many trophys that where collected.
    public int trophyAmount;

    private void OnCollisionEnter(Collision other)
    {
        //see if the game object has the Trophy tag.
        if(other.gameObject.tag == "Trophy")
        {
            //incress the value of the variable.
            trophyAmount++;
        }
    }
}
