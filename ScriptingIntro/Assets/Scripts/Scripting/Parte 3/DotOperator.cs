using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Member hides inherited member
#pragma warning disable 0108

public class DotOperator : MonoBehaviour {

    // --------------------
    // Operador Punto
    // --------------------


    // El tipo de una variable u objeto, tambien se conoce como Class o Clase
    public Collider collider;

    public Transform transformPersonaje;

    public Rigidbody rigidbodyBossFinal;

    public SpriteRenderer zombie;

    public Light luzSolar;


    void Start() {

        // Podemos obtener o asignar valores a las propiedades de los objetos
        // Para esto se utiliza el .

        // Aca estamos accediendo o leyendo el contenido de la variable bounds
        print(collider.bounds);

        // Aca estamos asignando un valor a la variable enabled
        collider.enabled = false;


        // Tambien podemos invocar o ejecutar las funciones que 
        // tiene la clase Collider. Tambien se usa el .
        int id = collider.GetInstanceID();
        string name = collider.ToString();

        // Ejemplos:

        // int
        int salario = 500;
        salario.ToString();

        // String
        string nombre = "Rigoberto";
        print(nombre.Length);

        // Vector3
        Vector3 ubicacion = new Vector3(0.5f, 0.8f, 14.63f);
        float coordX = ubicacion.x;
        print(coordX);

        Vector3 posicionEnemigo = new Vector3(6, 3, 2);
        posicionEnemigo.x = 23;
        posicionEnemigo.y = 12;

        // Transform
        transformPersonaje.position = new Vector3(0, 20, -3);
        transformPersonaje.eulerAngles = new Vector3(45, 0, 0);
        transformPersonaje.position = new Vector3(4, 7, 0);

        // Rigidbody
        rigidbodyBossFinal.mass = 23;

        // Light
        luzSolar.color = new Color(0.0f, 0.0f, 1.0f);

        // Sprite Renderer
        zombie.flipX = true;
    }
}