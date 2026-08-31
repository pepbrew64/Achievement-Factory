using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyDestory : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Destorys the trohy game object
        Destroy(gameObject);
    }
}
