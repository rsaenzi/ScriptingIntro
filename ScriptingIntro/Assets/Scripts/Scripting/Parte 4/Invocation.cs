using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invocation : MonoBehaviour {

    // -----------------------
    // Invocación de Funciones
    // -----------------------


    // Las funciones deben ser invocadas/llamadas/activadas para que sus
    // instrucciones internas sean ejecutadas

    // Una funcion puede ser invocada multiples veces

    // La invocacion de funciones se realiza desde otras funciones

    // El orden de ejecución de las funciones NO es en orden descendente


    void Asia() {
        print("Paises de Asia:");

        Japon();
        China();
        Filipinas();
    }

    void America() {
        print("Paises de America:");

        Mexico();
        Colombia();
        Argentina();
        Canada();
    }

    void Europa() {
        print("Paises de Europa:");

        Francia();
        Alemania();
        Grecia();
        Rusia();
    }

    void Alemania() {
        print("- Alemania");
    }

    void Argentina() {
        print("- Argentina");
    }

    void Canada() {
        print("- Canada");
    }

    void Colombia() {
        print("- Colombia");
    }

    void China() {
        print("- China");
    }

    void Filipinas() {
        print("- Filipinas");
    }

    void Francia() {
        print("- Francia");
    }

    void Grecia() {
        print("- Grecia");
    }

    void Japon() {
        print("- Japon");
    }

    void Mexico() {
        print("- Mexico");
    }

    void Rusia() {
        print("- Rusia");
    }


    void Awake() { // Esta funcion se invoca primero
        America();
        Europa();
        Asia();
    }




    // Ejemplo de invocacion de funciones que tienen parametros

    int multiplicar(int valorA, int valorB) {
        return valorA * valorB;
    }

    int restar(int valorA, int valorB) {
        return valorA - valorB;
    }

    int sumar(int valorA, int valorB) {
        return valorA + valorB;
    }

    int dividir(int valorA, int valorB) {
        return valorA / valorB;
    }


    void Start() { // Esta funcion se invoca primero

        // El resultado de las funciones con valor de retorno
        // usualmente se almacena en una variable

        int totalSuma = sumar(15, 3);
        print("La suma de los numeros es " + totalSuma);


        int totalResta = restar(15, 3);
        print("La resta de los numeros es " + totalSuma);


        int totalMultiplicacion = multiplicar(15, 3);
        print("La multiplicacion de los numeros es " + totalSuma);


        int totalDivision = dividir(15, 3);
        print("La division de los numeros es " + totalSuma);
    }




    // Ejemplo para el calculo de puntajes

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


    void OnEnable() { // Esta funcion se invoca primero

        // Mario
        int puntajeMario = CalcularPuntajeTotal(22, 15, 9, 10, 6, 38);
        print("El puntaje total de Mario es de " + puntajeMario + " puntos!");

        // Luigi
        int puntajeLuigi = CalcularPuntajeTotal(49, 20, 5, 62, 88, 91);
        print("El puntaje total de Luigi es de " + puntajeLuigi + " puntos!");

        // Peach
        int puntajePeach = CalcularPuntajeTotal(6, 57, 26, 29, 31, 10);
        print("El puntaje total de Peach es de " + puntajePeach + " puntos!");

        // Joshi
        int puntajeJoshi = CalcularPuntajeTotal(38, 90, 52, 28, 53, 26);
        print("El puntaje total de Joshi es de " + puntajeJoshi + " puntos!");

        // Toad
        int puntajeToad = CalcularPuntajeTotal(47, 71, 39, 18, 5, 60);
        print("El puntaje total de Toad es de " + puntajeToad + " puntos!");
    }



    // Las funciones Start(), Awake() y OnEnable() se invocan primero e
    // invocan a las demas funciones, ¿pero quien las invoca a ellas?

}