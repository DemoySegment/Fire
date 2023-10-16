using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightShaking : MonoBehaviour
{
    public Light2D light;
    private bool changing;

    // Update is called once per frame
    void Update()
    {
        if (!changing)
        {
            changing = true;
            light.intensity = Random.Range(1f, 4f);
            StartCoroutine(Timer());

        }
        
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(Random.Range(0.1f, 0.3f));
        changing = false;
    }

}
        
