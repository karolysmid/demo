using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State 
{
    
State[] nextStateref;
int id;
int state;

Dialogue[] decisions;
int[] answers, questions;
string[] NPCSpeechdata,PlayerSpeechData;

const int JODD_HELLO=0, JODD_IMALRIGHT = 1, JODD_TODD = 2, JODD_WHYYOURUN = 3, JODD_RAISESEYEBROWS = 4, JODD_NAME = 5, JODD_SECRET = 6;
   const int PLAYER_HOWAREYOU=0, PLAYER_GENERALKENOBI=1, PLAYER_FAMILIAR = 2, PLAYER_RUN = 3, PLAYER_ITJUSTWORKS = 4, PLAYER_SKYRIM=5, PLAYER_SECRET = 6;



public State(int idset, int stateset, string[] NPCspeechdataSet, string[] PlayerSpeechDataSet)
{

    

    id=idset;
    state = stateset;
    NPCSpeechdata = NPCspeechdataSet;
    PlayerSpeechData = PlayerSpeechDataSet;
}

public void SetState(int statesetter)
{
    state = statesetter;
}
/* BAD CODE, it sohuldn't be between 2, I sohuld rather pass the entire list
string[] GetStringList(int[] startAndEnd, string[] strings)
{
    List<string> tempStringList = new List<string>();
    for(int i=startAndEnd[0]; i<startAndEnd[1]; i++)
    {
        tempStringList.Add(strings[i]);
    }
    return tempStringList.ToArray();
} */
string[] GetStringList(int[] activeOptions, string[] strings)
{
    List<string> tempStringList = new List<string>();
    for(int i=0; i<activeOptions.Length; i++)
    {
        tempStringList.Add(strings[activeOptions[i]]);
         Debug.Log(tempStringList[i]);
    }
   
    return tempStringList.ToArray();
}

public string[] GetOptions(){


    switch(state){
        case 0: return GetStringList(new int[]{PLAYER_HOWAREYOU,PLAYER_GENERALKENOBI,PLAYER_FAMILIAR,PLAYER_ITJUSTWORKS,PLAYER_RUN}, PlayerSpeechData) ;
         case 1: return GetStringList(new int[]{PLAYER_SKYRIM,PLAYER_RUN}, PlayerSpeechData) ;
         case 2: return GetStringList(new int[] {PLAYER_SECRET,PLAYER_RUN},PlayerSpeechData);



    }


    return PlayerSpeechData;
}
public string[] GetAnswers(int state)
{
    return NPCSpeechdata;
}

public string[] GetAnswers()
{
    return NPCSpeechdata;
}

    public int[] GetReplies()
    {

            StateHandler.GetPlayerReplies();
            {

            }
        /*
        switch(state)
        {



            case 0: return TextData.state1_01;
            case 1: return TextData.state1_NPC_02;
            case 2: return new int[]{JODD_SECRET,JODD_WHYYOURUN};
        }

        */
        return new int[]{};
    }
}
