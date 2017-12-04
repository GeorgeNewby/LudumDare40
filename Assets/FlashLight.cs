using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {

    public Light flashLight;
    //private bool isEnabled = true;
    //private int intensity = 1;
    public float Intensity
    {
        get
        {
            if (flashLight.enabled)
            {
                return flashLight.spotAngle / 20f;
            }
            return 0f;
        }
    }

    void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            if (flashLight.enabled)
            {
                flashLight.enabled = false;
            }
            else
            {
                flashLight.enabled = true;
            }
        }
        if (flashLight.enabled)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0 && flashLight.spotAngle < 120)
            {
                flashLight.spotAngle += 5;
                flashLight.intensity += 0.1f;
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0 && flashLight.spotAngle > 20)
            {
                flashLight.spotAngle -= 5;
                flashLight.intensity -= 0.1f;
            }
        }
    }
}
