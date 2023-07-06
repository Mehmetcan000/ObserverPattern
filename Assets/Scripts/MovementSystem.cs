using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MovementSystem : MonoBehaviour
{
    //OBSERVER

    
    private void OnEnable()
    {
        MovementPanel.OnForwardButtonClicked += MoveForward;
        MovementPanel.OnBackButtonClicked += MoveBack;
        MovementPanel.OnRightButtonClicked += MoveRight;
        MovementPanel.OnLeftButtonClicked+= MoveLeft;
        
    }

    private void OnDisable()
    {
        MovementPanel.OnForwardButtonClicked -= MoveForward;
        MovementPanel.OnBackButtonClicked -= MoveBack;
        MovementPanel.OnRightButtonClicked -= MoveRight;
        MovementPanel.OnLeftButtonClicked -= MoveLeft;
    }


    public void MoveForward() => transform.Translate(Vector3.forward);
    
    public void MoveBack() => transform.Translate(Vector3.back);
    
    public void MoveRight() => transform.Translate(Vector3.right);
    
    public void MoveLeft() => transform.Translate(Vector3.left);


}
