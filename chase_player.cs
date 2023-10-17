using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chase_player : MonoBehaviour
{
    public NavMeshAgent agent;
    Vector3 playerPos;
    public GameObject UIPanel;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = GameObject.Find("Capsule").transform.position;
        agent.SetDestination(playerPos); 
    }

}
