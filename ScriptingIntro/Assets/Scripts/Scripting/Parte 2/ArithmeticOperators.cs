using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArithmeticOperators : MonoBehaviour
{
    // ----------------------
    // Operadores Aritmeticos
    // ----------------------

    void Start() {

        // +	Addition	    Adds together two values	                x + y
        // -	Subtraction	    Subtracts one value from another	        x - y
        // *	Multiplication	Multiplies two values	                    x * y
        // /	Division	    Divides one value by another	            x / y
        // %	Modulus	        Returns the division remainder	            x % y
        // ++	Increment	    Increases the value of a variable by 1	    x++
        // --	Decrement	    Decreases the value of a variable by 1	    x--


        // +	Addition
        int distancia = 40 + 20;

        int salario = 200;
        int prima = 300;
        int bono = 10;

        int total = salario + prima;
        total = total + bono + 15; // subsidio transporte


        // -	Subtraction
        int impuestos = 200;
        int saldo = salario - impuestos;

        saldo = saldo - 10; // iva


        // *	Multiplication


        // /	Division


        // %	Modulus


        // ++	Increment


        // --	Decrement


    }
}
