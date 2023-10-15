using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea_4_ej_3_esferas_b : MonoBehaviour
{
    tarea_4_ej_3_cubo cubo_script;
    GameObject[] esferas_grupo_a;
    GameObject quad;
    // Start is called before the first frame update
    void Start()
    {
        quad = GameObject.Find("Quad");
        cubo_script = GameObject.Find("Cube").GetComponent<tarea_4_ej_3_cubo>();
        cubo_script.OnColisionCilindro += LookTowardsObject;
        esferas_grupo_a = GameObject.FindGameObjectsWithTag("GroupASphere");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LookTowardsObject() {
        for (int i = 0; i < esferas_grupo_a.Length; i++) {
            esferas_grupo_a[i].transform.LookAt(quad.transform);
            Debug.Log("Looking towards" + quad.transform.position);
        }
    }
}
