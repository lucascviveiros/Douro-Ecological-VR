using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HotspotTimer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
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

         
            if (currentHotspot == "HotspotFootToExterior" || currentHotspot == "HotspotFootBackCena1")
            {
                camera.transform.position = new Vector3(128f, 0f, 0f); //Move camera 
            }
            else if (currentHotspot == "HotspotShip2") //Poco das Lontras to Vale da Aguia
            {
                camera.transform.position = new Vector3(256f, 0f, 0f); //Move camera
            }
            else if (currentHotspotTag == "MENU")
            {
                SceneManager.LoadScene("MENU"); //Troca a cena 
            }

            else
            {
                camera.transform.position = new Vector3(64f, 0f, 0f); //Move camera
            }
            ploc.Play();
        }

        timeremain--;
    }
    
    public void OnSelect(BaseEventData eventData)
    {
        //Debug.Log(this.gameObject.name + " was selected");
    }

}
