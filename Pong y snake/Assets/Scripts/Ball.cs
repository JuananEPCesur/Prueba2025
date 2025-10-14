using UnityEngine;

public class Ball : MonoBehaviour
{
    public float velocidad = 7f;
    public Rigidbody2D rb_pelota;
    Vector2 Posicion_inicial; //esto

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Posicion_inicial = transform.position;//esto
        Launch();

    }

    void Launch()
    {
        float VelocidadX;
        if (Random.Range(0, 2) == 0) 
        {
            VelocidadX = 1; 
        }
        else 
        {
            VelocidadX = -1;
        }

        float VelocidadY;
        if (Random.Range(0, 2) == 0)
        {
            VelocidadY = 1;
        }
        else
        {
            VelocidadY = -1;
        }

        rb_pelota.linearVelocity = new Vector2(VelocidadX, VelocidadY)*velocidad;

    }


    public void Reset()//esto
    {
        transform.position = Posicion_inicial;
        rb_pelota.linearVelocity = Vector2.zero;
        Launch();
    }
}

