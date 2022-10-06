using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.IO;

public class VideoManager : MonoBehaviour
{
    #region publicVariables
    public GameObject myCubeDirection, myMenuHotspot, myExitApp, scifiManager;
    public TriggerManager triggerManager;
    public GameObject[] Animals;
    public Canvas whiteCanvas;
    public AudioClip[] videoAudios = new AudioClip[2];
    public VideoEvent onPause = new VideoEvent();
    public VideoEvent onLoad = new VideoEvent();
    public RenderTexture mRenderTexture5K, mRenderTexture8K;
    public Material mVideoMaterial5K, mVideoMaterial8K; //5K:5760x2880 - 8K:7200x3600
    public Renderer mySphereRenderer;
    public Coroutine stopableCoRising;
    public SubtitleManager subtitleManager;
    public Canvas subtitleCanvas;
    public Light myDayLight;
    #endregion

    #region privateVariables
    private double phi, amplitude; //day light              Douro360_h265_5K_OculusQuest1_v3     Douro360_h265_8K_OculusQuest2_v3 
    private string[] videoList = { "boreal_texto_fixed_NOAUDIO.mp4", "Douro360_h265_8K_OculusQuest2_v3.mp4" };
    private bool isPaused = false;
    private string rootPath; //root path video folder in oculus gallery
    private string path; //actual path with root path and video's name
    private float timer = 0.0f;
    private bool risingDay;
    private bool returnTime;
    #endregion

    public bool IsPaused
    {
        get
        {
            return isPaused;
        }

        private set
        {
            isPaused = value;
            //Every time that is set the pause variable is gonna invoke this event
            //If we pause the video with the spacebar is going to cause
            //the pause toogle function which is going to switch that variable 
            //im summary, this event is used for changing quickly between icons, that is, precisly
            onPause.Invoke(isPaused);
        }
    }

    private bool isVideoReady = false;
    public bool IsVideoReady
    {
        get
        {
            return isVideoReady;
        }
        private set
        {
            isVideoReady = value;
            onLoad.Invoke(isVideoReady);
        }
    }

    private int index = 0;
    private VideoPlayer videoPlayer = null;
    public AudioSource audioSource = null;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>(); //my video player
        audioSource = GetComponent<AudioSource>();
        videoPlayer.targetTexture = mRenderTexture5K;
        mySphereRenderer.material = mVideoMaterial5K;

        videoPlayer.seekCompleted += OnComplete;
        videoPlayer.prepareCompleted += OnComplete;
        videoPlayer.loopPointReached += OnLoop;

        //Looping for the menu video
        videoPlayer.isLooping = true;
        audioSource.Play();

