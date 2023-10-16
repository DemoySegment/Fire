using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;


public class LightControl : MonoBehaviour
{
    [SerializeField]
    private Light2D lightSource;

    public void LightToggle()
    {
        if (lightSource.enabled)
        {
            lightSource.enabled = false;
        } else 
        {
            lightSource.enabled = true;
        }
    }
}
