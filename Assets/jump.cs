using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour
{
    public Vector3 jumper;
    public float jumpForce = 2.0f;

    public bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumper = new Vector3(0.0f, 4.0f, 0.0f);
    }

    void OnCollisionEnter()
    {
        isGrounded = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {

            rb.AddForce(jumper * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}