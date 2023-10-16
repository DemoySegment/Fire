using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LightControl : MonoBehaviour
{
    public void LightToggle()
    {
        if (this.GetComponent<UnityEngine.Rendering.Universal.Light2D>().enabled)
        {
            this.GetComponent<UnityEngine.Rendering.Universal.Light2D>().enabled = false;
        } else 
        {
            this.GetComponent<UnityEngine.Rendering.Universal.Light2D>().enabled = true;
        }
    }
}
