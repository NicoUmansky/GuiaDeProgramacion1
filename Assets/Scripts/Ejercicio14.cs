using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio14 : MonoBehaviour
{

    public string operador;
    public int num1;
    public int num2;

    void Start()
    {
        switch (operador)
        {
            case "s":
                Debug.Log(num1 + num2);
                break;
            case "r":
                Debug.Log(num1 - num2);
                break;
            case "p":
                Debug.Log(num1 * num2);
                break;
            case "d":
                Debug.Log(num1 / num2);
                break;
            default:
                Debug.Log("No valido");
                break;
        }
    }
}

