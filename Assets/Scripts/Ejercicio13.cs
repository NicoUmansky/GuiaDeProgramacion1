using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    // 13. Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente
    // manera:
    //• Si trabaja 40 horas o menos se le paga $16 por hora(crear una constante para almacenar
    //el 16)
    //• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20
    //por cada hora extra. (crear una constante para almacenar el 20)
    //Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla
    //el salario correspondiente.

    public int horastrabajo;

    void Start()
    {
        int menos40 = horastrabajo * 16;
        int mas40 = 40 * 16 + (horastrabajo - 40) * 20;

        if (horastrabajo <= 40)
        {
            Debug.Log("Su salario semanal es de: $" + menos40);
        }
        else if (horastrabajo > 40)
        {
            Debug.Log("Su salario semanal es de: $" + mas40);
        }
    }
}
