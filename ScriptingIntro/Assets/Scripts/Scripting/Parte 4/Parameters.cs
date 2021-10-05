using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameters : MonoBehaviour {

    // ---------------------
    // Parametros de Entrada
    // y Valor de Retorno
    // ---------------------


    void CalcularUbicacionEnemigo() {

        // Instrucción A
        // Instrucción B

        float coordenadaX = 45 / 6;
        float coordenadaY = 175 * 4;

        Vector2 ubicacionEnemigo = new Vector2(coordenadaX, coordenadaY);
        print("La ubicación del enemigo es " + ubicacionEnemigo);

        // Instrucción C
        // Instrucción D
    }



    // Las funciones pueden recibir (o no) una o mas Variables de Entrada
    // tambien llamadas Parametros

    void NombreUsuario(string nombres, string primerApellido, string segundoApellido) {

        // Instrucción A
        // Instrucción B

        string nombreCompleto = nombres + " " + primerApellido + " " + segundoApellido;
        print("El nombre completo es " + nombreCompleto);

        // Instrucción C
        // Instrucción D
    }



    // Las funciones pueden Retornar un valor (o no)

    int SaldoSalario() {

        // Instrucción A
        // Instrucción B

        int salario = 500;
        int impuestos = 45;
        int prima = 60;

        int total = salario - impuestos + prima;

        return total;
    }



    // Ejemplo de funcion con parametros y retorno de valor

    // IMC = kg / m2
    float IndiceMasaCorporal(float peso, float estatura) {

        // Instrucción A
        // Instrucción B

        float estaturaAlCuadrado = estatura * estatura;
        float indice = peso * estaturaAlCuadrado;

        return indice;
    }
}