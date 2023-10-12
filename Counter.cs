using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{


    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.FindGameObjectWithTag("Texter").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "spoke with Jodd " + StaticState.GetStatus()+ " times";
    }
}
