using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManualSliderControl : MonoBehaviour
{
    public Slider sunRotationSlider; // Assign in Inspector
    public Slider earthRotationSlider; // Assign in Inspector
    public Slider moonRotationSlider; // Assign in Inspector

    public PlanetControl planetControl; // Assign in Inspector

    void Update()
    {
        if (planetControl != null)
        {
            if (sunRotationSlider != null)
            {
                planetControl.SetSunRotationSpeed(sunRotationSlider.value);
            }

            if (earthRotationSlider != null)
            {
                planetControl.SetEarthRotationSpeed(earthRotationSlider.value);
            }

            if (moonRotationSlider != null)
            {
                planetControl.SetMoonRotationSpeed(moonRotationSlider.value);
            }
        }
    }
}


