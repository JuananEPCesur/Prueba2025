using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pala_derecha;
    public GameObject pala_izquierda;
    public GameObject pelota;
    public TMP_Text Marcador_Derecha;
    public TMP_Text Marcador_Izquierda;

    public void ResetAll()
    {
        pelota.GetComponent<Ball>().Reset();
        pala_izquierda.GetComponent<Pala>().Reset();
        pala_derecha.GetComponent<Pala>().Reset();
    }

    public void Marcar(bool equipo_derecha, int puntuacion)
    {
        if (equipo_derecha == true)
        {
            Marcador_Derecha.text = puntuacion.ToString();
        }
        else
        {
            Marcador_Izquierda.text = puntuacion.ToString();
        }
    }
    
    

}
