using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarHandler : MonoBehaviour
{
    

    public GameObject container;
    Scrollbar scrollbar;
    public float distance=0;
    
    void Start()
    {
        scrollbar = GetComponent<Scrollbar>();
      //  scrollbar.onValueChanged.AddListener(scrollbarCallBack);
    

    }

    void OnEnable()
    {
        
    }
   void  scrollbarCallBack(float value)
    {
          
            
           


        
            distance = value-0.5f;
            distance*=2;

         foreach(Transform t in container.transform)
            {
                


               t.position = new Vector3(t.position.x, t.position.y+distance, t.position.z);
            }




            

            
           

    }

}
