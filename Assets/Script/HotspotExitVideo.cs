using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HotspotExitVideo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public VideoManager videoManager = null;
    //public MenuSceneControll menuSceneControll;
    public int timeremain = 3; // time
    public GameObject halo;
    public GameObject camera;
    private string currentHotspot;
    private string currentHotspotTag;
    public AudioSource ploc;
    // Use this for initialization
    void Start () 
    {
        halo.GetComponent<GameObject>();
        halo.SetActive(false);
        ploc.GetComponent<AudioSource>();
    }
 
    public void OnPointerEnter(PointerEventData eventData)
    {
        //do your stuff when highlighted
        halo.SetActive(true);

        currentHotspot = eventData.pointerCurrentRaycast.gameObject.name.ToString();
        currentHotspotTag = eventData.pointerCurrentRaycast.gameObject.tag.ToString();
       
        if (currentHotspot == "HotspotShip2")
        {
            InvokeRepeating("countDown", 1, 1);//llama al cursors
            NotificationCenter.DefaultCenter().PostNotification(this, "EmHotspot");
        }
        else    
        {
            InvokeRepeating("countDown", 1, 1);//llama al cursors
            NotificationCenter.DefaultCenter().PostNotification(this, "EmHotspot");
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        halo.SetActive(false);
        //do your stuff when highlighted
        NotificationCenter.DefaultCenter().PostNotification(this, "EmNada");
        CancelInvoke("countDown");
        timeremain = 3;
    }

    void countDown()
    {
        if (timeremain < 0)
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "EmNada");
            //reset time
            CancelInvoke("countDown");
            timeremain = 3;

            if (videoManager.GetCurrentVideo() == 1 || videoManager.GetCurrentVideo() == 2 || videoManager.GetCurrentVideo() == 3 || videoManager.GetCurrentVideo() == 4) 
            {
                //videoManager.PlayVideoMenu();
                ploc.Play();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //MENU scene

            }


            else if (videoManager.GetCurrentVideo() == 0 && currentHotspotTag == "Exit")
            {
                //SceneManager.LoadSceneAsync("TOUR");
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
                UnityEngine.Application.Quit();
# endif
            }
        }

        timeremain--;
    }
    
    public void OnSelect(BaseEventData eventData)
    {
        //Debug.Log(this.gameObject.name + " was selected");
    }

}
