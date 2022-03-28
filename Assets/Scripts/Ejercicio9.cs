using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    //9. Realizá un programa que resuelva el siguiente problema:  Tres personas aportan diferente capital a una sociedad.
    //   Se desea saber qué porcentaje del total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.
    //   Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
    //   Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 

    // Start is called before the first frame update

    public float persona1, persona2, persona3;
    void Start()
    {
        Debug.Log("Nombre: Persona1, Capital Aportado: $" + persona1 + ", Porcentaje del capital: %" + persona1 / (persona1 + persona2 + persona3) * 100 + ", Monto total aportado: $" + (persona1 + persona2 + persona3));
        Debug.Log("Nombre: Persona2, Capital Aportado: $" + persona2 + ", Porcentaje del capital: %" + persona2 / (persona1 + persona2 + persona3) * 100 + ", Monto total aportado: $" + (persona1 + persona2 + persona3));
        Debug.Log("Nombre: Persona2, Capital Aportado: $" + persona3 + ", Porcentaje del capital: %" + persona3 / (persona1 + persona2 + persona3) * 100 + ", Monto total aportado: $" + (persona1 + persona2 + persona3));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
