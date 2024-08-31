using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;  // Renderer reference

    private int i;
    private int randomValue;

    void Start()
    {
        i = 5;  // Initialize i to 5
        randomValue = Random.Range(150, 251);  // Generate a random integer between 150 and 250 inclusive
    }

    void Update()
    {
        Debug.Log(gameObject.name + "(Clone):" + i);
        i++;

        if (tag == "Red" && i >= 100)
        {
            // Deactivate the game object if tag is "Red" and i is 100 or more
            gameObject.SetActive(false);
        }
        else if (tag == "Blue" && i >= randomValue)
        {
            // Disable the Renderer component if tag is "Blue" and i is greater than or equal to the random value
            if (rend != null)
            {
                rend.enabled = false;
            }
        }
    }
}





