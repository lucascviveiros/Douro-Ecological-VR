using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class HotspotPlayer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public int timeremain = 5; // time
    public GameObject halo;
    public GameObject OVRcamera;
    private string currentHotspot;
    public GameObject shortVideo;
    private GameObject sphereInstance;
    public AudioSource boatSound;
    [SerializeField]
    private MeshRenderer[] hotspotMesh;
    [SerializeField]
    private Canvas[] canvasAbutres;
    public MeshRenderer panoramicMesh;
    public Canvas canvasDesc;
    
    void Start()
    {
        halo.GetComponent<GameObject>();
        halo.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //do your stuff when highlighted
        halo.SetActive(true);
        InvokeRepeating("countDown", 1, 1);//llama al cursors
        NotificationCenter.DefaultCenter().PostNotification(this, "EmHotspot");
        currentHotspot = eventData.pointerCurrentRaycast.gameObject.name.ToString();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        halo.SetActive(false);
        //do your stuff when highlighted
        NotificationCenter.DefaultCenter().PostNotification(this, "EmNada");
        CancelInvoke("countDown");
        timeremain = 3;
    }

    private void countDown()
    {
        if (timeremain < 0)
        {      
            if (currentHotspot == "HotspotShip1") //Exterior to Poco das Lontas
            {
                panoramicMesh.GetComponent<MeshRenderer>().enabled = false;
                Renderer[] rs = hotspotMesh;
                foreach (Renderer r in rs)
                {
                    r.enabled = false;
                }

                Canvas[] canvas = canvasAbutres;
                foreach (Canvas c in canvas)
                {
                    c.enabled = false;
                }

                this.GetComponent<MeshRenderer>().enabled = false;
                sphereInstance = Instantiate(shortVideo);

                VideoPlayer videoPlayerFromSphere = sphereInstance.GetComponent<VideoPlayer>();
                canvasDesc.enabled = false;
                StartCoroutine(CoFunc());                
            }

            NotificationCenter.DefaultCenter().PostNotification(this, "EmNada");
            //reset time
            CancelInvoke("countDown");
            timeremain = 3;
            boatSound.Play();
        }
        timeremain--;
    }
    
    IEnumerator CoFunc()
    {
        yield return new WaitForSeconds(21);
        OVRcamera.transform.position = new Vector3(192f, 0f, 0f); //Troca a cena 
        panoramicMesh.GetComponent<MeshRenderer>().enabled = true;
        Renderer[] rs = hotspotMesh;
        foreach (Renderer r in rs)
        {
            r.enabled = true;
        }
        Canvas[] canvas = canvasAbutres;
        foreach (Canvas c in canvas)
        {
            c.enabled = true;
        }
        this.GetComponent<MeshRenderer>().enabled = true;
        canvasDesc.enabled = true;
    }

    public void OnSelect(BaseEventData eventData)
    {
        Debug.Log(this.gameObject.name + " was selected");
    }
}
