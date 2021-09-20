using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour
{
    // ----------------------
    // Operadores Lógicos
    // ----------------------


    void Start() {

        // && 	Logical and         x < 5 && x < 10
        //      Returns true if both statements are true
        //
        // || 	Logical or          x < 5 || x < 4
        //      Returns true if one of the statements is true
        //
        // !	Logical not         !(x < 5 && x < 10)
        //      Reverse the result, returns false if the result is true


        // Logical and      &&
        bool tienePlata = true;
        bool tieneNovia = true;
        bool esFeliz = tienePlata || tieneNovia;
        print("esFeliz:" + esFeliz);

        int edad = 45;
        bool esAdolescente = edad >= 10 && edad <= 19;
        print("esAdolescente:" + esAdolescente);


        // Logical or       ||
        bool haceEjercicio = true;
        bool comeSano = true;
        bool tieneBuenaSalud = haceEjercicio && comeSano;
        print("tieneBuenaSalud:" + tieneBuenaSalud);

        int estrellas = 50;
        int diamantes = 25;
        bool ganaNivel = estrellas > 20 || diamantes > 30;
        print("ganaNivel:" + ganaNivel);


        // Logical not      !
        bool comprarCarro = true;
        bool comprarCasa = !comprarCarro;
        print("comprarCasa:" + comprarCasa);
    }
}
