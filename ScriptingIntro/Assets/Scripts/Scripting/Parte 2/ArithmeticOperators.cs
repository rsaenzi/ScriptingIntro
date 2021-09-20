using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArithmeticOperators : MonoBehaviour
{
    // ----------------------
    // Operadores Aritmeticos
    // ----------------------

    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/

    void Start() {

        //      Concatenation   Joins strings together                      "string" + "string"

        // +	Addition	    Adds together two values	                x + y
        // -	Subtraction	    Subtracts one value from another	        x - y
        // *	Multiplication	Multiplies two values	                    x * y
        // /	Division	    Divides one value by another	            x / y
        // %	Modulus	        Returns the division remainder	            x % y
        // ++	Increment	    Increases the value of a variable by 1	    x++
        // --	Decrement	    Decreases the value of a variable by 1	    x--


        // Concatenation   +
        string parteA = "Hola ";
        string parteB = "como estas?";

        string mensaje = parteA + parteB;
        print("mensaje:" + mensaje);

        // print() muestra el contenido de la variable
        int numeroEntero = 20;
        print("numero entero:" + numeroEntero);


        // Addition   +
        int distancia = 40 + 20;
        print("distancia:" + distancia);

        int salario = 200;
        int prima = 300;
        int bono = 10;

        int total = salario + prima;
        total = total + bono + 15; // subsidio transporte
        print("total:" + total);

         
        // Subtraction   -
        int impuestos = 200;
        int saldo = salario - impuestos;
        saldo = saldo - 10; // iva
        print("saldo:" + saldo);


        // Multiplication   *
        float alto = 45.7f;
        float ancho = 72.834f;
        float area = alto * ancho;
        print("area:" + area);


        // Division   /
        int manzanas = 100;
        int personas = 3;

        int manzanasPorPersona = manzanas / personas;
        print("manzanasPorPersona:" + manzanasPorPersona);


        // Modulus   %
        int manzanasQueSobran = manzanas % personas;
        print("manzanasQueSobran:" + manzanasQueSobran);


        // Increment   ++
        int edadDiana = 20;
        edadDiana++;
        print("edadDiana:" + edadDiana);


        // Decrement   --
        int edadPedro = 20;
        edadPedro++;
        print("edadPedro:" + edadPedro);
    }
}
