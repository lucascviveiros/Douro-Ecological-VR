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

        //Vector3 newBeginPos = transform.localToWorldMatrix * new Vector4(beginPos.x, beginPos.y, beginPos.z, 1);
        //Vector3 newEndPos = transform.localToWorldMatrix * new Vector4(endPos.x, endPos.y, endPos.z, 1);

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
