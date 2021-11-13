using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLimit : MonoBehaviour
{
    [SerializeField]
    private GameObject buttonActivator;
    //private Vector3 originalPosition;
    private float originalPositionY;
    private float minDistance;
    private float maxDistance;
    public Rigidbody rigidbody;
    public TriggerManager triggerManager;
    private bool LookingToButton;
    
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        //calculate the min distance between activator and the trigger
        minDistance = Vector3.Distance(buttonActivator.transform.position, transform.position);
        maxDistance = buttonActivator.transform.position.y;

        //originalPosition = transform.position; //antes

        originalPositionY = transform.position.y;
        
        //coisa nova aqui
        rigidbody.constraints = RigidbodyConstraints.FreezeAll;

    }

    void Update()
    {
        // ensure we restore original position if the distance is >= to min
        
        if (Vector3.Distance(buttonActivator.transform.position, transform.position) >= minDistance)
        {
            //transform.position = originalPosition;//antes
            transform.position = new Vector3(transform.position.x, originalPositionY, transform.position.z);
        }
        
        // verify the position Y 
        if (transform.position.y <= maxDistance)
        {
            transform.position = new Vector3(transform.position.x, maxDistance, transform.position.z);
        } 

        if (!LookingToButton)
        {
            ChangeYButton();
        }
    }

    //HANDS
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Algo tocou");
        if (LookingToButton)
        {
            if (collision.gameObject.name == "CubePalmLeft" || collision.gameObject.name == "CubePalmRight" || collision.gameObject.name == "OVRHandLeftPalmCube" || collision.gameObject.name == "OVRHandRightPalmCube")
            {
                //Debug.Log("Mao tocou botao");
                ChangeYButton();
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (LookingToButton) { 
            if (collision.gameObject.name == "CubePalmLeft" || collision.gameObject.name == "CubePalmRight" || collision.gameObject.name == "OVRHandLeftPalmCube" || collision.gameObject.name == "OVRHandRightPalmCube")
            {
                //Debug.Log("Mao ficou botao");
                ChangeYButton();
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "CubePalmLeft" || collision.gameObject.name == "CubePalmRight" || collision.gameObject.name == "OVRHandLeftPalmCube" || collision.gameObject.name == "OVRHandRightPalmCube")
        {
            //Debug.Log("Mao saiu do botao");
            ChangeYButton();
            StartCoroutine(ReleaseButton());
        }
    }

    //EYES
    //Controla pra ver se usuario esta olhando para o botao
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "CubeLookDirection")
        {
            //Debug.Log("Olhando pro botao");
            LookingToButton = true;
            triggerManager.LookButton(LookingToButton);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "CubeLookDirection")
        {
            //Debug.Log("Continua olhando pro botao");
            LookingToButton = true;

            triggerManager.LookButton(LookingToButton);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "CubeLookDirection")
        {
            //Debug.Log("Parou de olhar pro botao");
            LookingToButton = false;
            //menuSceneControll.LookButton(LookingToButton);

            triggerManager.LookButton(LookingToButton);
            ChangeYButton();
        }
    }

    IEnumerator ReleaseButton()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        rigidbody.constraints = RigidbodyConstraints.FreezeAll;
    }

    public void ChangeYButton()
    {
        //Descongela pra voltar pra cima OU pra baixo
        //Descongela pro Y mover
        rigidbody.constraints &= ~RigidbodyConstraints.FreezePositionY;
    }
}
