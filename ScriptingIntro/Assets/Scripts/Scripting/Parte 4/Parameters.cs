using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameters : MonoBehaviour {

    // ---------------------
    // Parametros de Entrada
    // y Valor de Retorno
    // ---------------------


    void MostarUbicacionEnemigo() {

        // Instrucción A
        // Instrucción B

        Vector2 ubicacionEnemigo = new Vector2(120, 50);

        print("La ubicación del enemigo es " + ubicacionEnemigo);

        // Instrucción C
        // Instrucción D
    }



    // Las funciones pueden recibir (o no) una o mas Variables de Entrada
    // tambien llamadas Parametros

    void CrearUsuario(string nombre, string apellido) {

        // Instrucción A
        // Instrucción B

        print("Usuario " + nombre + " " + apellido + " creado");

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

    float IndiceMasaCorporal(float peso, float estatura) {

        // Instrucción A
        // Instrucción B

        float indice = peso * (estatura * estatura); // IMC = kg / m2

        return indice;
    }
}