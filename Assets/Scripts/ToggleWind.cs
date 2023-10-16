using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleWind : MonoBehaviour
{
    public GameObject windZone;

    void Start()
    {
        windZone.SetActive(false);
    }

    public void windToggle()
    {
        if (windZone.activeSelf)
        {
            windZone.SetActive(false);
        }
        else
        {
            windZone.SetActive(true);
        }
    }
}
