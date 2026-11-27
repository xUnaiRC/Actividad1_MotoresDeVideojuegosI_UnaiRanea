using UnityEngine;

public class Llaves : MonoBehaviour
{
    public float rotacion = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotacion * Time.deltaTime, 0);
    }
}
