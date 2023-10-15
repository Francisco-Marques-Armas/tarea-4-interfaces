using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea_4_ej_1_cubo : MonoBehaviour
{
    public delegate void ColisionCilindro();
    public event ColisionCilindro OnColisionCilindro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("BasicCylinder")) {
            OnColisionCilindro();
        }
    }
}
