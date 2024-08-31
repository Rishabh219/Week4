using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;  // Renderer reference

    private int i = 4;

    void Start()
    {
        
    }

    void Update()
    {
        
        Debug.Log(gameObject.name + ":" + i);
        
        i++;
    }
}



