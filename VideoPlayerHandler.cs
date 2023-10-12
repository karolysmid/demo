using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using Controllers;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerHandler : MonoBehaviour
{


    [SerializeField] public VideoPlayer videoPlayer;
   [SerializeField] public Controller controller;
   [SerializeField] public long endFrame=24;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    

    
    // Update is called once per frame
    void Update()
    {
        
       // Debug.Log("frame is "+ videoPlayer.frame+ " out of "+videoPlayer.frameCount);
        if(!(videoPlayer.frame < (long)videoPlayer.frameCount-endFrame))
        {
            videoPlayer.gameObject.SetActive(false);
            controller.SetControlsEnabled(true);
        }
    }
}
