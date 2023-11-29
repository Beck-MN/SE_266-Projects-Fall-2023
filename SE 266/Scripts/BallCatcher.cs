using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCatcher : MonoBehaviour
{
    public BallSpawner spawner; // Assign in Inspector

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject)
        {
            Destroy(other.gameObject);
            spawner.BallCaught();
        }
    }

}
