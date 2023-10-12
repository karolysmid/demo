using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class Level1Consts : Consts
{
   

   string[] responces = {};




    public override List<PlayerOption> GetPlayerOptions(int state)
   {
        foreach(Dialogue dialogue in dialogueList)
        {

            
        if(dialogue.GetState()==state)
            {
                Debug.Log("dialogue is "+dialogue.UILongText);
                return dialogue.GetPlayerOptions(); 
            }
        }
        return new List<PlayerOption>();
   }

  public  static List<PlayerOption> playerOptionsInitial = new List<PlayerOption>(){new PlayerOption("hi",3), new PlayerOption("You look familiar",4)};

   static Dialogue DECISION_JODD_HELLO = new Dialogue("Hello, I am the magic Game Dev",1,playerOptionsInitial);
    


   static List<Dialogue> dialogueList= new List<Dialogue>{DECISION_JODD_HELLO};
}
