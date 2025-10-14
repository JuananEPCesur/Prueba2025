using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void CambioEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void CambiarSnake()
    {
        SceneManager.LoadScene("snake");
    }
    public void CambiarEscenaId(int id_scena)
    {
        SceneManager.LoadScene(id_scena);
    }
        
    public void Salir()
    {
        Application.Quit();
    }
}
