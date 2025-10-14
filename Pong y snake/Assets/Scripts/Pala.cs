using UnityEngine;

public class Pala : MonoBehaviour
{
    public float velocidad = 5f;
    public Rigidbody2D rb_pala;
    public bool jugador_derecha;
    float movimiento;
    Vector2 Posicion_inicial;

    private void Start()
    {
        Posicion_inicial = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if(!jugador_derecha)
        {
            movimiento = Input.GetAxisRaw("Vertical"); //Coge el eje del input y hace movidas
        }
        else
        {
            movimiento = Input.GetAxisRaw("Vertical2"); //Coge el eje del input y hace movidas

        }

        rb_pala.linearVelocity = new Vector2(rb_pala.linearVelocityX,
                                                 velocidad * movimiento);
    }

    public void Reset()
    {
        rb_pala.linearVelocity = Vector2.zero;
        transform.position = Posicion_inicial;
    }
}
