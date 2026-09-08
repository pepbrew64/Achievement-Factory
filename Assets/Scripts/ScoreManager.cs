using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = score + " %";
    }

    public void IncreaseScore()
    {
        score += 5;
        scoreText.text = score + " %";

        // If you get 100% or more somehow, it'll send you to the results screen
        if (score >= 100)
        {
            SceneManager.LoadScene(3);
        }

    }

}
