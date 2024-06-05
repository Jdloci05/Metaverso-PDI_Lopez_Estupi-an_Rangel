using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GetVideoInt : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private VideoClip video1;
    [SerializeField] private VideoClip video2;

    private void Start()
    {
        int selectedNumber = PlayerPrefs.GetInt("SelectedNumber", 1);
        PlayVideo(selectedNumber);
    }

    private void PlayVideo(int number)
    {
        switch (number)
        {
            case 1:
                videoPlayer.clip = video1;
                break;
            case 2:
                videoPlayer.clip = video2;
                break;
            default:
                return;
        }
        videoPlayer.Play();
    }
}
