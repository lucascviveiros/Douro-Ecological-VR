using UnityEngine;
using System.IO;
using UnityEngine.Video;
using UnityEngine.UI;

public class StreamingVideo : MonoBehaviour
{
    public UnityEngine.Video.VideoPlayer videoPlayer;
    private string status;
    //public GameObject VRCam;
   // public Text _debugText;
    private string rootPath;
    private string path;
    private string fileName = "VideoPrincipal_2880x5760__h265_injected";

    void Start()
    {
        videoPlayer.errorReceived += VideoPlayer_errorReceived;

        if (Application.platform == RuntimePlatform.Android)
        {
            rootPath = Application.persistentDataPath;
            path = Path.Combine(rootPath, fileName);
        }

        videoPlayer.url = path;
        videoPlayer.Play();
    }
   
    private void VideoPlayer_errorReceived(VideoPlayer source, string message)
    {
        /// So that I can see the debug message in the headset in my case
       // _debugText.text += message;

        /// To avoid memory leaks, unsubscribe from the event
        /// otherwise it could continuously send this message
        videoPlayer.errorReceived -= VideoPlayer_errorReceived;
    }
}
    


