using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScifiManager : MonoBehaviour
{
    public GameObject Camera;
    private Vector3 camPosition;
    private float SPEED = 0.9f;
    private void Awake()
    {
        camPosition = Camera.transform.position;
        transform.position = new Vector3(0.0f, 0.6f, 0.0f);
    }

    public void ScifiMove()
    {
        float speed;
        speed = Time.deltaTime * SPEED;
        camPosition = Camera.transform.position;
        Vector3 posMov = new Vector3(camPosition.x + 0.1f, 0.6f, camPosition.z + 0.26f);
        transform.position = Vector3.SlerpUnclamped(transform.position, posMov, speed);
    }

    private void Update()
    {
        ScifiMove();
    }

}
