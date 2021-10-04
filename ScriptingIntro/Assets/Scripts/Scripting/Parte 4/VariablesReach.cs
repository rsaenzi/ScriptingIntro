#pragma warning disable CS0219 // The variable x is assigned but its value is never used
#pragma warning disable CS0414 // The field x is assigned but its value is never used

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesReach : MonoBehaviour {

    // --------------------
    // Alcance de Variables
    // --------------------


    // Las variables creadas por fuera de las funciones son visibles
    // para todas las funciones

    int puntaje = 500;

    void FuncionA() {

        // Tan pronto como la funcion acabe su ejecucion,
        // la variable es eliminada de la memoria RAM
        int vidas = 10;
    }

    void FuncionB() {
        // puntaje = 800;
        // vidas = 20;
    }
}