using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MakeButtons : MonoBehaviour
{
  public GameObject container;
  public GameObject buttonPrefab;
  public GameLogic gameLogic;
  public GameObject myUI;
  public float spacing = 30f;

  public void TestWithDummytext()
  {
    CreateButtonLayout(new string[]{"Hi","It just works?" ,"You look familiar... Todd?","Run" });
  }
  public void CreateButtonLayout(string[] choices)
  {
    ClearChoices();
    Vector3 currentPosition = Vector3.zero;

    for(int i = 0; i<choices.Length; i++)
    {
     
        GameObject choiceButton = Instantiate(buttonPrefab, container.transform);
         ButtonHandler buttonHandler = choiceButton.GetComponent<ButtonHandler>();
        Text buttonText = choiceButton.GetComponentInChildren<Text>();
        
        buttonHandler.SetButtonID(choices[i], i);
        buttonHandler.gameLogic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogic>();

        buttonText.text = choices[i];
        choiceButton.transform.localPosition = currentPosition;



        
        currentPosition.y -= spacing;
        


    }




  }

    private void ClearChoices()
    {
        foreach(Transform child in container.transform)
        {
            Destroy(child.gameObject);
        }
    }
}
