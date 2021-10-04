#pragma warning disable CS0414 // The field x is assigned but its value is never used
#pragma warning disable CS0219 // The variable x is assigned but its value is never used

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

    // ---------
    // Funciones
    // ---------


    // Functions, Methods, Blocks
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods

    /*

    Estructura de una función:

        <return_type> <name>(<parameters>)
        {
            <instruction>
            ...
            <instruction>

            <return>
        }


    */


    // Agrupacion de instrucciones, a la cual se le asigna un nombre
    // El nombre de una función suele tener la primera letra en mayuscula


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




    // Se suelen usar para agrupar dos o mas grupos de instrucciones
    // similares, es decir, son una forma de abstracción logica

    void PuntajePersonajes() {


        // Variables que influyen en el puntaje total alcanzado por Mario
        int monedasMario = 22;
        int estrellasMario = 15;
        int diamantesMario = 9;
        int cofresMario = 10;
        int ataquesMario = 6;
        int segundosMario = 38;

        // Por cada moneda recolectada por Mario se le dan 200 puntos
        int puntajeMario = monedasMario * 200;

        // Por cada estrella recolectada por Mario se le dan 150 puntos
        puntajeMario = puntajeMario + (estrellasMario * 150);

        // Por cada diamante recolectado por Mario se le dan 500 puntos
        puntajeMario = puntajeMario + (diamantesMario * 500);

        // Por cada cofre recolectado por Mario se le dan 75 puntos
        puntajeMario = puntajeMario + (cofresMario * 75);

        // Por cada ataque recibido por Mario se le quitan 10 puntos
        puntajeMario = puntajeMario - (ataquesMario * 10);

        // Por cada segundo jugado en el nivel se le quitan 2 puntos
        puntajeMario = puntajeMario - (segundosMario * 2);

        // Mostramos el puntaje total de Mario
        print("El puntaje total de Mario es de " + puntajeMario + " puntos!");





        // Variables que influyen en el puntaje total alcanzado por Luigi
        int monedasLuigi = 49;
        int estrellasLuigi = 20;
        int diamantesLuigi = 5;
        int cofresLuigi = 62;
        int ataquesLuigi = 88;
        int segundosLuigi = 91;

        // Por cada moneda recolectada por Luigi se le dan 200 puntos
        int puntajeLuigi = monedasLuigi * 200;

        // Por cada estrella recolectada por Luigi se le dan 150 puntos
        puntajeLuigi = puntajeLuigi + (estrellasLuigi * 150);

        // Por cada diamante recolectado por Luigi se le dan 500 puntos
        puntajeLuigi = puntajeLuigi + (diamantesLuigi * 500);

        // Por cada cofre recolectado por Luigi se le dan 75 puntos
        puntajeLuigi = puntajeLuigi + (cofresLuigi * 75);

        // Por cada ataque recibido por Luigi se le quitan 10 puntos
        puntajeLuigi = puntajeLuigi - (ataquesLuigi * 10);

        // Por cada segundo jugado en el nivel se le quitan 2 puntos
        puntajeLuigi = puntajeLuigi - (segundosLuigi * 2);

        // Mostramos el puntaje total de Luigi
        print("El puntaje total de Luigi es de " + puntajeLuigi + " puntos!");





        // Variables que influyen en el puntaje total alcanzado por Peach
        int monedasPeach = 6;
        int estrellasPeach = 57;
        int diamantesPeach = 26;
        int cofresPeach = 29;
        int ataquesPeach = 31;
        int segundosPeach = 10;

        // Por cada moneda recolectada por Peach se le dan 200 puntos
        int puntajePeach = monedasPeach * 200;

        // Por cada estrella recolectada por Peach se le dan 150 puntos
        puntajePeach = puntajePeach + (estrellasPeach * 150);

        // Por cada diamante recolectado por Peach se le dan 500 puntos
        puntajePeach = puntajePeach + (diamantesPeach * 500);

        // Por cada cofre recolectado por Peach se le dan 75 puntos
        puntajePeach = puntajePeach + (cofresPeach * 75);

        // Por cada ataque recibido por Peach se le quitan 10 puntos
        puntajePeach = puntajePeach - (ataquesPeach * 10);

        // Por cada segundo jugado en el nivel se le quitan 2 puntos
        puntajePeach = puntajePeach - (segundosPeach * 2);

        // Mostramos el puntaje total de Peach
        print("El puntaje total de Peach es de " + puntajePeach + " puntos!");





        // Variables que influyen en el puntaje total alcanzado por Joshi
        int monedasJoshi = 38;
        int estrellasJoshi = 90;
        int diamantesJoshi = 52;
        int cofresJoshi = 28;
        int ataquesJoshi = 53;
        int segundosJoshi = 26;

        // Por cada moneda recolectada por Joshi se le dan 200 puntos
        int puntajeJoshi = monedasJoshi * 200;

        // Por cada estrella recolectada por Joshi se le dan 150 puntos
        puntajeJoshi = puntajeJoshi + (estrellasJoshi * 150);

        // Por cada diamante recolectado por Joshi se le dan 500 puntos
        puntajeJoshi = puntajeJoshi + (diamantesJoshi * 500);

        // Por cada cofre recolectado por Joshi se le dan 75 puntos
        puntajeJoshi = puntajeJoshi + (cofresJoshi * 75);

        // Por cada ataque recibido por Joshi se le quitan 10 puntos
        puntajeJoshi = puntajeJoshi - (ataquesJoshi * 10);

        // Por cada segundo jugado en el nivel se le quitan 2 puntos
        puntajeJoshi = puntajeJoshi - (segundosJoshi * 2);

        // Mostramos el puntaje total de Joshi
        print("El puntaje total de Joshi es de " + puntajeJoshi + " puntos!");





        // Variables que influyen en el puntaje total alcanzado por Toad
        int monedasToad = 47;
        int estrellasToad = 71;
        int diamantesToad = 39;
        int cofresToad = 18;
        int ataquesToad = 5;
        int segundosToad = 60;

        // Por cada moneda recolectada por Toad se le dan 200 puntos
        int puntajeToad = monedasToad * 200;

        // Por cada estrella recolectada por Toad se le dan 150 puntos
        puntajeToad = puntajeToad + (estrellasToad * 150);

        // Por cada diamante recolectado por Toad se le dan 500 puntos
        puntajeToad = puntajeToad + (diamantesToad * 500);

        // Por cada cofre recolectado por Toad se le dan 75 puntos
        puntajeToad = puntajeToad + (cofresToad * 75);

        // Por cada ataque recibido por Toad se le quitan 10 puntos
        puntajeToad = puntajeToad - (ataquesToad * 10);

        // Por cada segundo jugado en el nivel se le quitan 2 puntos
        puntajeToad = puntajeToad - (segundosToad * 2);

        // Mostramos el puntaje total de Toad
        print("El puntaje total de Toad es de " + puntajeToad + " puntos!");
    }



    // Esta funcion evita la repeticion de las instrucciones anteriores

    int CalcularPuntajeTotal(int monedas, int estrellas, int diamantes, int cofres, int ataques, int segundos) {

        // Por cada moneda recolectada por el personaje se le dan 200 puntos
        int puntaje = monedas * 200;

        // Por cada estrella recolectada por el personaje se le dan 150 puntos
        puntaje = puntaje + (estrellas * 150);

        // Por cada diamante recolectado por el personaje se le dan 500 puntos
        puntaje = puntaje + (diamantes * 500);

        // Por cada cofre recolectado por el personaje se le dan 75 puntos
        puntaje = puntaje + (cofres * 75);

        // Por cada ataque recibido por el personaje se le quitan 10 puntos
        puntaje = puntaje - (ataques * 10);

        // Por cada segundo jugado en el nivel se le quitan 2 puntos
        puntaje = puntaje - (segundos * 2);

        // Retornamos el puntaje total de el personaje
        return puntaje;
    }
}