using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControlUI : MonoBehaviour
{
    public BallSpawner spawner; // Assign in Inspector
    public Slider delaySlider;  // Assign in Inspector
    public Slider ballCountSlider; // Assign in Inspector

    void Start()
    {
        delaySlider.onValueChanged.AddListener(newDelay => spawner.SetDelay(newDelay));
        ballCountSlider.onValueChanged.AddListener(newCount => spawner.SetBallLimit(newCount));
    }
}
