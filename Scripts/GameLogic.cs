using System;
using System.Collections;
using System.Collections.Generic;
using Controllers;
using TMPro;
using UnityEngine;


public class GameLogic : MonoBehaviour
{

    const int RUN = 3;
    private string[] textData={"Oh hello there", "*raises eyebrows* I am not sure","No. Wouldn't I be promoting Skyrim if I was?","Why do you run" ,"option 4"};
    public TextMeshProUGUI tmp;

  //  public GameObject player;
  //  public Controller controller;
//
    //public bool isPaused;
    internal void ProcessButtonPress(string id, int idnum)
    {
        
        tmp.text = textData[idnum];

        if(idnum == RUN)
        {
            GameObject.FindGameObjectWithTag("TriggerHandler").GetComponent<TriggerHandler>().DisableSelected();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    //    controller = player.GetComponent<Controller>();
     //   controller.controlsEnabled=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
