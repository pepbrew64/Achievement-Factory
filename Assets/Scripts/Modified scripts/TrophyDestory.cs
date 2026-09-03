using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyDestory : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        //see if game object has the player tag
        if(other.gameObject.tag == "Player")
        {
            //Destorys the trohy game object
            Destroy(gameObject);
        }
    }
}
