using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public interface IPlayerControls 
{
    public void OnPauseInput(InputAction.CallbackContext context);
    
    public void OnCancelInput(InputAction.CallbackContext context);

    public void OnSubmitInput(InputAction.CallbackContext context);

    public void OnOptionOneInput(InputAction.CallbackContext context);
    
    public void OnOptionTwoInput(InputAction.CallbackContext context);

    public void OnNavigateInput(InputAction.CallbackContext context);

    // public void OnNavigateShoulderInput(InputAction.CallbackContext context);

    // public void OnNavigateTriggerInput(InputAction.CallbackContext context);
    
    public void OnLeftShoulderInput(InputAction.CallbackContext context);

    public void OnLeftTriggerInput(InputAction.CallbackContext context);

    public void OnRightShoulderInput(InputAction.CallbackContext context);
    public void OnRightTriggerInput(InputAction.CallbackContext context);
}
