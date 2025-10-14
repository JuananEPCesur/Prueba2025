using UnityEngine;

public class Porteria : MonoBehaviour
{
    public GameObject gm;
    public bool porteria_derecha;
    int Goles_Derecha = 0;
    int Goles_Izquierda = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Pelota"))
        {
            gm.GetComponent<GameManager>().ResetAll();


            if(porteria_derecha)
            {
               
                gm.GetComponent<GameManager>().Marcar(true, ++Goles_Derecha);

            }
            else
            {
                gm.GetComponent<GameManager>().Marcar(false, ++Goles_Izquierda);

            }
        }
    }

}
