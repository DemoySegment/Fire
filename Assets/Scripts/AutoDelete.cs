using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AutoDelete : MonoBehaviour
{
    public VideoPlayer VP;
    // Start is called before the first frame update
    void Start()
    {
        VP.loopPointReached += checkOver;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void checkOver(UnityEngine.Video.VideoPlayer vp)
    {
        Destroy(this.gameObject);
    }
}
