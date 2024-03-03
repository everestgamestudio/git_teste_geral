using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("Testing Successful!");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.LogWarning("Deu Certo");
        }
    }
}
