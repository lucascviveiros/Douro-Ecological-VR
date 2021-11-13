using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillCursor : MonoBehaviour 
{
    //para timer ao contrario comeca do zero
    [SerializeField]
    public float time = 0.0f;
    private Image radial;
    private bool go = false;
    public AudioSource sound;
	void Start () 
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "EmHotspot");
        NotificationCenter.DefaultCenter().AddObserver(this, "EmNada");

        radial = GetComponent<Image>();
        radial.fillAmount = 0;

        sound = GetComponent<AudioSource>();
        //para timer ao contrario
        //radial.fillAmount = 1;	
    }

    void Update () 
    {
        if (go)
        {
            time = time + Time.deltaTime;
//            radial.fillAmount = 0 + time / 4;
            radial.fillAmount = 0 + time / 5;


            //para timer ao contrario
            //radial.fillAmount = 1 - time / 4;
        }
        else {
            radial.fillAmount = 0;

            //para timer ao contrario
            //radial.fillAmount = 1;
        }
    }

    void EmHotspot(Notification notificacion)
    {
        sound.Play();
        go = true;
        time = 0;
    }

    void EmNada(Notification notificacion)
    {
        sound.Stop();
        go = false;
    }
}
