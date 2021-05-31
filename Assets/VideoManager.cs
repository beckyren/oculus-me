using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class VideoManager : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    // Start is called before the first frame update
    public void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void Play()
    {
        
        videoPlayer.Play();
    }
    public void Pause()
    {
        videoPlayer.Pause();
    }

    public void Stop()
    {
        videoPlayer.Stop();
    }

    public void UrlToVideo(string URL)
    {
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = URL;
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
    }

    private void VideoPlayer_prepareCompleted(VideoPlayer source)
    {
        Play();
    }
}
