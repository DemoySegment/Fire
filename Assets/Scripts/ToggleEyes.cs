using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ToggleEyes : MonoBehaviour
{
    public GameObject Eyes;
    private bool canSpawn = false;
    private bool off = true;

    // Update is called once per frame
    void Update()
    {
        if (canSpawn && !off)
        {
            canSpawn= false;
            StartCoroutine(Spawn());
        }
    }
    public void eyeToggle()
    {
        if(!off)
        {
            StopAllCoroutines();
            off = true;
        }
        else
        {
            
            off = false;
            canSpawn= true;
            
        }

    }
    IEnumerator Spawn()
    {
        Instantiate(Eyes, new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), 0),Quaternion.identity);
        yield return new WaitForSeconds(1.5f);
        canSpawn = true; 
    }
}
