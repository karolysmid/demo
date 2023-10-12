
using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHandler : MonoBehaviour
{

    public GameObject[] toEnable;
    public GameObject[] toDisable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void DisableSelected()
{
    foreach(GameObject go in toDisable)
    {
        go.SetActive(false);
    }
}

    void OnTriggerEnter(Collider other)
    {

        Transform playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Vector3 direction = playerTransform.position-transform.position;
      //  thisTransform.position = new Vector3(transform.position.x, transform.position.y, playerTransform.position.z);

      Quaternion lookrotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        
        Quaternion.Slerp(transform.rotation, lookrotation,Time.deltaTime);
        StaticState.IncreaseStatus();

      //  playerTransform.LookAt(new Vector3(transform.position.x, playerTransform.position.y, playerTransform.position.z));
        


        StateHandler.HandleState();
        foreach(GameObject go in toEnable)
        go.SetActive(true);
    }
}
