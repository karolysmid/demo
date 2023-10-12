using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogDisplay : MonoBehaviour
{
[SerializeField] public TextMeshProUGUI tmprog;
    
    public void DisplayNPCText(string text)
    {

    tmprog.text=text;

    }

}
