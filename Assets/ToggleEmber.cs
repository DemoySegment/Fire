using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleEmber : MonoBehaviour
{
    public GameObject ember;

    public void EmberToggle()
    {
        if(ember.activeSelf) {
            ember.SetActive(false);
        }
        else
        {
            ember.SetActive(true);
        }
    }
}
