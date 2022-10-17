using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]
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
    private bool pressedInProgress = false;
    private bool lookButton;  
    private AudioSource buttonClick;
    private int[] cliques = new int[4];
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

    public IEnumerator ShowInitTable()
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
