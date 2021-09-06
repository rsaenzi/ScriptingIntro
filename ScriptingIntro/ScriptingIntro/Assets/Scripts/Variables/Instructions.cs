using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    // - Instrucciones:

    // Las instrucciones tambien son llamadas Comandos o Statements
    // Pueden ser de dos tipos: Una linea y Multilinea


    // - Instrucciones de una linea:
    // Deben terminar con un ;

    int vidas = 5;

    float diamantes = 20;

    string nombreJugador = "Carolina";

    Color colorDeLinea = Color.blue;


    // Las instrucciones de una sola linea pueden estar acompañadas
    // de un comentario de una linea despues del ;

    int escudos = 2; // Los escudos dan inmunidad por 5 segundos


    // - Instrucciones multilinea:
    // Sirven para agrupar instrucciones, tienen cuerpo,
    // delimitado por {}

    void AgregarDiamante() {
        diamantes += 1;
    }

    void EstadoDeSalud() {

        if(vidas == 0) {
            print("Haz perdido el nivel");
        }
    }

    void CrearEnemigos() {

        for (int i = 0; i < 5; i++) {
            print("Enemigo creado");
        }
    }
}