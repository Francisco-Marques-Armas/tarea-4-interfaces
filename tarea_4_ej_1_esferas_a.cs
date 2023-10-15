using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea_4_ej_1_esferas_a : MonoBehaviour
{
    tarea_4_ej_1_cubo cubo_script;
    GameObject[] esferas_grupo_a;
    // Start is called before the first frame update
    void Start()
    {
        cubo_script = GameObject.Find("Cube").GetComponent<tarea_4_ej_1_cubo>();
        cubo_script.OnColisionCilindro += ChangeColor;
        esferas_grupo_a = GameObject.FindGameObjectsWithTag("GroupASphere");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeColor() {
        for (int i = 0; i < esferas_grupo_a.Length; i++) {
            esferas_grupo_a[i].GetComponent<Renderer>().material.color = new Color(0.0f, 0.0f, 1.0f);
        }
    }
}
