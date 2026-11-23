using UnityEngine;

public class Cajas : MonoBehaviour
{
    public GameObject caja;
    public float cantidadDeCajas = 50;
    private float x;
    private float y = 10f;
    private float z;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < cantidadDeCajas; i++)
        {
            x = Random.Range(-25, 25);
            z = Random.Range(-25, 275);

            Vector3 posicion = new Vector3(x, y, z);

            Instantiate(caja, posicion, Quaternion.identity);
        }
    }
}
