using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea_4_ej_2_cubo : MonoBehaviour
{
    public delegate void ColisionNotEsferaA();
    public event ColisionNotEsferaA OnColisionNotEsferaA;
    public delegate void ColisionEsferaA();
    public event ColisionEsferaA OnColisionEsferaA;
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
        if (other.collider.CompareTag("GroupASphere")) {
            OnColisionEsferaA();
        }
        else {
            OnColisionNotEsferaA();
        }
    }

}
