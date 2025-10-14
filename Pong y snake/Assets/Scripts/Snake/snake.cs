using System.Collections.Generic;
using UnityEngine;

public class snake : MonoBehaviour
{
    Vector2 direccion = Vector2.right;

    public Transform segmentoPrefab;
    List<Transform> ListaSegmentos = new List<Transform>();

    private void Start()
    {
        ListaSegmentos.Add(transform); //Añadimos la cabeza
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            direccion = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            direccion = Vector2.down;
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            direccion = Vector2.right;
        }
        else if( Input.GetKeyDown(KeyCode.A))
        {
            direccion = Vector2.left;
        }
    }

    private void FixedUpdate()
    {

        //for i in range(0,5): Python

        /*for (int i = 0; i <5; i = i+2)
        {

        }*/ //For en C#

        for (int i = ListaSegmentos.Count - 1; i > 0; i--)
        {
            ListaSegmentos[i].position = ListaSegmentos[i-1].position;
        }

        transform.position = new Vector3(Mathf.Round(transform.position.x)+direccion.x,
                                         Mathf.Round(transform.position.y)+direccion.y,
                                         0f);
    }

    private void Crecer()
    {
        Transform nuevo_segmento = Instantiate(segmentoPrefab);
        nuevo_segmento.position = ListaSegmentos[ListaSegmentos.Count - 1].position;
        ListaSegmentos.Add(nuevo_segmento);
    }

    private void ResetearTodo()
    {

        for (int i = 1;  i < ListaSegmentos.Count; i++)
        {
            Destroy(ListaSegmentos[i].gameObject);
        }

        ListaSegmentos.Clear();
        ListaSegmentos.Add(this.transform);

        transform.position = Vector3.zero;


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Manzana"))
        {
            Crecer();
        }
        else if (collision.CompareTag("Obstaculo"))
        {
            ResetearTodo();
        }
    }
}
