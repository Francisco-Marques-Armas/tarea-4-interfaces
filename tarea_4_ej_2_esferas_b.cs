using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea_4_ej_2_esferas_b : MonoBehaviour
{
    tarea_4_ej_2_cubo cubo_script;
    GameObject[] esferas_grupo_b;
    // Start is called before the first frame update
    void Start()
    {
        cubo_script = GameObject.Find("Cube").GetComponent<tarea_4_ej_2_cubo>();
        cubo_script.OnColisionEsferaA += IncreaseSize;
        esferas_grupo_b = GameObject.FindGameObjectsWithTag("GroupBSphere");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IncreaseSize() {
        for (int i = 0; i < esferas_grupo_b.Length; i++) {
            esferas_grupo_b[i].transform.localScale += new Vector3(2f, 2f, 2f);
        }
    }
}
