using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // ---------
    // Variables
    // ---------


    // Tambien conocidas como Propiedades, Objetos, Instancias
    // Son espacios dentro de la RAM para guardar un dato


    // Para crear una variable se sigue el siguiente formato:
    //   type variableName = value;


    // Existen varios tipos de variables segun la naturaleza
    // del dato a almacenar, a continuación se listan los tipos
    // principales:

    // int : Número entero positivo o negativo
    int puntajeTotal = 45;


    // float : Número decimal positivo o negativo
    float distanciaAlCheckpoint = 45.678f;


    // string : Texto de uno o mas caracteres
    string dialogoBienvenida = "Guerrero, ¡el mundo necesita tu ayuda!";


    // bool : Valor booleano: Verdadero (true) o Falso (false)
    bool powerUpActivado = true;


    // Las variables son creadas cuando el videojuego es ejecutado
    // y son destruidas cuando el videojuego termina

    // El dato almacenado en la variable se llama 'valor'
    // El valor de una variable puede cambiar durante la
    // ejecucion del videojuego


    // Las variables deben ser nombradas siguiendo las siguientes reglas:
    // 1. No pueden existir dos variables con el mismo nombre
    // 2. Puede contener letras (mayusculas y minusculas), digitos y _
    // 3. No puede iniciar con un número
    // 4. No puede tener espacios en blanco
    // 5. No puede ser igual a una palabra reservada:
    //    https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/

    //public string break = "Hola";
    //public bool catch = true;



    // Recomendaciones:
    // 1. Sensibles a mayusculas y minusculas
    // 2. Deberia iniciar con una letra minuscula
    // 3. Si es una frase, cada letra iniciar deberia ser mayuscula


    // Se recomienda que siempre las variables tengan un valor inicial

    float peso; // No recomendado, puede generar errores
}
