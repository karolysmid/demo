using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MakeButtons : MonoBehaviour
{
  public GameObject buttonContainer;
  public GameObject buttonPrefab;
 
  public GameObject myUI;
  public float spacing = 30f;
  public DialogDisplay dialogDisplay;
  GameLogic gameLogic;

  public void TestWithDummytext()
  {
  //  CreateButtonLayout(new string[]{"Hi","It just works?" ,"You look familiar... Todd?","Run" });

  }

  void Start()
  {
   // buttonContainer = GameObject.FindGameObjectWithTag("ButtonContainer");
    //dialogDisplay =  GameObject.FindGameObjectWithTag("DialogDisplay").GetComponent<DialogDisplay>();
    gameLogic=GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogic>();
  }
  public void Reply()
  {
   // CreateButtonLayout(new string[]{"How are you?","Stop! You violated the law!" ,"I want to play Starfield","Run" });
  }


  public void CreateButtonLayout()

  {
    Debug.Log("creating button layout. current status is "+StaticState.GetStatus());

 // gameLogic.consts.playerOptions[StaticState.GetStatus()];
 List<PlayerOption> playerOptions = gameLogic.consts.GetPlayerOptions(StaticState.GetStatus());
Debug.Log("playeroption is "+ playerOptions[0].text);
ClearChoices();
Vector3 currentPosition = Vector3.zero;


 foreach(PlayerOption playerOption in playerOptions)
 {
    GameObject choiceButton = Instantiate(buttonPrefab, buttonContainer.transform);
    ButtonHandler buttonHandler = choiceButton.GetComponent<ButtonHandler>();
    Text buttonText = choiceButton.GetComponentInChildren<Text>();


    buttonHandler.SetButtonID(playerOption.text, playerOption.linkID);

    choiceButton.transform.localPosition = currentPosition;



    bool IsHorizontal = false;

      if(IsHorizontal)
        {
          currentPosition.x += spacing;
        }else{
        currentPosition.y -= spacing;
        
        }

 }


} 
/*
 public void CreateButtonLayoutOld(string[] choices, int[]replies, bool IsHorizontal)
  {
    ClearChoices();
    Vector3 currentPosition = Vector3.zero;

    for(int i = 0; i<choices.Length; i++)
    {
     
        GameObject choiceButton = Instantiate(buttonPrefab, buttonContainer.transform);
         ButtonHandler buttonHandler = choiceButton.GetComponent<ButtonHandler>();
        Text buttonText = choiceButton.GetComponentInChildren<Text>();

        
        buttonHandler.SetButtonID(choices[i], replies[i]);
       

        buttonText.text = choices[i];
        choiceButton.transform.localPosition = currentPosition;



        if(IsHorizontal)
        {
          currentPosition.x += spacing;
        }else{
        currentPosition.y -= spacing;
        
        }

    }




  }*/

    private void ClearChoices()
    {
        foreach(Transform child in buttonContainer.transform)
        {
            Destroy(child.gameObject);
        }
    }
}
