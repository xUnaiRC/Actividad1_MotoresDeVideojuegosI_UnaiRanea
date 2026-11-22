using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float velocidad = 1.0f;
    public Rigidbody rb;
    private ObjectGrab objectGrab;
    public bool seMueve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        seMueve = true;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(horizontal, 0, vertical);

        if (seMueve)
        {
            rb.transform.position += movimiento * velocidad * Time.deltaTime;
        }

        float angulo = Mathf.Atan2(vertical, -horizontal) * Mathf.Rad2Deg;

        if (ObjectGrab.objetoAgarrado != null)
        {
            rb.transform.rotation = Quaternion.Euler(0, transform.position.y, 0);
            seMueve = false;
        }
        else
        {
            rb.transform.rotation = Quaternion.Euler(0, angulo, 0);
            seMueve = true;
        }
    }
}
