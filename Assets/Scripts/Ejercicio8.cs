using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    //8. Crear una variable entera que pueda ser modificada desde el Inspector.Suponiendo que el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente
    //al valor de la variable “dia”. Si el día no está en el rango  permitido debe emitir por pantalla el mensaje de error "El día ingresado no es válido". 


    // Start is called before the first frame update

    public int dia;

    void Start()
    {
        if (dia == 1)
        {
            Debug.Log("Hoy es Domingo");
        }
        if (dia == 2)
        {
            Debug.Log("Hoy es Lunes");
        }
        if (dia == 3)
        {
            Debug.Log("Hoy es Martes");
        }
        if (dia == 4)
        {
            Debug.Log("Hoy es Miercoles");
        }
        if (dia == 5)
        {
            Debug.Log("Hoy es Jueves");
        }
        if (dia == 6)
        {
            Debug.Log("Hoy es Viernes");
        }
        if (dia == 7)
        {
            Debug.Log("Hoy es Sabado");
        }
        if (dia > 7)
        {
            Debug.Log("El d[ia ingresado no es valido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
