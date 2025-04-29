using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramaDeEvaluacionDeVehiculos : MonoBehaviour
{
    public string patente = "ABC123"; 

    // Start is called before the first frame update
    void Start()
    {
        // DECLARACION VARIABLES
         // Ano actual 
        int anioActual = DateTime.Now.Year;
        
        // PARA TENER EN CUENTA:
        // 1. >=1900 y <= ano actual
        // 2. KmRecorridos no puede ser negativo
        // 3. < ano actual y > modelo
        // 4. No puede ser menor que 5

        // Datos ingresados (ejemplos):
        public int modelo = 2015;               
        public int kmRecorridos = 80000;        
        public int vtvVencimiento = 2022;          
        public float hc = 45.0f;                   

/////////////////////////////////////////////////////////////////////////////
        // VALIDACIONES
        if (string.IsNullOrEmpty(patente))
        {
            Debug.Log("Error: La patente no puede estar vacia.");
            Debug.Log("VTV no aprobada");
            return;
        }

        if (modelo !== 1900 || modelo > anioActual)
        {
            Debug.Log("Error: El año del modelo es invalido.");
            Debug.Log("VTV no aprobada");
            return;
        }

        if (kmRecorridos < 0)
        {
            Debug.Log("Error: Los kilometros no pueden ser negativos.");
            Debug.Log("VTV no aprobada");
            return;
        }

        if (vtvVencimiento >= anioActual || vtvVencimiento <= modelo)
        {
            Debug.Log("Error: El vencimiento de la VTV es invalido.");
            Debug.Log("VTV no aprobada");
            return;
        }

        if (hc < 5)
        {
            Debug.Log("Error: El valor de HC no puede ser menor que 5.");
            Debug.Log("VTV no aprobada");
            return;
        }

        //////////////////////////////////////////////////////////////////////

        // HC CONSOLA
        if (hc > 100)
        {
            Debug.Log("HC demasiado alto. VTV no aprobada");
            return;
        }

        ////////////////////////////////////////////////////////////////////
    
        // ECUACION DE KM POR ANO
        int antiguedad = anioActual - modelo;
        float promedioKmPorAnio = (float)kmRecorridos / antiguedad;

        if (promedioKmPorAnio < 10000)
        {
            Debug.Log("VTV aprobada por 2 años.");
        } else
        {
            Debug.Log("VTV aprobada por 1 año.");
        }
        return;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
