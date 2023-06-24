using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreMenager : MonoBehaviour
{
    public TextMeshProUGUI leftPlayerScoreText;
    public TextMeshProUGUI rightPlayerScoreText;

    public int leftPlayerScore;
    public int rightPlayerScore;

    private void Start()
    {
        leftPlayerScore = 0;
        rightPlayerScore = 0;
        leftPlayerScoreText.text = leftPlayerScore.ToString();
        rightPlayerScoreText.text = rightPlayerScore.ToString();
    }

     public void IncrementLeftPlayerScore()
     {
        leftPlayerScore++;
        leftPlayerScoreText.text = leftPlayerScore.ToString();
     }
          public void IncrementrightPlayerScore()
     {
        rightPlayerScore++;
        rightPlayerScoreText.text = rightPlayerScore.ToString();
     }
}
    

 
