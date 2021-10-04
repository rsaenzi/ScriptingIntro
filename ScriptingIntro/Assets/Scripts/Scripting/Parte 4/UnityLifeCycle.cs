using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityLifeCycle : MonoBehaviour {

    // -------------------
    // Ciclo de Vida Unity
    // -------------------


    // Si una funcion tiene un nombre particular entonces es invocada
    // en un momento determinado de manera automatica, siguiendo el
    // Orden de Ejecucion de Funciones de Unity
    // https://docs.unity3d.com/Manual/ExecutionOrder.html


    void OnApplicationPause(bool pause) {
        print("OnApplicationPause " + pause);
    }

    void LateUpdate() {
        //print("LateUpdate");
    }

    void OnDestroy() {
        print("OnDestroy");
    }

    void Start() {
        print("Start");
    }

    void OnEnable() {
        print("OnEnable");
    }

    void OnApplicationQuit() {
        print("OnApplicationQuit");
    }

    void FixedUpdate() {
        //print("FixedUpdate");
    }

    void Awake() {
        print("Awake");
    }

    void Update() {
        //print("Update");
    }

    void OnDisable() {
        print("OnDisable");
    }
}