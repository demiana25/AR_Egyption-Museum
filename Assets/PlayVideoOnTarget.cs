using UnityEngine;
using UnityEngine.Video;

public class PlayVideoOnTarget : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void OnEnable()
    {
        videoPlayer.Play();
    }

    void OnDisable()
    {
        videoPlayer.Stop();
    }
}