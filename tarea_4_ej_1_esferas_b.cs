using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea_4_ej_1_esferas_b : MonoBehaviour
{
    public float speed = 10.0f;    
    Vector3 cylinderPosition = Vector3.zero;
    Vector3[] cylinderDirections;
    tarea_4_ej_1_cubo cubo_script;
    GameObject[] esferas_grupo_b;
    
    // Start is called before the first frame update
    void Start()
    {
        esferas_grupo_b = GameObject.FindGameObjectsWithTag("GroupBSphere");
        // Initialize cylinderDirections
        cylinderDirections = new Vector3[esferas_grupo_b.Length];
        cubo_script = GameObject.Find("Cube").GetComponent<tarea_4_ej_1_cubo>();
        cubo_script.OnColisionCilindro += MoveToCylinder;
        cylinderPosition = GameObject.Find("Cylinder").transform.position;
        for (int i = 0; i < esferas_grupo_b.Length; i++) {
            cylinderDirections[i] = cylinderPosition - esferas_grupo_b[i].transform.position;
            cylinderDirections[i].Normalize();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveToCylinder() {
        for (int i = 0; i < esferas_grupo_b.Length; i++) {
            esferas_grupo_b[i].transform.Translate(cylinderDirections[i] * speed * Time.deltaTime);
        }
    }
}
