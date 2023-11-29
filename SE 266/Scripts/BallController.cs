using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public float forceStrength = 1000f;
    public float rotationSpeed = 50f;
    private Rigidbody rb;
    private bool isLaunched = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLaunched) 
        {
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
            }
            if(Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            }

        }
        if (Input.GetKeyDown(KeyCode.Space) && !isLaunched)
        {
            rb.AddForce(transform.forward * forceStrength);
            isLaunched = true;
        }
    }
}
