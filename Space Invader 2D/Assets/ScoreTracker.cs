using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{

    private int score = 0;
    Text scoreText;


    // Use this for initialization
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = "TOTAL REGRET" + score;

    }

    public void addScore(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreText.text = "TOTAL REGRET" + score;

        GetComponent<AudioSource>().Play();


    }



}