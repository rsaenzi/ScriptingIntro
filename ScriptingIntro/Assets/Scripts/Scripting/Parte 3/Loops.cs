using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

    // ------
    // Ciclos
    // ------


    void Awake() {

        // Estructuras ciclicas, Loops, Operadores de Iteracion
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/iteration-statements

        /*
        
        La estructura de los ciclos es muy similar a la de los
        condicionales IF

            if () {
            
            }


            while () {

            }

        */



        // Loop WHILE
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while

        // Instrucción A
        // Instrucción B

        // Al inicio, no tenemos plata ahorrada
        int plataAhorrada = 0;

        // La meta es conseguir al menos 50000 pesos...
        while (plataAhorrada < 50000) {

            // Agregamos 10000 pesos al ahorro
            plataAhorrada = plataAhorrada + 10000;
        }

        print("Plata Ahorrada: " + plataAhorrada);

        // Instrucción C
        // Instrucción D



        // Los ciclos se suelen usan junto con variables contadoras
        // para ejecutar un conjunto de instrucciones una determinada
        // cantidad de veces
        int gemas = 0;

        while (gemas < 3) {
            print("Gema #" + gemas + " creada");

            // La variable contadora se incrementa en 1
            gemas++;
        }



        // Error tipico: Que la condicion siempre sea true
        /*
        bool condicion = 5 > 3;

        while (condicion == true) {
            print("Hola!");
        }
        */
    }

    void Start() {

        // Loop FOR
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for

        // Es una forma compacta del ciclo While con contadores
        for (int gemas = 0; gemas < 3; gemas++) {
            print("Gema #" + gemas + " creada");
        }

        /*
        Equivalente del anterior ciclo FOR usando un ciclo WHILE


        int gemas = 0;

        while (gemas < 3) {
            print("Gema #" + gemas + " creada");
            gemas++;
        }

        */
    }
}