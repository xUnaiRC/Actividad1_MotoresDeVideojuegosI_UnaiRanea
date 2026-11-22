using UnityEngine;

public class ObjectGrab : MonoBehaviour
{
    Rigidbody rb;
    public bool agarrando;
    public static ObjectGrab objetoAgarrado;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(agarrando == true)
        {
            rb.useGravity = false;
        }
        else
        {
            rb.useGravity = true;
        }
    }

    private void OnMouseDown()
    {
        agarrando = true;
        objetoAgarrado = this;
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }
    private void OnMouseDrag()
    {
        Vector3 posicionMouse = Input.mousePosition;

        posicionMouse.z = Camera.main.WorldToScreenPoint(transform.position).z;

        transform.position = Camera.main.ScreenToWorldPoint(posicionMouse);
    }
    private void OnMouseUp()
    {
        agarrando = false;
        objetoAgarrado = null;
        rb.collisionDetectionMode = CollisionDetectionMode.Discrete;
    }

}
