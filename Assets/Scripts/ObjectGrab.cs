using UnityEngine;

public class ObjectGrab : MonoBehaviour
{
    Rigidbody rb;
    public bool agarrando;
    public static ObjectGrab objetoAgarrado;
    public GameObject player;
    public float alturaObjeto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
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

        Vector3 nuevaPosicion = Camera.main.ScreenToWorldPoint(posicionMouse);

        alturaObjeto += Input.GetAxis("Mouse ScrollWheel");

        nuevaPosicion.y = player.transform.position.y + alturaObjeto;

        transform.position = nuevaPosicion;
    }
    private void OnMouseUp()
    {
        agarrando = false;
        objetoAgarrado = null;
        rb.collisionDetectionMode = CollisionDetectionMode.Discrete;
    }

}
