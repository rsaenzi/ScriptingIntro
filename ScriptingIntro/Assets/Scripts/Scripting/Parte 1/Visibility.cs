using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility : MonoBehaviour {

    // ------------------------
    // Visibilidad de Variables
    // ------------------------


    // Si quieren ver la variables en el Unity Editor, ventana
    // Inspector se debe agregar la palabra public antes del tipo

    public int cantidadBalas = 20;

    public float alturaEdificio = 35.5f;

    public string nombreJugador = "Carlos";

    public bool lanzallamasActivo = false;


    // Las variables marcadas como public pueden tener tooltips
    // que son frases cortas descriptivas a ser mostradas en
    // el Unity Editor

    [Tooltip("Cantidad de gemas recolectadas por el usuario")]
    public int gemas = 5;
}