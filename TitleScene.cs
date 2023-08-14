using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScene : BaseScene
{


    public void TapStart()
    {
        SoundManager._instance.PlaySFXSound(EnumManager.eSFXClipType.TaptoStart);
        SceneManager.LoadScene("MainScene");
       
    }



}
