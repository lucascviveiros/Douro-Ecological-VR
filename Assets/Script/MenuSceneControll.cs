using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//[RequireComponent(typeof(Collider))]
public class MenuSceneControll : MonoBehaviour
{
    #region publicRegion
    public VideoManager videoManagerStreaming = null;
    public GameObject scifiManager;
    public Canvas whiteCanvas;
    public Collider[] boxCollider = new Collider[5];

    
   
    #endregion

    #region privateRegion
    private int vLanguage;
    //private UnityEvent onButtonPressed;
    private bool pressedInProgress = false;
    private bool lookButton;  
    private AudioSource buttonClick;
    private int[] cliques = new int[4];
    //[SerializeField]
    //private Collider[] boxCollider = new Collider[5];
    #endregion

    private void Start()
    {
        lookButton = false;
        buttonClick = GetComponent<AudioSource>();

        cliques[0] = 0; //Pt
        cliques[1] = 0; //Sp
        cliques[2] = 0; //En
        cliques[3] = 0; //Fr

        DisableColliders();
    }
    private void DisableColliders()
    {
        foreach (Collider c in boxCollider)
        {
            c.enabled = false;
        }
    }
    /*
    private void OnTriggerEnter(Collider col)
    {
        if (lookButton)
        {
            if (!col.CompareTag("ButtonActivator"))
            {
                return;
            }

            else if (col.CompareTag("ButtonActivator") && !pressedInProgress)
            {
                pressedInProgress = true;
                               
                if (col.name == "ActivatorVideoPT")
                {
                    vLanguage = 0;
                    StartCoroutine(WaitButtonForVideo360());
                }
                else if (col.name == "ActivatorVideoES")
                {
                    vLanguage = 1;
                    StartCoroutine(WaitButtonForVideo360());
                }

                else if (col.name == "ActivatorVideoEN")
                {
                    vLanguage = 2;
                    StartCoroutine(WaitButtonForVideo360());
                }
                else if (col.name == "ActivatorVideoFR")
                {
                    vLanguage = 3;
                    StartCoroutine(WaitButtonForVideo360());
                }
                else if (col.name == "ActivatorTOUR")
                {
                    vLanguage = 5;
                    
                    //SceneManager.LoadSceneAsync("TOUR");
                }
            }
        }
    }

    private IEnumerator WaitButtonForVideo360()
    {
        yield return new WaitForSeconds(1);

        if (videoManagerStreaming.GetCurrentVideo() == 0) //to avoid 2 button clicks on menu's loop 
        {
            if (vLanguage == 0)
            {
                cliquesPT.text = cliques[0].ToString();
            }
            else if (vLanguage == 1)
            {
                cliquesSP.text = cliques[1].ToString();
            }
            else if (vLanguage == 2)
            {
                cliquesEN.text = cliques[2].ToString();
            }
            else if (vLanguage == 3)
            {
                cliquesFR.text = cliques[3].ToString();
            }

            videoManagerStreaming.PlayFakeVideoDebug();

        }

    */

    /*
    buttonClick.Play(0);

    videoManagerStreaming.PauseToggle();

    foreach (Collider c in boxCollider)
        c.enabled = false;

    yield return new WaitForSeconds(1);

    Renderer[] rs = scifiManager.GetComponentsInChildren<Renderer>();
    foreach (Renderer r in rs)
        r.enabled = false;

    if (videoManagerStreaming.GetCurrentVideo() == 0) //to avoid 2 button clicks on menu's loop 
    {
        if (vLanguage == 0)
        {
            videoManagerStreaming.PlayVideoPortuguese();
        }
        else if (vLanguage == 1)
        {
            videoManagerStreaming.PlayVideoSpanish();
        }
        else if (vLanguage == 2)
        {
            videoManagerStreaming.PlayVideoEnglish();
        }
        else if (vLanguage == 3)
        {
            videoManagerStreaming.PlayVideoFrench();
        }
    }

    */





IEnumerator ShowInitTable()
    {
        yield return new WaitForSecondsRealtime(30);

        whiteCanvas.enabled = true;
        //Mostrando ScifiManager
        Renderer[] rs = scifiManager.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
        {
            if (r.name == "ButtonHolder")
            {
                r.enabled = false;
            }
            else

            {
                r.enabled = true;
            }
        }

        foreach (Collider c in boxCollider)
        {
            c.enabled = true;
        }
    }

    public void EnableScifi()
    {
        StartCoroutine(ShowInitTable());
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.IsTriggerButton())
        {
            pressedInProgress = false;
        }
    }

    public void LookButton(bool value) //value change from ButtonLimit Class
    {
        lookButton = value;
    }

}