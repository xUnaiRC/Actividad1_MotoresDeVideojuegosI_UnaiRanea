using UnityEngine;

public class Monstruos : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Camera mainCamera = Camera.main;
        transform.LookAt(mainCamera.transform.position, Vector3.up);
    }
}
