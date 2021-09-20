using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour
{
    // -------
    // Consola
    // -------


    void Start () {

        // - Tipos de Mensajes:

        // Mensaje Informativo
        Debug.Log("Este texto será mostrado en la consola como un mensaje informativo, es muy util!");

        // Mensaje de Advertencia
        Debug.LogWarning("Ha sucedido un una situacion no esperada");

        // Mensaje de Error
        Debug.LogError("Ha sucedido un error");


        // Version corta de Debug.Log
        print("Este texto también será impreso como mensaje informativo...");



        // - Contenido de Variables:

        // Impresion del contenido de una variable
        int edad = 23;
        print("Mi edad es " + edad + " años");

        float rotation = 90.33f;
        Debug.LogWarning("Rotacion minima requerida: " + rotation + " grados");

        string colorFavorito = "Azul Turquesa";
        Debug.Log("Mi color favorito es el " + colorFavorito);

        bool pocionMagicaActiva = true;
        print("¿Pocion magica activa?" + pocionMagicaActiva);


        print("Mi edad es " + edad + " años, y mi color favorito es el " + colorFavorito);
    }
}