using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class VideoPlayerEndReachedEvent : MonoBehaviour
{
    public UnityEvent OnEndReached;
    public VideoPlayer videoPlayer;
    public bool endReach = false;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.loopPointReached += VideoPlayer_loopPointReached;
    }

    private void VideoPlayer_loopPointReached(VideoPlayer source)
    {

        OnEndReached.Invoke();
        print("end");
    }
}