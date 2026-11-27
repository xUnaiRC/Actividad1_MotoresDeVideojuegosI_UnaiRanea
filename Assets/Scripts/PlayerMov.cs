using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float velocidad = 1.0f;
    public float fuerzaSalto = 1.0f;
    public Rigidbody rb;
    private ObjectGrab objectGrab;
    public bool seMueve;
    public bool tocaSuelo;

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
            //Conseguir vector para mirar a objeto
            Vector3 mirarObjeto = ObjectGrab.objetoAgarrado.transform.position - transform.position;
            float anguloDireccion = Mathf.Atan2(mirarObjeto.x, mirarObjeto.z) * Mathf.Rad2Deg;
            rb.transform.rotation = Quaternion.Euler(0, anguloDireccion + 90, 0);

            seMueve = false;
        }
        else
        {
            rb.transform.rotation = Quaternion.Euler(0, angulo, 0);
            seMueve = true;
        }

        salto();
    }

    void salto()
    {
        //Hacer el salto
        if (Input.GetKeyDown(KeyCode.Space) && seMueve == true && tocaSuelo == true)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        tocaSuelo = true;
        //Comprobar si el juagdor toca el suelo
        if (collision.gameObject.CompareTag("Suelo") || collision.gameObject.CompareTag("Caja"))
        {
            
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        tocaSuelo = false;
        //Comprobar si el juagdor toca el suelo
        if (collision.gameObject.CompareTag("Suelo") || collision.gameObject.CompareTag("Caja"))
        {
            
        }
    }
}
