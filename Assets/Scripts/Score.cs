using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;


    public TextMeshProUGUI scoreText;
    public int score = 0;

    void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    void Start() {
        if(scoreText == null) {
            Debug.Log("Score.Start scoreText sin asignar");
        } else {
            scoreText.text = score.ToString();
        }
        
    }

    public void AddPoints(int points) {
        
            score += points;

            Debug.Log("Score.AddPoints " + score);

            scoreText.text = score.ToString();
            
        if(score < 0){
            score = 0;
            scoreText.text = "0";
        }
        
        
        
    }

    public void RemovePoints(int points) {
        if(score > 0){
            score -= points;
            Debug.Log("Score.RemovePoints " + score);
            scoreText.text = score.ToString();
        }
        if(score < 0){
            score = 0;
            scoreText.text = "0";
        }
        
    }

    public void Reset () {
        score = 0;
        scoreText.text = score.ToString();
    }
}

