using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    static AudioSource bgmInstance;
    static AudioSource sfxInstance;
    static AudioSource hitInstance;
    static AudioSource gameoverInstance;

    [SerializeField] AudioSource bgm;
    [SerializeField] AudioSource sfx;
    [SerializeField] AudioSource hit;
    [SerializeField] AudioSource gameover;

    public bool IsMute { get => bgm.mute; }
    public float BgmVolume { get => bgm.volume; }
    public float SfxVolume { get => sfx.volume; }
    public float HitVolume { get => hit.volume; }
    public float GameOverVolume { get => gameover.volume; }

    void Start()
    {
        if (bgmInstance != null)
        {
            Destroy(bgm.gameObject);
            bgm = bgmInstance;
        }
        else
        {
            bgmInstance = bgm;
            bgm.transform.SetParent(null);
            DontDestroyOnLoad(bgm.gameObject);
        }

        if (sfxInstance != null)
        {
            Destroy(sfx.gameObject);
            sfx = sfxInstance;
        }
        else
        {
            sfxInstance = sfx;
            sfx.transform.SetParent(null);
            DontDestroyOnLoad(sfx.gameObject);
        }

        if (hitInstance != null)
        {
            Destroy(hit.gameObject);
            hit = hitInstance;
        }
        else
        {
            hitInstance = hit;
            hit.transform.SetParent(null);
            DontDestroyOnLoad(hit.gameObject);
        }

        if (gameoverInstance != null)
        {
            Destroy(gameover.gameObject);
            gameover = gameoverInstance;
        }
        else
        {
            gameoverInstance = gameover;
            gameover.transform.SetParent(null);
            DontDestroyOnLoad(gameover.gameObject);
        }
    }

    public void PlayBGM(AudioClip clip, bool loop = true)
    {
        if (bgm.isPlaying == true)
            bgm.clip = clip;

        bgm.loop = loop;
        bgm.Play();
    }

    public void PlaySfx(AudioClip clip)
    {
        if (sfx.isPlaying == true)
            sfx.Stop();

        sfx.clip = clip;
        sfx.Play();
    }

    public void PlayHit(AudioClip clip)
    {
        if (hit.isPlaying == true)
            hit.Stop();

        hit.clip = clip;
        hit.Play();
    }

    public void PlayGameOver(AudioClip clip)
    {
        if (gameover.isPlaying == true)
            gameover.Stop();

        gameover.clip = clip;
        gameover.Play();
    }

    public void SetMute(bool value)
    {
        bgm.mute = value;
        sfx.mute = value;
        hit.mute = value;
        gameover.mute = value;
    }

    public void SetVolumeBGM(float v)
    {
        bgm.volume = v;
    }

    public void SetVolumeSFX(float v)
    {
        sfx.volume = v;
    }

    public void SetVolumeHit(float v)
    {
        hit.volume = v;
    }

    public void SetVolumeGameOver(float v)
    {
        gameover.volume = v;
    }
}
