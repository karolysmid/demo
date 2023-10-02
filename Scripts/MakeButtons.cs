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

  public void TestWithDummytext()
  {
  //  CreateButtonLayout(new string[]{"Hi","It just works?" ,"You look familiar... Todd?","Run" });

  }

  void Start()
  {
   // buttonContainer = GameObject.FindGameObjectWithTag("ButtonContainer");
    //dialogDisplay =  GameObject.FindGameObjectWithTag("DialogDisplay").GetComponent<DialogDisplay>();
    
  }
  public void Reply()
  {
   // CreateButtonLayout(new string[]{"How are you?","Stop! You violated the law!" ,"I want to play Starfield","Run" });
  }
  public void CreateButtonLayout(string[] choices, int[]replies)
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



        
        currentPosition.y -= spacing;
        


    }




  }

    private void ClearChoices()
    {
        foreach(Transform child in buttonContainer.transform)
        {
            Destroy(child.gameObject);
        }
    }
}
