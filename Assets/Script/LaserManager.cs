using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserManager : MonoBehaviour
{
    private LineRenderer laser;

    void Start()
    {
        laser = GetComponent<LineRenderer>();
    }

    void Update()
    {
        laser.SetPosition(0, transform.position);
         RaycastHit hit;
          if (Physics.Raycast(transform.position, transform.forward, out hit))
          {
              if (hit.collider)
              {
                  laser.SetPosition(1, hit.point);
              }
          }
          else laser.SetPosition(1, transform.forward * 5000);
      
    }
}
