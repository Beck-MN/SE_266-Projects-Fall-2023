using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoonOrbit : MonoBehaviour
{
    [SerializeField]
    public GameObject earth; // Assign the Earth GameObject in the Unity Editor
    public float speed = 100f;
    public float radius = 5f; // Distance from Earth (can be adjusted)

    private float angle = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (earth == null) return;

        angle += speed * Time.deltaTime;
        Vector3 orbitPosition = earth.transform.position + Quaternion.Euler(0, angle, 0) * new Vector3(radius, 0, 0);
        transform.position = orbitPosition;
    }
}
 
