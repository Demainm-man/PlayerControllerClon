using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownScript : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody objectRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        objectRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectRigidbody.AddForce(-Vector3.forward * speed);
    }
    private void LateUpdate()
    {
        if(transform.position.z < -15)
        {
            Destroy(gameObject);
        }
    }
}
