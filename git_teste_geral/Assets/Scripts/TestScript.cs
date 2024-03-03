using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public Text dinheiro;

    public int dinheirou;


    private void Awake()
    {
        dinheirou = 1000;
    }

    // Update is called once per frame
    void Update()
    {

        dinheiro.text = "Dinheiro: " + dinheirou;

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
