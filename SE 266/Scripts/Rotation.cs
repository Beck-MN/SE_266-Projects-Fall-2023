using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class rotation : MonoBehaviour
{
    [SerializeField]
    public float rotateSpeed;
    [SerializeField]
    Vector3 rotationDirection = new Vector3();

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime * rotationDirection);
    }
}
