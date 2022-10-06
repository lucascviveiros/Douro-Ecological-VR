using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject Camera;
    private const float DISTANCE = 1.6f;
    private float SPEED = 0.5f;
    public void HeadLock()
    {
        float speed;
        speed = Time.deltaTime * SPEED;

        Vector3 posTo = Camera.transform.position + (Camera.transform.forward * DISTANCE);
        posTo.y = 0.1f;
        transform.position = Vector3.SlerpUnclamped(transform.position, posTo, speed);    
        
        Quaternion rotTo = Quaternion.LookRotation(transform.position - Camera.transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotTo, speed);
    }
 
    private void Update()
    {
        HeadLock();
    }

}
