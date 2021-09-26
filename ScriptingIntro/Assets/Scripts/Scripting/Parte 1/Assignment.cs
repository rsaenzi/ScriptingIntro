#pragma warning disable CS0414 // The field x is assigned but its value is never used

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment : MonoBehaviour {

    // -----------------------
    // Asignación de Variables
    // -----------------------


    // La creacion de variables se hace dentro del
    // cuerpo del script, usualmente al inicio

    int profundidadAgua = -80;
    float distanciaAlCentro = 23.67f;
    string nombre = "Katherine";
    bool nivelSuperado = false;

    // Si el valor inicial tambien se hace en
    // el Unity Editor, tiene prioridad este último

    public int estrellas = 0;
    public int corazones = 10;


    // El cambio del valor de las variables se hace
    // dentro de funciones, la cuales sirven para
    // agrupar instrucciones:

    void Awake() {

        // Para la asignacion se usa el operador =
        estrellas = 50;
        corazones = 230;

        // - Asignaciones erroneas
        //profundidadAgua = "Hola";
        //nombre = true;
        //nivelSuperado = 67.3f;
        //distanciaAlCentro = "Pedro";
    }
}