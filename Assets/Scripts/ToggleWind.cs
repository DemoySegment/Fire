using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleWind : MonoBehaviour
{
    public GameObject windZone;
    public bool TimerOn = false;

    void Start()
    {
        
        windZone.SetActive(false);
    }
    private void Update()
    {
        if (!TimerOn)
        {
            windZone.transform.Rotate(new Vector3(Random.Range(-60, 60), 0, 0), Space.Self);
            TimerOn = true;
            StartCoroutine(timer());
        }
        
    }
    public void windToggle()
    {
        if (windZone.activeSelf)
        {
            windZone.SetActive(false);
            StopCoroutine(timer());
            TimerOn = false;
        }
        else
        {
            windZone.SetActive(true);
            windZone.transform.rotation = Quaternion.Euler(new Vector3(0,90,0));
            TimerOn = false;
        }
    }
    IEnumerator timer()
    {

        yield return new WaitForSeconds(3);

        TimerOn= false;
    }
}
