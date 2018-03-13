using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;

public class ButtonManager : MonoBehaviour {

    public List<GameObject> titleButtonList;
    
    public GameObject infoPanel;
    public TextMeshProUGUI infoText;

    public List<GameObject> externalButtonHolderList;

    [TextArea(3, 10)]
    public List<string> infoList;

    public VideoPlayer videoPlayer;
    public List<VideoClip> clipList;

    GameObject activeExternalHolder;

    public void MouseEnter(GameObject _titleButton)
    {
        int index = titleButtonList.IndexOf(_titleButton);
        videoPlayer.clip = clipList[index];
        infoText.text = infoList[index];

        if (activeExternalHolder != null)
            activeExternalHolder.SetActive(false);

        activeExternalHolder = externalButtonHolderList[index];
        activeExternalHolder.SetActive(true);

        infoPanel.SetActive(true);
        videoPlayer.Play();
        videoPlayer.gameObject.SetActive(true);
    }

    public void Close()
    {
        Application.Quit();
    }
}