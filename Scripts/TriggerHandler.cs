
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
        Transform thisTransform = transform;
      //  thisTransform.position = new Vector3(transform.position.x, transform.position.y, playerTransform.position.z);
        
        playerTransform.LookAt(new Vector3(transform.position.x, playerTransform.position.y, playerTransform.position.z));
        


        GetComponent<MakeButtons>().TestWithDummytext();
        foreach(GameObject go in toEnable)
        go.SetActive(true);
    }
}
