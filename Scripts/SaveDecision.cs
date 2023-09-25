using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SaveDecision : MonoBehaviour
{

    public GameObject UI;
    const int PAIDTHEFINE=0;
    const int RAN=1;
    private TriggerHandler logic;
   
    
    public GameObject UIhost;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void OnEnable()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

/*
    public void SaveChoice(int num)
    {
         logic = GameObject.FindGameObjectWithTag("TriggerHandler").GetComponent<TriggerHandler>();
         
        text = GameObject.FindGameObjectWithTag("DialogDisplay").GetComponent<TextMeshProUGUI>();
        if(num==RAN)
        {
        Debug.Log(text);

        logic.DisableSelected();
        }
        text.text=textData[num];
    }*/
}
