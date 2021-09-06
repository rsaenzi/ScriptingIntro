using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTypes : MonoBehaviour
{
    // - Variables:

    // Tambien conocidas como Propiedades, Objetos, Instancias
    // Son espacios dentro de la RAM para guardar un dato


    // Para crear una variable se sigue el siguiente formato:
    //    type variableName = value;


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
    // y son destruidas cuando el videojuegotermina

    // El dato almacenado en la variable se llama 'valor'

    // El valor de una variable puede cambiar durante la
    // ejecucion del videojuego


    // Las variables deben ser nombradas siguiendo las siguientes reglas:
    // 1. Puede contener letras, digitos y _
    // 2. Debe iniciar con una letra
    // 3. No puede tener espacios en blanco
    // 4. Deberia iniciar con una letra minuscula
    // 5. Si es una frase, cada letra iniciar deberia ser mayuscula
    // 6. Sensibles a mayusculas y minusculas
    // 7. No puede ser igual a una palabra reservada:
    //    https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/


    // Si quieren ver la variables en el Unity Editor, ventana
    // Inspector se debe agregar la palabra public antes del tipo

    public int cantidadBalas = 20;

    public float alturaEdificio = 35.5f;

    public string nombreJugador = "Carlos";

    public bool lanzallamasActivo = false;


    // Las variables marcadas como public pueden tener tooltips
    // que son frases cortas descriptivas a ser mostradas en
    // el Unity Editor

    [Tooltip("Cantidad de gemas recolectadas por el usuario")]
    public int gemas = 5;


    // Se recomienda que siempre las variables tengan un valor inicial

    float peso; // No recomendado, puede generar errores
}