        myExitApp.SetActive(true);
        subtitleCanvas.enabled = false;
        risingDay = false;
        returnTime = false;
    }

    public void Start()
    {
        videoPlayer.errorReceived += VideoPlayer_errorReceived;
        audioSource = GetComponent<AudioSource>();
        PlayVideoMenu();
    }

    public void PauseToggle()
    {
        IsPaused = !videoPlayer.isPaused;

        if (isPaused)
            videoPlayer.Pause();
        else
            videoPlayer.Play();
    }

    private void OnDestroy()
    {
        videoPlayer.seekCompleted -= OnComplete;
        videoPlayer.prepareCompleted -= OnComplete;
        videoPlayer.loopPointReached -= OnLoop;
    }

    public int GetIndex()
    {
        return index;
    }


    public void PlayVideoMenu()
    {
        index = 0;
        StartPrepare(0);
        StopAllCoroutines();
        triggerManager.StopAllCoroutines();

        videoPlayer.targetTexture = mRenderTexture5K;
        mySphereRenderer.material = mVideoMaterial5K;
        myMenuHotspot.SetActive(false);
        myCubeDirection.SetActive(true);
        Animals[0].SetActive(true);
        Animals[1].SetActive(true);
        triggerManager.EnableScifi();

        StartCoroutine(ReturnDayLight()); //Day Light
        StartCoroutine(RisingDayAgain());
        subtitleCanvas.enabled = false;
        subtitleManager.StopAllCoroutines();
    }

    
    public void PlayVideoPortuguese()
    {
        index = 1;
        StartPrepare(1); 
        StopAllCoroutines();
        triggerManager.StopAllCoroutines();
        videoPlayer.targetTexture = mRenderTexture8K;
        mySphereRenderer.material = mVideoMaterial8K;
        myExitApp.SetActive(false);
        myMenuHotspot.SetActive(true);
        myCubeDirection.SetActive(false);
        Animals[0].SetActive(false);
        Animals[1].SetActive(false);
        whiteCanvas.enabled = false;
    }
    public void PlayVideoSpanish()
    {
        index = 2;
        StartPrepare(1);
        StopAllCoroutines();
        triggerManager.StopAllCoroutines();
        videoPlayer.targetTexture = mRenderTexture8K;
        mySphereRenderer.material = mVideoMaterial8K;
        myExitApp.SetActive(false);
        myMenuHotspot.SetActive(true);
        myCubeDirection.SetActive(false);
        Animals[0].SetActive(false);
        Animals[1].SetActive(false);
        whiteCanvas.enabled = false;
    }
    public void PlayVideoEnglish()
    {
        index = 3;
        StartPrepare(1);
        StopAllCoroutines();
        triggerManager.StopAllCoroutines();
        videoPlayer.targetTexture = mRenderTexture8K;
        mySphereRenderer.material = mVideoMaterial8K;
        myExitApp.SetActive(false);
        myMenuHotspot.SetActive(true);
        myCubeDirection.SetActive(false);
        Animals[0].SetActive(false);
        Animals[1].SetActive(false);
        whiteCanvas.enabled = false;
    }
    public void PlayVideoFrench()
    {
        index = 4;
        StartPrepare(1);
        StopAllCoroutines();
        triggerManager.StopAllCoroutines();
        videoPlayer.targetTexture = mRenderTexture8K;
        mySphereRenderer.material = mVideoMaterial8K;
        myExitApp.SetActive(false);
        myMenuHotspot.SetActive(true);
        myCubeDirection.SetActive(false);
        Animals[0].SetActive(false);
        Animals[1].SetActive(false);
        whiteCanvas.enabled = false;
    }
    
    public int GetCurrentVideo()
    {
        return index;
    }

    public void SearchVideoList(int videoPosition)
    {
        StartPrepare(videoPosition);
    }

    private void StartPrepare(int clipIndex)
    {
        isVideoReady = false;

        videoPlayer.url = StreamingVideo(clipIndex);

        videoPlayer.Prepare();
    }

    private void OnComplete(VideoPlayer videoPlayer)
    {
        IsVideoReady = true;
        videoPlayer.Play();

        if (index == 0)
        {
            audioSource.clip = videoAudios[0]; //menu sound
            audioSource.Play();
        }
        else if (index == 1)
        {
            audioSource.clip = videoAudios[1]; //xana sound
            audioSource.Play();
            subtitleCanvas.enabled = true;
            subtitleManager.PortuguesSubtitle();
        }
        else if (index == 2)
        {
            audioSource.clip = videoAudios[1];
            audioSource.Play();
            subtitleCanvas.enabled = true;
            subtitleManager.SpanishSubtitle();
        }
        else if (index == 3)
        {
            audioSource.clip = videoAudios[1];
            audioSource.Play();
            subtitleCanvas.enabled = true;
            subtitleManager.EnglishSubtitle();
        }
        else if (index == 4)
        {
            audioSource.clip = videoAudios[1];
            audioSource.Play();
            subtitleCanvas.enabled = true;
            subtitleManager.FrenchSubtitle();
        }
    }

    private void OnLoop(VideoPlayer videoPlayer)  //* Looping only for the Menu video
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public class VideoEvent : UnityEvent<bool>
    {

    }

    //Streaming video from oculus root folder
    public string StreamingVideo(int clipIndex)
    {
        string fileName = videoList[clipIndex];
        rootPath = Application.persistentDataPath;
        path = Path.Combine(rootPath, fileName);

        return path;
    }

    private void VideoPlayer_errorReceived(VideoPlayer source, string message)
    {
        videoPlayer.errorReceived -= VideoPlayer_errorReceived;
    }

    private void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (returnTime == false && risingDay == false)
        {
            if (myDayLight.intensity >= 0.333)
            {
                DayLightTransition();
            }
        }

        else if (risingDay == true && returnTime == true)
        {
            if (myDayLight.intensity <= 1.0)
            {
                RisingSun(); //voltando a clarear no final
            }
        }
    }

    public void DayLightTransition()
    {
        phi = timer / 90 * 2 * Mathf.PI;
        amplitude = (Mathf.Cos((float)phi) * 0.5) + 0.5;
        myDayLight.intensity = (float)amplitude;
    }

    public void RisingSun()
    {
        myDayLight.intensity = Mathf.Lerp(myDayLight.intensity, 1.0f, Time.deltaTime * 0.1f);
    }

    public IEnumerator ReturnDayLight()
    {
        returnTime = true; 
        timer = 0;
        myDayLight.intensity = 1;
        yield return new WaitForSecondsRealtime(1);
        returnTime = false; //back decreasing light
        risingDay = false;
    }

    public IEnumerator RisingDayAgain()
    {
        yield return new WaitForSecondsRealtime(68);
        returnTime = true;
        risingDay = true;
    }
}
