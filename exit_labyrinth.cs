using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit_labyrinth : MonoBehaviour
{
    // Get ui panel
    public GameObject UIPanel; 

    public GameObject player;
    public GameObject enemy;

    bool won = false;
    bool lost = false;

    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "LabyrinthExit")
        {
            Debug.Log("You won!");
            UIPanel.SetActive(true);
            // Set text to You won!
            UIPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "You won!";
            enemy.SetActive(false); // use the direct reference
            won = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            Debug.Log("Game over");
            UIPanel.SetActive(true);
            // Set text to Game over
            UIPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "Game over";
            enemy.SetActive(false); // use the direct reference
            lost = true;
        }
    }

void Update()
{
    if (Input.GetKeyDown(KeyCode.Q))
    {
        Debug.Log("Q key was pressed. Restarting game...");
        if (won || lost)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
}
