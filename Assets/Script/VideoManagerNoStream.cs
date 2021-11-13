using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;

public class VideoManagerNoStream : MonoBehaviour
{
    public List<VideoClip> videos = null;
    public VideoEvent onPause = new VideoEvent();
    public VideoEvent onLoad = new VideoEvent();
    private bool isPaused = false;
    public bool isOver = false;

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

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        //Whenever we complete seeking player we gonna call the complete function
        //seekComplete is a event
        videoPlayer.seekCompleted += OnComplete;
        videoPlayer.prepareCompleted += OnComplete;
        videoPlayer.loopPointReached += OnLoop;
    }

    public void Start()
    {
        //StartPrepare(index);  //Play on start                     
    }

    public void PauseToggle()
    {
        IsPaused = !videoPlayer.isPaused;

        if (isPaused)
            videoPlayer.Pause();
        else
            videoPlayer.Play();
    }

    //similar ao enable/disable porem usando awake e destroy
    //o videomanager sempre ira existir porem iremos precisar disso quando nao estivermos rodando 
    //a aplicacao ou se for fechada
    private void OnDestroy()
    {
        videoPlayer.seekCompleted -= OnComplete;
        videoPlayer.prepareCompleted -= OnComplete;
        videoPlayer.loopPointReached -= OnLoop;
    }

    public void SeekForward()
    {
        StartSeek(10.0f);
    }

    public void SeekBack()
    {
        StartSeek(-10.0f);
    }

    private void StartSeek(float seekAmount)
    {
        isVideoReady = false;
        videoPlayer.time += seekAmount;
    }
    public int GetIndex()
    {
        return index;
    }

    public void NextVideo()
    {
        index++;
        
        if (index == videos.Count)
            index = 0;

        StartPrepare(index);
    }

    public void SearchVideoList(int videoPosition)
    {
        StartPrepare(videoPosition);
    }

    public void PreviousVideo()
    {
        index--;

        if (index == -1)
            index = videos.Count - 1;

        StartPrepare(index);
    }
    private void StartPrepare(int clipIndex)
    {
        IsVideoReady = false;
        videoPlayer.clip = videos[clipIndex];
        videoPlayer.Prepare();
    }

    private void OnComplete(VideoPlayer videoPlayer)
    {
        IsVideoReady = true;
        videoPlayer.Play();
    }

    private void OnLoop(VideoPlayer videoPlayer)
    {
        Debug.Log("isOVER: " + isOver.ToString());
        isOver = true;
        NextVideo();
        Debug.Log("isOVER: " + isOver.ToString());
    }

    public bool IsPlaying()
    {
        if (videoPlayer.isPlaying)
            return true;
        else
            return false;
    }

    //VideoEvent is a new class that inherits from the UnityEvent
    //So we can giver our own custom event
    public class VideoEvent : UnityEvent<bool>
    {

    }

}
