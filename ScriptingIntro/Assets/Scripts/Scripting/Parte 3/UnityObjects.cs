#pragma warning disable CS0108 // 'UnityObjects.collider' hides inherited member 'Component.collider'. Use the new keyword if hiding was intended.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditorInternal;

public class UnityObjects : MonoBehaviour {

    // -------------
    // Objetos Unity
    // -------------


    // Componente Transform
    public Transform piramidTransform;

    void DemoTransform() {

        // Un transform puede conocer cual transform es su padre
        Transform padreTransform = piramidTransform.parent;

        // Un transform sabe quien es su contenedor (GameObject)
        GameObject padreGameobject = padreTransform.gameObject;


        // Funciones mas conocidas
        piramidTransform.Rotate(Vector3.up);
        piramidTransform.Translate(Vector3.forward);
        piramidTransform.LookAt(new Vector3(4, 7, 2));
        piramidTransform.localScale = Vector3.one * 5;


        // Datos mas conocidos
        int cantidadDeHijos = piramidTransform.childCount;
        Vector3 pos = piramidTransform.localPosition;
        Vector3 scale = piramidTransform.localScale;


        // Buscar un transform hijo con un nombre especifico
        piramidTransform.Find("Star");
    }


     
    // Componente Rigidbody
    public Rigidbody rigidbody;

    void DemoRigidbody() {

        // Aplicar fuerzas lineales
        rigidbody.AddForce(Vector3.up, ForceMode.Impulse);

        // ...o fuerzas de giro
        rigidbody.AddTorque(Vector3.forward, ForceMode.Acceleration);

        // Cambiar el centro de masa
        rigidbody.centerOfMass = new Vector3(1, 2, 3);

        // Permitir o no que el objeto rote
        rigidbody.freezeRotation = false;

        // Cambiar la masa
        rigidbody.mass = 45.6f;

        // Prender o apagar la gravedad
        rigidbody.useGravity = false;
    }



    // Componente Collider
    public Collider collider;
    public PhysicMaterial caucho;

    void DemoCollider() {

        // Podemos copiar o cambiar cualquier propiedad
        collider.enabled = true;
        collider.isTrigger = false;
        collider.material = caucho;

        print(collider.bounds);
    }



    // Keyword this
    public GameObject cubo;

    void ThisOperations() {

        // this se refiere a éste script
        string nombre = this.name;
        bool activo = this.enabled;

        // Éste script sabe quien es su contenedor (GameObject)
        GameObject contenedor = this.gameObject;


        // Son similares, pero hacen cosas diferentes
        this.transform.Rotate(Vector3.right);
        cubo.transform.Rotate(Vector3.right);
    }



    // GameObject
    void DemoGameObject() {

        cubo.tag = "Parallax";
        cubo.name = "BackgroundPlane";
        cubo.SetActive(true);

        print(cubo.activeSelf);
        print(cubo.activeInHierarchy);

        print(cubo.layer);
        print(cubo.isStatic);


        // Manipulacion de Componentes

        // Obtener Componentes
        Light luz = cubo.GetComponent<Light>();
        Camera camara = cubo.GetComponent<Camera>();
        Rigidbody body = cubo.GetComponent<Rigidbody>();
        Animator animator = cubo.GetComponent<Animator>();


        // Este es un shortcut que solo aplica al componente transform
        // Ya que todos los game object tiene un Transform
        Transform transA = cubo.GetComponent<Transform>();
        Transform transB = cubo.transform;


        // Agregar componentes
        Camera nuevaCamara = cubo.AddComponent<Camera>();
        nuevaCamara.backgroundColor = Color.green;
        nuevaCamara.orthographicSize = 0.7f;
    }
}