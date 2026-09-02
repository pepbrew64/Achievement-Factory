using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //linked the variable form playerScore to Score
    [SerializeField] playerScore Amount;
    
    // Start is called before the first frame update
    void Start()
    {
        //see how many trophys the player has and shows score.
        if (Amount.trophyAmount == 9)
        {
            Debug.Log('S');
        }
        else if (Amount.trophyAmount  == 8)
        {
            Debug.Log('A');
        }
        else if (Amount.trophyAmount == 7)
        {
            Debug.Log('B');
        }
        else if (Amount.trophyAmount == 6)
        {
            Debug.Log('C');
        }
        else if (Amount.trophyAmount == 5)
        {
            Debug.Log('D');
        }
        else
        {
            Debug.Log('F');
        }
    }

    
}
