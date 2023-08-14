using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    static SoundManager _uniqueInstance;

    AudioSource _bgmPlayer;
    //2번
    AudioSource _sfxPlayer;
    float _bgmVolume;
    float _sfxVolume;
    bool _bgmMute;
    bool _sfxMute;

    public bool _isMuteBGM
    {
        get { return _bgmMute; }
    }
    public bool _isMuteSFX
    {
        get { return _sfxMute; }
    }
    //1번
    List<AudioSource> _sfxPlayers = new List<AudioSource>();
    public static SoundManager _instance
    {
        get { return _uniqueInstance; }
    }

    private void Awake()
    {
        _uniqueInstance = this;
        DontDestroyOnLoad(gameObject);
        _bgmPlayer = GetComponent<AudioSource>();
        //_sfxPlayer = transform.GetChild(0).GetComponent<AudioSource>();


        
        GameObject go = new GameObject("SfxPlayer");
        go.transform.parent = transform;
        _sfxPlayer = go.AddComponent<AudioSource>();



        //임시
        InitializeSet();
        //===
    }

    private void LateUpdate()
    {
        for (int n = 0; n < _sfxPlayers.Count; n++)
        {
            if (!_sfxPlayers[n].isPlaying)
            {
                Destroy(_sfxPlayers[n].gameObject);
                _sfxPlayers.RemoveAt(n);
                break;
            }
        }
    }

    public void InitializeSet(float bv = 1, bool bm = false, float fv = 1, bool fm = false)
    {
        _bgmVolume = bv;
        _bgmMute = bm;
        _sfxVolume = fv;
        _sfxMute = fm;
    }

    public void PlayBGMSound(EnumManager.eBGMClipType type, bool isLoop = true)
    {
        _bgmPlayer.clip = ResourcePoolManager._instance.GetBgmClipFromType(type);
        _bgmPlayer.volume = _bgmVolume;
        _bgmPlayer.mute = _bgmMute;
        _bgmPlayer.loop = isLoop;
        _bgmPlayer.Play();
    }

    public AudioSource PlaySFXSound(EnumManager.eSFXClipType type, bool isLoop = false)
    {
        {
            //audio.clip = ResoucePoolManager._instance.GetSFXClipFromType(type);
            //audio.volume = _fxVolume;
            //audio.mute = _fxsMute;
            //audio.loop = isLoop;
            //audio.Play();
        }

        //GameObject go = new GameObject("SfxPlayer");
        //go.transform.parent = transform;
        //AudioSource sfxPlayer = go.AddComponent<AudioSource>();
        _sfxPlayer.clip = ResourcePoolManager._instance.GetSFXClipFromType(type);
        _sfxPlayer.volume = _sfxVolume;
        _sfxPlayer.mute = _sfxMute;
        _sfxPlayer.loop = isLoop;
        _sfxPlayer.Play();

        //_sfxPlayers.Add(_sfxPlayer);
        return _sfxPlayer;
    }

    public void PlaySFXSoundOneShot(EnumManager.eSFXClipType type, bool isLoop = false)
    {
        _sfxPlayer.PlayOneShot(ResourcePoolManager._instance.GetSFXClipFromType(type));
        _sfxPlayer.volume = _sfxVolume;
        _sfxPlayer.mute = _sfxMute;
        _sfxPlayer.loop = isLoop;
     
    }

    public void SetBgmMute()
    {
        _bgmPlayer.mute = _bgmMute;
        _bgmMute = true;
    }

    public void SetBgmOn()
    {
        _bgmPlayer.mute = _bgmMute;
        _bgmMute = false;
    }

    public void SetSfxMute()
    {
        _sfxPlayer.mute = _sfxPlayer;
        _sfxMute = true;
    }

    public void SetSfxOn()
    {
        _sfxPlayer.mute = _sfxPlayer;
        _sfxMute = false;
    }
    public void SetBGMVolume(float volume)
    {
        _bgmPlayer.volume = volume;
        UserInfoManager._Instance.gameData.bgmVolume = volume;
        if (_bgmPlayer.volume <= 0)
        {
            _bgmMute = true;
        }
        else
        {
            _bgmMute = false;
        }
    }

    public void SetSFXVolume(float volume)
    {
        _sfxPlayer.volume = volume;
        UserInfoManager._Instance.gameData.sfxVolume = volume;
        if (volume <= 0)
        {
            _sfxMute = true;
        }
        else
        {
            _sfxMute = false;
        }
    }

  

}
