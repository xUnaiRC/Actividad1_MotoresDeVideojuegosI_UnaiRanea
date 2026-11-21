using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float velocidad = 1.0f;
    public Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(horizontal, 0, vertical);
        rb.transform.position += movimiento * velocidad * Time.deltaTime;

        float angulo = Mathf.Atan2(vertical, -horizontal) * Mathf.Rad2Deg;
        rb.transform.rotation = Quaternion.Euler(0, angulo, 0);
    }
}
