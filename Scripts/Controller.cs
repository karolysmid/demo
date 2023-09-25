using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

namespace Controllers{

    
    public class Controller : StarterAssetsInputs
    {
  
    private bool controlsEnabled=true;

    public void SetControlsEnabled(bool state)
    {
        controlsEnabled=state;
    }

    public bool GetControlsEnabled()
    {
        return controlsEnabled;
    }
    private void OnApplicationFocus(bool hasFocus)
		{
		   if(controlsEnabled)
			SetCursorState(cursorLocked);
		}


    }
}