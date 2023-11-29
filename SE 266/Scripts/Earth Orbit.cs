using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    [SerializeField]
    public float speed = 100f;
    public float radius = 10f; // Distance from the Sun (can be adjusted)

    private float angle = 0f;
    public GameObject sun;
    // Start is called before the first frame update
    void Start()
        {
        
        }

    // Update is called once per frame
    void Update()
    {

        if (sun == null) return;

        angle += speed * Time.deltaTime;
        Vector3 orbitPosition = sun.transform.position + Quaternion.Euler(0, angle, 0) * new Vector3(radius, 0, 0);
        transform.position = orbitPosition;
    }
}
