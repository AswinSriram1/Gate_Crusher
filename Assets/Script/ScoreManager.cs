using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    public int score = 0;
    public int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore",0);
        scoreText.text = score.ToString();
        highscoreText.text = highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddPoints()
    {
        score += 1;
        scoreText.text = score.ToString();
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
        
    }
}
