using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab; // Assign in Inspector
    public Transform spawnPoint;  // Assign the SpawnRegion transform
    public float delay = 1.0f;    // Default delay
    private float ballsInPlay = 0;
    public float ballLimit = 1.0f;

    void Start()
    {
        SpawnBall();
    }

    void SpawnBall()
    {
        if (ballsInPlay < ballLimit)
        {
            Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
            ballsInPlay++;
            Invoke(nameof(SpawnBall), delay); // Call again after a delay
        }
    }

    public void BallCaught()
    {
        ballsInPlay--;
        Invoke(nameof(SpawnBall), delay);
    }

    public void SetBallsInPlay(float count)
    {
        ballsInPlay = count;
        
    }

    public void SetDelay(float newDelay)
    {
        delay = newDelay;
    }

    public void SetBallLimit(float newBallLimit)
    {
        ballLimit = newBallLimit;
    }
}
