using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour

{
    //the valrble for countdown that can be changed
    [SerializeField] float count;


    // Update is called once per frame
    void Update()
    {
        //calls for the countDown method
        countDown();
    }

    //the countdown method
    private void countDown()
    {
        /*use the valrble form count and subtracts form time.time to see if it
        is a zero. Note there is a bit of a problm with the float in which the sceneManager will not run*/
        if (count - Time.time == 0)
        {
            //loads the scene "End" if count is zero
            SceneManager.LoadScene("End");
        }
    }
}
