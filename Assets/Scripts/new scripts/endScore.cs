using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScore : MonoBehaviour
{
    //get the value for the playerScore script
    playerScore finalScore;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //see if the finalScore is the same as 9
        if (finalScore.trophyAmount == 9)
        {
            //loads the scene end
            SceneManager.LoadScene("End");
        }
    }
}
