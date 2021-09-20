using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructors : MonoBehaviour
{
    // - Variables Compuestas

    // Las variables se pueden agrupar en variables compuestas
    // tambien llamadas objetos, para asignar el valor inicial
    // se utilizan constructores:

    public Vector2 tamanoCuadrado = new Vector2(7, 8);

    public Vector3 ubicacion = new Vector3(45, -5, 0);

    public Color colorDeCabello = new Color(0.5f, 0.2f, 0.7f);


    // Los componentes de Unity son variables compuestas
    // Nota: Saldrán errores al ejecutar el videojuego

    public Transform transformEnemigo;

    public Rigidbody rigidbodyCubo;

    public Collider colliderAliado;

    public ParticleSystem lluvia;

    public Light luzDelSol;

    public SpriteRenderer bossFinal;

    // Estas variables pueden tomar su valor inicial desde el
    // Unity Editor, soltando el componente encima del script


    // Las variables compuestas pueden tener por dentro variables
    // simples y compuestas, generando asi una jerarquia de datos

    public GameObject capsula3D;


    void Start()
    {
        // Las variables compuestas tambien pueden cambiar
        // tantas veces como se quiera

        tamanoCuadrado = new Vector2(10.6f, 25.78f);

        colorDeCabello = new Color(0.2f, 0.0f, 1.0f);


        // Algunas variables tienen versiones cortas de sus
        // constructores
        Vector3 posicionInicialA = new Vector3(1, 0, 0);
        Vector3 posicionInicialB = Vector3.right;

        Vector3 coordenadasA = new Vector2(0, -1);
        Vector3 coordenadasB = Vector2.down;

        Color colorPoweUpA = new Color(0, 1, 0);
        Color colorPoweUpB = Color.green;


        // Para cambiar solo una variable dentro de una variable
        // compuesta se usa el operador .
        Vector3 posicionEnemigo = new Vector3(6, 3, 2);
        posicionEnemigo.x = 23;
        posicionEnemigo.y = 12;

        transformEnemigo.position = new Vector3(0, 20, -3);
        transformEnemigo.eulerAngles = new Vector3(45, 0, 0);
        transformEnemigo.position = new Vector3(4, 7, 0);

        rigidbodyCubo.mass = 23;

        luzDelSol.color = new Color(0.0f, 0.0f, 1.0f);

        bossFinal.flipX = true;
    }
}
