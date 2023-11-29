using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetControl : MonoBehaviour
{
    public GameObject sun;
    public GameObject earth;
    public GameObject moon;

    private rotation sunRotation;
    private rotation earthRotation;
    private Revolution earthOrbit;
    private rotation moonRotation;
    private MoonOrbit moonOrbit;

    void Start()
    {
        sunRotation = sun.GetComponent<rotation>();
        earthRotation = earth.GetComponent<rotation>();
        earthOrbit = earth.GetComponent<Revolution>();
        moonRotation = moon.GetComponent<rotation>();
        moonOrbit = moon.GetComponent<MoonOrbit>();
    }

    void Update()
    {
        // Toggle rotation
        if (Input.GetKeyDown(KeyCode.R))
        {
            ToggleRotation(sunRotation);
            ToggleRotation(earthRotation);
            ToggleRotation(moonRotation);
        }

        // Toggle orbit
        if (Input.GetKeyDown(KeyCode.O))
        {
            ToggleOrbit(earthOrbit);
            ToggleOrbit(moonOrbit);
        }

        // Adjust speed with arrow keys
        if (Input.GetKey(KeyCode.UpArrow))
        {
            AdjustSpeed(1);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            AdjustSpeed(-1);
        }

    }


    public void ToggleRotation(rotation rot)
    {
        if (rot != null)
        {
            rot.enabled = !rot.enabled;
        }
    }

    public void ToggleOrbit(MoonOrbit orbit)
    {
        if (orbit != null)
        {
            orbit.enabled = !orbit.enabled;
        }
    }

    public void ToggleOrbit(Revolution orbit)
    {
        if (orbit != null)
        {
            orbit.enabled = !orbit.enabled;
        }
    }

    public void AdjustSpeed(int direction)
    {
        float adjustment = direction * 10f * Time.deltaTime;
        sunRotation.rotateSpeed += adjustment;
        earthRotation.rotateSpeed += adjustment;
        earthOrbit.speed += adjustment;
        moonRotation.rotateSpeed += adjustment;
        moonOrbit.speed += adjustment;
    }

    public void SetSunRotationSpeed(float speed)
    {
        if (sunRotation != null)
        {
            sunRotation.rotateSpeed = speed;
        }
    }

    public void SetEarthRotationSpeed(float speed)
    {
        if (earthRotation != null)
        {
            earthRotation.rotateSpeed = speed;
        }
    }

    public void SetMoonRotationSpeed(float speed)
    {
        if (moonRotation != null)
        {
            moonRotation.rotateSpeed = speed;
        }
    }

}
