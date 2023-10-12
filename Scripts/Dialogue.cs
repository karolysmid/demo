using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]


public class PlayerOption
{
    public string text;
   public int linkID;

    public PlayerOption(string textSet, int linkIDset)
    {
        text=textSet;
        linkID=linkIDset;
    }



    

}

public class Dialogue : MonoBehaviour
    

{
    
   public string UILongText;

    int stateID;
    bool isActive = false;

    int nextDecisionId=-1;
   // string[]nextDecisionStirngs;
    
    Dialogue nextDialogue;

    List<PlayerOption> playerOptions = new List<PlayerOption>();

    public int GetState()
    {
        return stateID;
    }
    public List<PlayerOption> GetPlayerOptions()
    {
        return playerOptions;
    }
    public Dialogue(string text, int idsest, List<PlayerOption> playerOptionsSet)
    {
        UILongText = text;
        stateID = idsest;
        playerOptions=playerOptionsSet;
       
    }
     public Dialogue(string text, int idsest, Dialogue nextDialogueSet)
    {
        UILongText = text;
        stateID = idsest;
        nextDialogue =nextDialogueSet;
        
    }
     public Dialogue(string text, int idsest, int nextDialogueID)
    {
        UILongText = text;
        stateID = idsest;
        nextDecisionId = nextDialogueID;
        
    }
     public Dialogue(string text, int idsest)
    {
        UILongText = text;
        stateID = idsest;
        
    }


/*
    public Dialogue(string text, int idSet, int[] nextDecisionIDset, string[] nextDecisionStringsSet)
    {
        UILongText = text;
        id=idSet;
        nextDecisionId= nextDecisionIDset;
        nextDecisionStirngs = nextDecisionStringsSet;
    }

*/


/*

      public Decision(string playerOptionTextSet, string replyTextSet, Decision[] decisions)
    {
        replyText = playerOptionTextSet;
        replyText = replyTextSet;
        
    }*/

}
