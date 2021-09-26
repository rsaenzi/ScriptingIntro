#pragma warning disable 0108 // Member hides inherited member

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotOperator : MonoBehaviour {

    // --------------------
    // Operador Punto
    // --------------------


    public Collider colliderEnemigo;

    public Transform transformPersonaje;

    public Rigidbody rigidbodyBossFinal;

    public SpriteRenderer rendererZombie;

    public Light luzSolar;


    void Start() {

        // Podemos leer o escribir los valores de cualquiera
        // de las propiedades (variables internas) de los objetos
        // para esto se utiliza el .


        // Lectura (copiar)

        bool orientacionZombieEnX = rendererZombie.flipX;

        bool orientacionZombieEnY = rendererZombie.flipY;

        Color colorSpriteZombie = rendererZombie.color;



        // Escritura (cambiar)

        rendererZombie.flipX = true;

        bool nuevaOrientacionEnY = false;
        rendererZombie.flipY = nuevaOrientacionEnY;

        rendererZombie.color = Color.green;



        // Ejemplos:

        // Vector3
        Vector3 ubicacion = new Vector3(0.5f, 0.8f, 14.63f);
        float coordX = ubicacion.x;

        Vector3 posicionEnemigo = new Vector3(6, 3, 2);
        posicionEnemigo.x = 23;
        posicionEnemigo.y = 12;
        posicionEnemigo.z = 45;


        // Transform
        transformPersonaje.position = new Vector3(0, 20, -3);
        transformPersonaje.eulerAngles = new Vector3(45, 0, 0);
        transformPersonaje.localScale = new Vector3(4, 7, 0);


        // Rigidbody
        rigidbodyBossFinal.mass = 23;
        rigidbodyBossFinal.useGravity = false;


        // Light
        luzSolar.color = new Color(0.0f, 0.0f, 1.0f);
        luzSolar.intensity = 0.7f;
        luzSolar.range = 5.89f;

        // Collider
        colliderEnemigo.enabled = false;
        colliderEnemigo.isTrigger = false;




        // Los objetos pueden contener Funciones, que son
        // grupos de instrucciones que cambian las variables
        // internas del objeto

        // Ejemplo:
        // Necesitamos mover un game object:
        //   3 mts a la derecha
        //   2 mts hacia arriba
        //   1 mt hacia adelante
        Vector3 movimiento = new Vector3(3, 2, 1);


        // Debemos copiar la posicion inicial del objeto
        Vector3 posicion = transformPersonaje.position;

        // Realizamos los calculos
        posicion.x = posicion.x + movimiento.x;
        posicion.y = posicion.y + movimiento.y;
        posicion.z = posicion.z + movimiento.z;

        // Actualizamos la posicion del personaje
        transformPersonaje.position = posicion;



        // Otra alternativa es buscar una funcion que ya tenga
        // esas instrucciones...

        transform.Translate(movimiento);


        // El operador . tambien permite invocar funciones, las
        // cuales ayudan a simplificar los scripts
    }
}