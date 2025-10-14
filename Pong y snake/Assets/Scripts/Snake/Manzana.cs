using UnityEngine;

public class Manzana : MonoBehaviour
{
    public BoxCollider2D AreaZona;

    void PosicionRandom()
    {
        Bounds limites = AreaZona.bounds;

        float x = Random.Range(limites.min.x, limites.max.x);
        float y = Random.Range(limites.min.y, limites.max.y);

        transform.position = new Vector3(Mathf.Floor(x),Mathf.Floor(y), 0);
    }

    private void Start()
    {
        PosicionRandom();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Culebra"))
        {
            PosicionRandom();
        }
    }

}
