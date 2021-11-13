using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class ButtonTrigger : MonoBehaviour
{
    private bool pressedInProgress = false; 
    public TriggerManager triggerManager = null;

    private void OnTriggerEnter(Collider col)
    {
            if (!col.CompareTag("ButtonActivator"))
            {
                return;
            }

            else if (col.CompareTag("ButtonActivator") && !pressedInProgress)
            {
                pressedInProgress = true;
                triggerManager.ButtonClick(col.name);
            }
           
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.IsTriggerButton())
        {
            pressedInProgress = false;
        }
    }

   
}
