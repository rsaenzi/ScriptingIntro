using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparisonOperators : MonoBehaviour
{
    // -------------------------
    // Operadores de Comparación
    // -------------------------

    void Start() {

        // ==	Equal to	                x == y
        // !=	Not equal	                x != y
        // >	Greater than	            x > y
        // <	Less than	                x < y
        // >=	Greater than or equal to	x >= y
        // <=	Less than or equal to	    x <= y


        // Equal to   ==
        float energiaMario = 46.78f;
        float energiaLuigi = 46.21f;
        bool tienenLaMismaEnergia = energiaMario == energiaLuigi;
        print("tienenLaMismaEnergia:" + tienenLaMismaEnergia);

        string celularJimena = "iPhone 13 Pro";
        string celularLaura = "Galaxy S21 Ultra";
        bool tieneElMismoCelular = celularJimena == celularLaura;
        print("tieneElMismoCelular:" + tieneElMismoCelular);

        int fuerzaDeSalto = 45;
        bool fuerzaEsIgualA45 = fuerzaDeSalto == 45;
        print("fuerzaEsIgualA45:" + fuerzaEsIgualA45);


        // Not equal   !=
        bool tienenDiferenteEnergia = energiaMario != energiaLuigi;
        print("tienenDiferenteEnergia:" + tienenDiferenteEnergia);


        // Greater than   >
        int edadJuan = 20;
        int edadMaria = 25;
        bool juanEsMayor = edadJuan > edadMaria;
        print("juanEsMayor:" + juanEsMayor);


        // Less than   <
        bool mariaEsMayor = edadJuan < edadMaria;
        print("mariaEsMayor:" + mariaEsMayor);


        // Greater than or equal to   >=
        float longitudPista = 300.0f;
        float distanciaRecorrida = 310.0f;
        bool metaSuperada = distanciaRecorrida >= longitudPista;
        print("metaSuperada:" + metaSuperada);


        // Less than or equal to   <=
        float rangoAtaqueEnemigo = 3.5f;
        float distanciaAlEnemigo = 4.2f;
        bool enemigoDebeAtacar = distanciaAlEnemigo <= rangoAtaqueEnemigo;
        print("enemigoDebeAtacar:" + enemigoDebeAtacar);
    }
}
