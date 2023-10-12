using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public static class StaticState 
{

    
    static int status=0;

    static int background=0;
    const int DEFAULT = 0;
    const int MET=1;

    const int NAME =2;
    const int TODD=3;

   public static List<State> stateList = new List<State>();

    public static void AddToStates(State state)
    {
            stateList.Add(state);
    }

    

    public static void IncreaseStatus()
    {
        status++;
    }

    public static void SetStatus( int statusset)
    {
        status=statusset;
    }
    public static int GetStatus()
    {
        return status;
    }

    public static void DisplayStatus()
    {
        Debug.Log("current status is "+status);
    }
}
