using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackManager : MonoBehaviour
{
    public float distance = 4.0f;
    public VideoManager videoManager = null;
    public Camera OVRcam;

    [Header("Icons")]
    public Sprite pause = null;
    public Sprite load = null;
    private SpriteRenderer spriteRenderer = null;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        SetupWithCamera();
        videoManager.onPause.AddListener(TogglePause);
        videoManager.onLoad.AddListener(ToggleLoad);
    }
    private void OnDestroy()
    {
        videoManager.onPause.RemoveListener(TogglePause);
        videoManager.onLoad.RemoveListener(ToggleLoad);
    }

    private void SetupWithCamera()
    {
        transform.parent = OVRcam.transform;
        transform.localRotation = Quaternion.identity;
        transform.localPosition = new Vector3(0, 0, distance);
    }

    private void TogglePause(bool isPaused)
    {
        spriteRenderer.sprite = pause;
        spriteRenderer.enabled = isPaused;
    }

    private void ToggleLoad(bool isLoaded)
    {
        spriteRenderer.sprite = load;
        spriteRenderer.enabled = !isLoaded;
    }
}
