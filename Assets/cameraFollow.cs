
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;

    public float speed = 0.13f;
    public Vector3 buffer;

    void FixedUpdate()
    {

        transform.position = target.position + buffer;
        transform.LookAt(target);
    }
}
