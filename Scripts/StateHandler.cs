using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public  class StateHandler 
{
  static  int id=0, stateID=0;
    const int MET=0,WORKS = 1, TODD = 2, SECRET = 3; 
    static int[] METCHOICES={1,2,3,4};
   const int JODD_HELLO=0, JODD_IMALRIGHT = 1, JODD_TODD = 2, JODD_WHYYOURUN = 3, JODD_RAISESEYEBROWS = 4, JODD_NAME = 5, JODD_SECRET = 6;
   const int PLAYER_HOWAREYOU=0, PLAYER_GENERALKENOBI=1, PLAYER_FAMILIAR = 2, PLAYER_RUN = 3, PLAYER_ITJUSTWORKS = 4, PLAYER_SKYRIM=5, PLAYER_SECRET = 6;
    static List<State> stateList= new List<State>();
// As of now, all text is merged into this and will be given a system where I identify the correct dialogue to be displayed. 

   static string [] NPCDataSet1={"Hello there! I am the magic Game Director! Isn't game development wonderful?", 
   "I am alright. I have been playing a lot of Starfield recently", "Todd? I am not sure who that is. My name is Jodd","Why do you run?", "*raises eyebrows*I'm not sure", "My name is Jodd Boward, not someone else", "Okay, since you are here, I will tell you the secret. Jump down from the platform to enable 16 times the detail!"};
    static string [] answersDataSet1={"How are you?","General Kenobi", "You look familiar...Todd?", "run",
     "it just works?", "you really look like you want to sell me Skyrim", "there must be a secret!"};
   
    static string [] NPCDataSet2={"Oh hi ", "Let's go eat huh?", "Let's play football", "You're just a chicken, cheep cheep cheep", "cheep cheep cheep"};
    static string [] answersDataSet2={"Hi there", "No thanks", "In tuxedos?", "Stop", "No"};
   
   
  static public void Test()
   {
    stateList.Add(new State(0,0,NPCDataSet1, answersDataSet1));
    GameObject.FindGameObjectWithTag("MakeButtons").GetComponent<MakeButtons>().CreateButtonLayout(stateList[0].GetOptions(), stateList[0].GetReplies());
   }
   static public void HandleState()
    {


        
      //  stateList[0].SetState(0);

     //   stateList[0].GetAnswers();
        GameObject.FindGameObjectWithTag("MakeButtons").GetComponent<MakeButtons>().CreateButtonLayout(stateList[0].GetOptions(), stateList[0].GetReplies());
    }
   static public string[] HandleState(int i)
    {
        stateList[0].SetState(i);

        
        GameObject.FindGameObjectWithTag("MakeButtons").GetComponent<MakeButtons>().CreateButtonLayout(stateList[0].GetOptions(), stateList[0].GetReplies());

        return stateList[0].GetAnswers(1);
    }

    internal static void CreateStates()
    {
       
    stateList.Add(new State(0,0,NPCDataSet1, answersDataSet1));
    stateList.Add(new State(1,0,NPCDataSet1, answersDataSet1));


    }
}
