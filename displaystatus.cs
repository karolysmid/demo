using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displaystatus : MonoBehaviour
{



   public  GameObject[] toEnable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        StaticState.DisplayStatus();

        foreach(GameObject go in toEnable)
        go.SetActive(true);
    }

    void OnCollisionEnter(Collision other)
    {
        StaticState.DisplayStatus();

        foreach(GameObject go in toEnable)
        go.SetActive(true);
    }
}
