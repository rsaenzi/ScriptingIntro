using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// private field assigned but not used.
#pragma warning disable 0414
#pragma warning disable 0219

public class Functions : MonoBehaviour {

    // - Funciones:
    // Agrupacion de instrucciones, a la cual se le asigna un nombre

    void Update() {
        // Instrucción X
        // Instrucción Y
        // Instrucción Z
    }

    void Start() {
        // Instrucción 1
        // Instrucción 2
        // Instrucción 3
        // Instrucción 4
    }

    void CalculoPuntaje() {
        // Instrucción A
        // Instrucción B
    }



    // - Alcance de Variables:
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



    // - Orden de Ejecucion:
    // Su ejecucion no sigue el mismo orden que las instrucciones
    // sino que depende del Orden de Ejecucion de Funciones de Unity




    // Las funciones pueden recibir una o mas Variables de Entrada
    void CrearUsuario(int edad, string saludo) {
        // Instruccion 1
        // Instruccion 2
        // Instruccion 3
    }

    // Las funciones pueden Retornar una un valor
    int CalculoDeEdad() {
        // Instruccion X
        // Instruccion Y
        // Instruccion X

        // Aqui se retorna el numero 6 a
        // quien haya invocado esta funcion
        int edad = 6;
        return edad;
    }

    // Las funciones pueden recibir variables, ejecutar sus 
    // operaciones y finalmente retornar un valor de tipo float
    float CalculoDeDistancia(Vector2 puntoA, Vector2 puntoB) {
        // Instruccion A
        // Instruccion B
        // Instruccion C
        return 78.6f;
    }

    // Ejemplos:
    int Suma(int numeroA, int numeroB) {
        return numeroA + numeroB;
    }

    int Resta(int numeroA, int numeroB) {
        return numeroA - numeroB;
    }


    // Como invoco o ejecuto estas funciones?
    void OnEnable() {

        // Funcion que recibe variables de entrada
        CrearUsuario(45, "Hola");

        // Funcion que retorna un valor
        int edadPedro = CalculoDeEdad();
        print(edadPedro);

        // Funcion que recibe variables de entrada y retorna una valor
        int total = Suma(30, 20);
        print(total);

        // Otro ejemplo
        Vector2 posicionPersonaje = new Vector2(25, -70);
        Vector2 posicionEnemigo = new Vector2(56, 32);

        float distanciaEntreEllos = CalculoDeDistancia(posicionPersonaje, posicionEnemigo);
        print(distanciaEntreEllos);
    }
}