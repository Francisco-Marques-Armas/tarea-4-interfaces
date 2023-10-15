using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // for TextMeshProUGUI

public class tarea_4_ej_5_cubo : MonoBehaviour
{
    // The cube is considered to be the player
    int score = 0;
    int score_group_a = 5;
    int score_group_b = 10;
    public delegate void ColisionEsferaA();
    public event ColisionEsferaA OnColisionEsferaA;
    public delegate void ColisionEsferaB();
    public event ColisionEsferaB OnColisionEsferaB;
    private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: " + score.ToString();
        OnColisionEsferaA += IncreaseScoreA;
        OnColisionEsferaB += IncreaseScoreB;
        // Search for textMeshProUGUI on UI Canvas
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other){
        if (other.collider.CompareTag("GroupASphere")) {
            OnColisionEsferaA();
        }
        else if (other.collider.CompareTag("GroupBSphere")) {
            OnColisionEsferaB();
        }
    }

    void IncreaseScoreA() {
        score += score_group_a;
        scoreText.text = "Score: " + score.ToString();
        Debug.Log("Score: " + score.ToString());
    }

    void IncreaseScoreB() {
        score += score_group_b;
        scoreText.text = "Score: " + score.ToString();
        Debug.Log("Score: " + score.ToString());
    }    
}
