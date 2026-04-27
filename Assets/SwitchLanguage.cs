using UnityEngine;
using UnityEngine.Video;

public class LanguageButtons : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public VideoClip arabicVideo;
    public VideoClip englishVideo;

    public void PlayArabic()
    {
        videoPlayer.clip = arabicVideo;
        videoPlayer.Play();
    }

    public void PlayEnglish()
    {
        videoPlayer.clip = englishVideo;
        videoPlayer.Play();
    }
}