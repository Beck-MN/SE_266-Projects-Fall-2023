using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public float speed = 1.0f;      // Speed of the movement
    public float height = 2.0f;     // Maximum height of the bounce

    private float originalY;        // Original Y position
    private float currentHeight = 0.0f; // Current height offset
    private bool movingUp = true;   // Direction of movement

    // Start is called before the first frame update
    void Start()
    {
        originalY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(movingUp)
        {
            currentHeight += speed * Time.deltaTime;
            if(currentHeight > height)
            {
                currentHeight = height;
                movingUp = false;
            }
        }

        else
        {
            currentHeight -= speed * Time.deltaTime;
            if(currentHeight < 0.0f)
            {
                currentHeight = 0.0f;
                movingUp = true;
            }
        }

        transform.position = new Vector3(transform.position.x, originalY + currentHeight, transform.position.z);
    }
}
