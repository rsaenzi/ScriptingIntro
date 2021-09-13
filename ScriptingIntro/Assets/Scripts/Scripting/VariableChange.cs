using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableChange : MonoBehaviour
{
    // - Asignación de Variables I:

    // La creacion de variables se hace dentro del
    // cuerpo del script, usualmente al inicio

    // El cambio del valor de las variables se hace
    // dentro de funciones, la cuales sirven para
    // agrupar instrucciones:

    public int estrellas = 0;
    public int corazones = 10;

    void Awake()
    {
        // Para la asignacion se usa el operador =
        estrellas = 50;
        corazones = 230;
    }
}
