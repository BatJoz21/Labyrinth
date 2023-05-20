using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    [SerializeField] Audio audioManager;
    [SerializeField] Toggle muteToggle;
    [SerializeField] Slider bgmSlider;
    [SerializeField] Slider winSlider;
    [SerializeField] Slider hitSlider;
    [SerializeField] Slider gameoverSlider;
    [SerializeField] TMP_Text bgmVolText;
    [SerializeField] TMP_Text winVolText;
    [SerializeField] TMP_Text hitVolText;
    [SerializeField] TMP_Text gameoverVolText;

    void Start()
    {
        muteToggle.isOn = audioManager.IsMute;
        bgmSlider.value = audioManager.BgmVolume;
        winSlider.value = audioManager.SfxVolume;
        hitSlider.value = audioManager.HitVolume;
        gameoverSlider.value = audioManager.GameOverVolume;
        SetBgmVolText(bgmSlider.value);
        SetWinVolText(winSlider.value);
        SetHitVolText(hitSlider.value);
        SetGameOverVolText(gameoverSlider.value);
    }

    public void SetBgmVolText(float v)
    {
        bgmVolText.text = Mathf.RoundToInt(bgmSlider.value * 100).ToString();
    }

    public void SetWinVolText(float v)
    {
        winVolText.text = Mathf.RoundToInt(winSlider.value * 100).ToString();
    }

    public void SetHitVolText(float v)
    {
        hitVolText.text = Mathf.RoundToInt(hitSlider.value * 100).ToString();
    }

    public void SetGameOverVolText(float v)
    {
        gameoverVolText.text = Mathf.RoundToInt(gameoverSlider.value * 100).ToString();
    }
}
