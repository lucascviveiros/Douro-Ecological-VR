using UnityEngine;
using System.IO;
using UnityEngine.Video;
using UnityEngine.UI;

public class StreamingVideo : MonoBehaviour
{
    public UnityEngine.Video.VideoPlayer videoPlayer;
    private string status;
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
       // _debugText.text += message;
        videoPlayer.errorReceived -= VideoPlayer_errorReceived;
    }
}
    


