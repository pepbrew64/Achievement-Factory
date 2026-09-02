using UnityEngine;
using TMPro;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //This executes the first and second block of code based on whether "countDown" is true or false
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        //Determines when to stop the timer relative to if it's counting up or down
        if (hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit)))
        {
            currentTime = timerLimit;
            SetTimerText();
            timerText.color = Color.yellow;
            enabled = false;
        }

        //Change scene to "End" if timer runs out
        if (currentTime == 0)
        {
            SceneManager.LoadScene(3);
        }

        //Update timer text
        SetTimerText();
    }

    private void SetTimerText()
    {
        //Render to text
        timerText.text = currentTime.ToString("000.0");
    }
}

