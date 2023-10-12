using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public abstract class Consts : MonoBehaviour
{
    
   public abstract List<PlayerOption> GetPlayerOptions(int state);
}
