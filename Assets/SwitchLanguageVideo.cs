using UnityEngine;
using UnityEngine.Video;

public class SwitchLanguageVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public VideoClip arabicVideo;
    public VideoClip englishVideo;

    private bool isArabic = true;

    public void SwitchLanguage()
    {
        if (isArabic)
        {
            videoPlayer.Stop();
            videoPlayer.clip = englishVideo;
            videoPlayer.Play();
            isArabic = false;
        }
        else
        {
            videoPlayer.Stop();
            videoPlayer.clip = arabicVideo;
            videoPlayer.Play();
            isArabic = true;
        }
    }
}