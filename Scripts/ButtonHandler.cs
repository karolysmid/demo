using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonHandler : MonoBehaviour
{
    
    public string id;
    public int replyID;
    // Start is called before the first frame update


    public void OnClick()
    {
      
       GameLogic.ProcessButtonPress(id, replyID);
    }

    public void SetButtonID(string idset, int replyIDset)
    {
    id = idset;
    replyID = replyIDset;
    }
}
