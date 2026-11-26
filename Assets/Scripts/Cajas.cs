using UnityEngine;

public class Cajas : MonoBehaviour
{
    public GameObject caja;
    public GameObject pale;
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

            int num = Random.Range(0, 4);
            GameObject objetoSpawn;
            if (num < 3)
                objetoSpawn = caja;
            else
                objetoSpawn = pale;
            
            Instantiate(objetoSpawn, posicion, Quaternion.identity);
        }
    }
}
