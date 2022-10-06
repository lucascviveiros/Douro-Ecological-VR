using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TriggerManager : MonoBehaviour
{
    #region publicRegion
    public VideoManager videoManagerStreaming = null;
    public GameObject scifiManager;
    public Canvas whiteCanvas;
    public Collider[] boxCollider = new Collider[5];
    #endregion

    #region privateRegion
    private bool pressedInProgress = false;
    private AudioSource buttonClick;
    private bool lookButton;
    private int[] cliques = new int[4];
    private bool showParticle;
    #endregion  

    private void Start()
    {
        lookButton = false;
        buttonClick = GetComponent<AudioSource>();
        whiteCanvas.enabled = false;
        Renderer[] rs = scifiManager.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
        {
            r.enabled = false;
        }

        DisableColliders();
    }

    private void DisableColliders()
    {
        foreach (Collider c in boxCollider)
        {
            c.enabled = false;
        }
    }

    public void ButtonClick(string index)
    {
        if (lookButton)
        {
            if (index == "ActivatorVideoPT")
            {
                StartCoroutine(WaitButtonForVideo360(0));

            }
            else if (index == "ActivatorVideoES")
            {
                StartCoroutine(WaitButtonForVideo360(1));

            }
            else if (index == "ActivatorVideoEN")
            {
                StartCoroutine(WaitButtonForVideo360(2));

            }
            else if (index == "ActivatorVideoFR")
            {
                //cliques[3]++;
                StartCoroutine(WaitButtonForVideo360(3));
            }
            else if (index == "ActivatorTOUR")
            {
                StartCoroutine(WaitButtonForVideo360(4));
            }
        }
    }

    private IEnumerator WaitButtonForVideo360(int indexButton)
    {
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
            //audioSource.Stop();
            if (indexButton == 0)
            {
                videoManagerStreaming.PlayVideoPortuguese();
            }
            else if (indexButton == 1)
            {
                videoManagerStreaming.PlayVideoSpanish();
            }
            else if (indexButton == 2)
            {
                videoManagerStreaming.PlayVideoEnglish();
            }
            else if (indexButton == 3)
            {
                videoManagerStreaming.PlayVideoFrench();
            }
            else if (indexButton == 4)
            {
                SceneManager.LoadSceneAsync("TOUR");
            }
        }
    }

    IEnumerator ShowInitTable()
    {
        yield return new WaitForSecondsRealtime(30);
        whiteCanvas.enabled = true;
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
