using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] //Repalaes with player script// trophyAmount;
    
    // Start is called before the first frame update
    void Start()
    {
        //see how many trophys the player has.
        if (trophyAmount == 9)
        {
            Debug.Log('S');
        }
        else if (trophyAmount  == 8)
        {
            Debug.Log('A');
        }
        else if (trophyAmount == 7)
        {
            Debug.Log('B');
        }
        else if (trophyAmount == 6)
        {
            Debug.Log('C');
        }
        else if (trophyAmount == 5)
        {
            Debug.Log('D');
        }
        else
        {
            Debug.Log('F');
        }
    }

    
}
