using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HotspotInformation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject halo;
    public Canvas canvasInformation;
    private string currentHotspot;
    private string currentHotspotTag;

    void Start()
    {
        halo.GetComponent<GameObject>();
        halo.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //do your stuff when highlighted
        halo.SetActive(true);
        currentHotspotTag = eventData.pointerCurrentRaycast.gameObject.tag.ToString();
        
        if (currentHotspotTag == "CanvasInformation")
        {
            StopAllCoroutines();
            canvasInformation.gameObject.SetActive(true);
            NotificationCenter.DefaultCenter().PostNotification(this, "EmNada"); // pra ativar cursor de carregar
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        halo.SetActive(false);
        //do stuff when highlighted
        NotificationCenter.DefaultCenter().PostNotification(this, "EmNada");
        StartCoroutine(WaitInformationReading());
    }

    IEnumerator WaitInformationReading()
    {
        yield return new WaitForSecondsRealtime(12);
        canvasInformation.gameObject.SetActive(false);
    }

    public void OnSelect(BaseEventData eventData)
    {
        Debug.Log(this.gameObject.name + " was selected");
    }
}
