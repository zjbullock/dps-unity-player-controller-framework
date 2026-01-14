using UnityEngine;
using UnityEngine.InputSystem;

namespace DPS
{
    namespace SimplePlayerControlsFrameWork
    {
        public abstract class PlayerInputBaseController : MonoBehaviour, IPlayerControls
{
    [Header("Component Refs")]

    protected PlayerInputActions PlayerInputActions;

    protected virtual void Awake()
    {
        if (this.PlayerInputActions == null)
            this.PlayerInputActions = new PlayerInputActions();


    }

    protected virtual void Start()
    {
        return;
    }


    protected virtual void OnEnable()
    {
        EnablePlayerInputActions();

    }

    protected virtual void OnDisable()
    {
        DisablePlayerInputActions();
    }

    public abstract void EnablePlayerInputActions();

    public abstract void DisablePlayerInputActions();
    
    // protected bool VerifySceneTransitionService()
    // {
    //     return SceneTransitionService.instance != null;
    // }

    public abstract void OnPauseInput(InputAction.CallbackContext context);

    public abstract void OnCancelInput(InputAction.CallbackContext context);

    public abstract void OnSubmitInput(InputAction.CallbackContext context);

    public abstract void OnOptionOneInput(InputAction.CallbackContext context);
    
    public abstract void OnOptionTwoInput(InputAction.CallbackContext context);

    public abstract void OnNavigateInput(InputAction.CallbackContext context);
    // public abstract void OnNavigateShoulderInput(InputAction.CallbackContext context);

    public abstract void OnLeftShoulderInput(InputAction.CallbackContext context);

    public abstract void OnLeftTriggerInput(InputAction.CallbackContext context);

    public abstract void OnRightShoulderInput(InputAction.CallbackContext context);
    public abstract void OnRightTriggerInput(InputAction.CallbackContext context);
    // public abstract void OnNavigateTriggerInput(InputAction.CallbackContext context);

}
    }
}

