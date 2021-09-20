using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentOperators : MonoBehaviour {

    // ------------------------
    // Operadores de Asignación
    // ------------------------


    void Start() {

        // =	Assignment      x = 5
        // +=	Addition        x += 3  same as  x = x + 3	
        // -=	Subtraction     x -= 3  same as  x = x - 3	
        // *=	Multiplication  x *= 3  same as  x = x * 3	
        // /=	Division        x /= 3  same as  x = x / 3	
        // %=	Modulus         x %= 3  same as  x = x % 3


        // Assignment   =
        int rango = 50;
        int dinero = 300;
        float longitud = 25.34f;
        float distancia = 10; // 10.0f


        // Addition   +=
        rango = rango + 20;
        rango += 20;
        print("rango:" + rango);


        // Subtraction   -=
        longitud = longitud - 15.68f;
        longitud -= 15.68f;
        print("longitud:" + longitud);


        // Multiplication   *=
        distancia = distancia * 3.6f;
        distancia *= 3.6f;
        print("distancia:" + distancia);


        // Division   /=
        dinero = dinero / 25;
        dinero /= 25;
        print("dinero:" + dinero);


        // Modulus   %=
        int numero = 5;
        numero = numero % 2;
        numero %= 2;
        print("numero:" + numero);
    }
}