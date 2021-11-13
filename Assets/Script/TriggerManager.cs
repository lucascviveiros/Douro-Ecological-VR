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
    //public ParticleSystem conffetiParticle;
    //public ParticleSystem fireworks;
    //public AudioSource audioSource = null;
    //public AudioClip fogoSound;
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
        //audioSource = GetComponent<AudioSource>();
        //audioSource.loop = true;

        //var emission = conffetiParticle.emission;
        //emission.enabled = false;
        //var fogos = fireworks.emission;
        //fogos.enabled = false;

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
                //cliques[0]++;
                StartCoroutine(WaitButtonForVideo360(0));

            }
            else if (index == "ActivatorVideoES")
            {
                //cliques[1]++;
                StartCoroutine(WaitButtonForVideo360(1));

            }
            else if (index == "ActivatorVideoEN")
            {
                //cliques[2]++;
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
    /*
    private IEnumerator WaitButtonForVideo360(int indexButton) ///Fake VIDEO Debug
    {
        buttonClick.Play(0);
        videoManagerStreaming.PauseToggle();

        foreach (Collider c in boxCollider)
            c.enabled = false;

        yield return new WaitForSeconds(1);

        if (videoManagerStreaming.GetCurrentVideo() == 0) //to avoid 2 button clicks on menu's loop 
        {
            if (indexButton == 0)
            {
                //ultimoButton.text = "Portugal";

                //cliquesPT.text = cliques[0].ToString();
            }
            else if (indexButton == 1)
            {
                //ultimoButton.text = "Spain";

                //cliquesSP.text = cliques[1].ToString();
            }
            else if (indexButton == 2)
            {
                //ultimoButton.text = "England";

                //cliquesEN.text = cliques[2].ToString();
            }
            else if (indexButton == 3)
            {
                //ultimoButton.text = "França";

                //cliquesFR.text = cliques[3].ToString();
            }

            videoManagerStreaming.PlayFakeVideoDebug();

        }
    }*/


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
        //yield return new WaitForSecondsRealtime(3); //FOR DEBUGGG

        //var emission = conffetiParticle.emission;
        //emission.enabled = true
        //var fogos = fireworks.emission;
        //fogos.enabled = true;

        //        yield return new WaitForSecondsRealtime(2);
        //audioSource.clip = fogoSound; //xana sound
        //audioSource.Play();

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
