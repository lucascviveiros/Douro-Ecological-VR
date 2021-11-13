using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControll : MonoBehaviour
{
    //Sound
    private AudioSource source;
    //public AudioClip buttonSound;

    private bool on = false;
    private bool buttonHit = false;
    private GameObject button;

    private float buttonDownDistance = 0.025f;
    private float buttonReturnSpeed = 0.001f;
    private float buttonOriginalY;

//    public Light spotLight;

    //Time to hit again
    private float buttonHitAgainTime = 0.5f;
    private float canHitAgain;

    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
        //Get button and position
        button = transform.GetChild(0).gameObject;
        buttonOriginalY = button.transform.position.y;

        //turn off spotlight
        //sportLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonHit == true)
        {
            //playsound
           // source.PlayOneShot(buttonSound);

            buttonHit = false;

            //if on is true make on false, if on is false make on true
            on = !on;

            //change position
            button.transform.position = new Vector3(button.transform.position.x, button.transform.position.y - buttonDownDistance, button.transform.position.z);
            
            if (on)
            {
               // sportLight.enabled = true;
            }
            else
            {
             //   sportLight.enabled = false;
            }
        }

        //return orifinal position
        if(button.transform.position.y < buttonOriginalY)
        {
            button.transform.position += new Vector3(0, buttonReturnSpeed, 0);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("PlayerHand") && canHitAgain < Time.time)
        {
            canHitAgain = Time.time + buttonHitAgainTime;
            buttonHit = true;
        }
    }

    private void OnDestroy()
    {

    }

}
