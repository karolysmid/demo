using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonHandler : MonoBehaviour
{
    public GameLogic gameLogic;
    public string id;
    public int idnum;
    // Start is called before the first frame update


    public void OnClick()
    {
        gameLogic.ProcessButtonPress(id, idnum);
    }

    public void SetButtonID(string idset, int idnumber)
    {
    id = idset;
    idnum = idnumber;
    }
}
