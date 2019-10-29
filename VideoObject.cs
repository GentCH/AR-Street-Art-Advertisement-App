//Code to allow user to play, pause, or stop video.

public class VideoObject : MonoBehaviour
{
    public UnityEngine.Video.VideoClip videoClip;
    public AudioSource MusicSource;

    private void Start()
    {
        var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
        var audioSource = gameObject.AddComponent<AudioSource>();
        videoPlayer.playOnAwake = false;
        videoPlayer.clip = videoClip;
    }

    public void PlayVideo()
    {
        var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        vp.Play();
    }

    public void PauseVideo()
    {
        var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        vp.Pause();
    }

    public void StopVideo()
    {
        var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        vp.Stop();
    }
}
