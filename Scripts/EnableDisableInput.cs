using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using Controllers;
public class EnableDisableInput : MonoBehaviour
{
    public GameObject player;
   public FirstPersonController playerController;
    public Controller controller;
    public bool isInputdisabled=false;
    // Start is called before the first frame update(FirstPersonController) 
    void Start()
    {
       
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnEnable()
    {
        playerController = player.GetComponent<FirstPersonController>();
        controller =  player.GetComponent<Controller>();
    
       playerController.playerInputEnabled = false;
       controller.SetControlsEnabled(false);
       controller.SetCursorState(false);
      
      // starterAssetsInputs.cursorInputForLook=false;
    //   Cursor.visible=true;
    }
    void OnDisable()
    {
       playerController.playerInputEnabled = true;
       controller.SetControlsEnabled(true);
   controller.SetCursorState(true);
    //   starterAssetsInputs.cursorInputForLook = true;
      // Cursor.visible=false;
    }
}
