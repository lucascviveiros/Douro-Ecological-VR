using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public GameObject gameObject;

    private void Awake()
    {
        StartCoroutine(AutoDestroyTimer());
    } 

    IEnumerator AutoDestroyTimer()
    {
        yield return new WaitForSeconds(21);
        Destroy(gameObject);
    }
}
