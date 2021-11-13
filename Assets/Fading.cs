using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fading : MonoBehaviour
{
    public RawImage logo;
    public Texture douroVR;
    public Texture virtualLeaf;
    //private bool stopFading = false;
    public Animator animator;
    public Canvas canvas;
    public float fadingSpeed;

    // Start is called before the first frame update
    void Start()
    {
        logo.GetComponent<RawImage>().texture = douroVR;

        StartCoroutine(CanvasAlphaChangeOverTime(canvas,10f));

        //logo.GetComponent<RawImage>().sprite = douroVR;
    }

    IEnumerator CanvasAlphaChangeOverTime(Canvas canvas, float duration)
    {
        var alphaColor = canvas.GetComponent<CanvasGroup>().alpha;

       
            alphaColor = (Mathf.Sin(Time.time * duration) + 1.0f) / 2.0f;
            canvas.GetComponent<CanvasGroup>().alpha = alphaColor;


        
            yield return new WaitForSecondsRealtime(2.0f);
       
    }



}
