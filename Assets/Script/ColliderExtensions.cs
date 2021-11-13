using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColliderExtensions
{
    public static bool IsTriggerButton(this Collider col)
    {
        //Checking if has one element with ButtonActivator name
        return col.tag == "ButtonActivator";
    }
}
