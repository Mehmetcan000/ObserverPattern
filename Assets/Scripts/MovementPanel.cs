using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPanel : MonoBehaviour
{
    //Subject

    public static event Action OnForwardButtonClicked;
    public static event Action OnBackButtonClicked;
    public static event Action OnRightButtonClicked;
    public static event Action OnLeftButtonClicked;




    public void ForwardOnClick()
    {
        OnForwardButtonClicked?.Invoke();
    }
    
    public void BackOnClick()
    {
        OnBackButtonClicked?.Invoke();
    }
    public void RightOnClick()
    {
        OnRightButtonClicked?.Invoke();
    }
    public void LeftOnClick()
    {
        OnLeftButtonClicked?.Invoke();
    }
    
}
