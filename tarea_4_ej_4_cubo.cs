using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea_4_ej_4_cubo : MonoBehaviour
{
    // The cube is considered to be the player
    int score = 0;
    int score_group_a = 5;
    int score_group_b = 10;
    public delegate void ColisionEsferaA();
    public event ColisionEsferaA OnColisionEsferaA;
    public delegate void ColisionEsferaB();
    public event ColisionEsferaB OnColisionEsferaB;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score: " + score.ToString());
        OnColisionEsferaA += IncreaseScoreA;
        OnColisionEsferaB += IncreaseScoreB;
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
        Debug.Log("Score: " + score.ToString());
    }

    void IncreaseScoreB() {
        score += score_group_b;
        Debug.Log("Score: " + score.ToString());
    }    
}
