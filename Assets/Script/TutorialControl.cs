using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class TutorialControl : MonoBehaviour
{
    private UnityEvent onButtonPressed;
    //private bool pressedInProgress = false;
    private int cont = 8;
    public GameObject sphere;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject buttonExitTutorial;
    public GameObject vrCam;

    private void Start()
    {
        text1.SetActive(true);
        text2.SetActive(true);
        text3.SetActive(false);
        text4.SetActive(false);
        buttonExitTutorial.SetActive(false);
        cont = 8;
    }
    
    private void OnTriggerEnter(Collider col)
    {
        if (!col.CompareTag("ButtonActivator") || col.Equals("OVRCameraRig") || col.Equals("ScifiManager"))
        {
            return;
        }
       
        //else if (col.CompareTag("ButtonActivator") && !pressedInProgress)
        //{
        else if (col.CompareTag("ButtonActivator"))
        {
            //pressedInProgress = true;
                      
            if (col.name == "ActivatorTestBall")
            {
                if (cont > 0)
                {
                    cont--;
                    SpawnSphere();
                    text1.SetActive(false);
                    text2.SetActive(false);
                    text3.SetActive(true);
                    text4.SetActive(true);
                    buttonExitTutorial.SetActive(true);
                }
            }

            else if (col.name == "ActivatorExitTutorial")
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        //if (other.IsTriggerButton())
        //{
          //  pressedInProgress = false;
       // }
    }

    private void SpawnSphere()
    {
        GameObject go = Instantiate(sphere, new Vector3( vrCam.transform.position.x + (UnityEngine.Random.value * 2), 1.5f, vrCam.transform.position.z + (UnityEngine.Random.value * 2)), Quaternion.identity) as GameObject;
        go.GetComponent<MeshRenderer>().material.color = new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f));

        //        GameObject go = Instantiate(sphere, new Vector3((UnityEngine.Random.value * 5), 1.5f, (UnityEngine.Random.value * 5)), Quaternion.identity) as GameObject;
 //       go.GetComponent<MeshRenderer>().material.color = new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f));
     }

    private void OnDestroy()
    {
        
    }

}