using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionWindow : MonoBehaviour
{
    static OptionWindow _uniqueInstance;
    [SerializeField] GameObject _bgmon;
    [SerializeField] GameObject _bgmoff;
    [SerializeField] GameObject _sfxon;
    [SerializeField] GameObject _sfxoff;


    public static OptionWindow _instance
    {
        get { return _uniqueInstance; }
    }


    private void Awake()
    {
        _uniqueInstance = this;
        _bgmoff.SetActive(false);
        _sfxoff.SetActive(false);


    }
    private void Update()
    {


    }



    public void ClickMuteBGMButton()
    {
        SoundManager._instance.SetBgmMute();
        _bgmon.SetActive(false);
        _bgmoff.SetActive(true);

    }

    public void ClickPlayBGMButton()
    {
        SoundManager._instance.SetBgmOn();
        _bgmoff.SetActive(false);
        _bgmon.SetActive(true);
    }

    public void ClickMuteSFXButton()
    {
        SoundManager._instance.SetSfxMute();
        _sfxon.SetActive(false);
        _sfxoff.SetActive(true);
    }

    public void ClickPlaySFXButton()
    {
        SoundManager._instance.SetSfxOn();
        _sfxoff.SetActive(false);
        _sfxon.SetActive(true);
    }


    public void ClickCloseButton()
    {
        //gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
