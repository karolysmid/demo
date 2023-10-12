using System.Runtime.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using Controllers;
using TMPro;
using UnityEngine;


public class GameLogic : MonoBehaviour
{


    static int  state=0;
    const  int RUN = 3;
  //  private string[] textData={"Oh hello there", "*raises eyebrows* I am not sure","No. Wouldn't I be promoting Skyrim if I was?","Why do you run" ,"option 4"};
   // private string[] textData2={"I'm good. ", "You will never catch me alive!","Well good luck expanding the code for this","Why do you run" ,"option 4"};
    static string[] textData={"There was an error in getting the list"};
   // public static TextMeshProUGUI tmp;
     static GameObject triggerHandler;
     
    [SerializeField] public Consts consts;

  //  public GameObject player;
  //  public Controller controller;
//
    //public bool isPaused;

     void OnEnable()
    {
        triggerHandler = GameObject.FindGameObjectWithTag("TriggerHandler");
    }
    public static void ProcessButtonPress(string id, int replyID)
    {
        if(replyID == RUN)
        {
            
        }
        DialogDisplay dialogDisplay = GameObject.FindGameObjectWithTag("DialogDisplay").GetComponent<DialogDisplay>();


        switch(replyID)
        {
            case 2: state = 1;break;
            case RUN: GameObject.FindGameObjectWithTag("TriggerHandler").GetComponent<TriggerHandler>().DisableSelected();
            return;
            case 5: state = 2;break;
        }
        Debug.Log(state+" is the state");
        textData=StateHandler.HandleState(state);

        Debug.Log(textData[1]+" is the textData. Reply id is "+replyID);
        dialogDisplay.DisplayNPCText(textData[replyID]);
        // tmp.text = textData[replyID];

        
    }

    internal static void InitializeStates()
    {
        StateHandler.CreateStates();
    }

   // public static StateHandler statehandler;
  

    

       
    //    controller = player.GetComponent<Controller>();
     //   controller.controlsEnabled=true;
    


    
}
