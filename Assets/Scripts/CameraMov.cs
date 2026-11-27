using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    private float alturaCamaraConst;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = new Vector3(0, 8, -8);
        alturaCamaraConst = 9.5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + offset.x,
                                         alturaCamaraConst,
                                         player.transform.position.z + offset.z);
    }
}
