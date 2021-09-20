using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionOrder : MonoBehaviour
{
    // ------------------
    // Orden de Ejecución
    // ------------------


    int profundidadAgua = -80;
    float distanciaAlCentro = 23.67f;
    string nombre = "Katherine";
    bool nivelSuperado = false;
    

    void Start()
    {
        // El contenido de una variable puede cambiar
        // tantas veces como se quiera
        profundidadAgua = -50;

        profundidadAgua = -30;

        profundidadAgua = -25;

        distanciaAlCentro = 0.345f;

        nombre = "Diana Marcela";

        nivelSuperado = true;

        distanciaAlCentro = 5.78f;


        // - Orden de Ejecucion
        // Por defecto, todas las instrucciones se ejecutan
        // de manera secuencial, una por una, en orden descendente


        // Para utilizar una variable, debe ser declarada (creada) primero
        //longitud = 34;
        //int longitud;
    }
}
