using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
 int score;
 
 TMP_Text scoreText;
 
 private void Start() 
 {
     scoreText = GetComponent<TMP_Text>();
     scoreText.text = "Hello World";
 }

public void UpdateScore(int increaseScore)
{
    score += increaseScore;
    scoreText.text = score.ToString();
    Debug.Log($"Score is {score}");
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
