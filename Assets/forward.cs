using UnityEngine;

public class forward : MonoBehaviour
{

    public float speed = 2f;
    public float run = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.x -= run * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.z+= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.z -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
