using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAsh : MonoBehaviour
{
    public GameObject ash;

    void Start()
    {
        ash.SetActive(false);
    }

    public void ashToggle()
    {
        if (ash.activeSelf)
        {
            ash.SetActive(false);
        }
        else
        {
            ash.SetActive(true);
        }
    }
}
