using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour {

	void Start () {

        // - Mensajes Informativos:

        // Impresion de Info en consola
        Debug.Log("Este texto será mostrado en la consola, es muy util!");

        // Version corta de Debug.Log
        print("Este texto también será impreso...");

        // Impresion de un Warning en consola
        Debug.LogWarning("Ha sucedido un una situacion no esperada");



        // - Mensajes de Error:

        // Impresion de un Error en consola
        Debug.LogError("Ha sucedido un error");



        // - Contenido de Variables:

        // Impresion del contenido de una variable
        int edad = 23 * 7 + 57 - 12;
        print("Mi edad es " + edad);

        Vector3 ubicacion = Vector3.right;
        ubicacion.x = edad / 8 * 5 + 3;
        print("Mi ubicación es " + ubicacion);
	}
}