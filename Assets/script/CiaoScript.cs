using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CiaoScript : MonoBehaviour
{
    public int volte = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            volte++;
            Debug.LogFormat("Ciao sono un cubo, mi hai premuto {0} volte", volte);
        }
    }
}
