using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConto : MonoBehaviour
{
    private float speed = 10f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.AddForce(Vector3.forward * speed * verticalInput);
        rb.AddForce(Vector3.right * speed * horizontalInput);
    }
    private void LateUpdate()
    {
        Vector3 pos = transform.position;
        if(transform.position.z > 10.67f)
        {
            pos.z = 10.67f;
        }else if(transform.position.z < -12.33f)
        {
            pos.z = -12.33f;
        }
        transform.position = pos;
    }
}
