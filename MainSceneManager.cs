using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using static EnumManager;
using UnityEngine.SceneManagement;


public class MainSceneManager : UI_Scene
{
    [SerializeField] GameObject _shopWindow;
    [SerializeField] GameObject _sroll;
    public static bool _isStage = true;

    [SerializeField] GameObject[] _Room;
    [SerializeField] Text _levelBox;
    RoofPosScript _moveRoof;
    Transform _firstRoomShop;


    [SerializeField] SelectStage _startStage;


    [SerializeField] List<StageSlot> _stageList = new List<StageSlot>();

    EnumManager.eStageState _currentState;

    StageData _stageData;


    private void Start()
    {
        _shopWindow.SetActive(false);
       
        _moveRoof = FindObjectOfType<RoofPosScript>().GetComponent<RoofPosScript>();
        for (int i = 0; i < _Room.Length; i++)
        {
            _Room[i].SetActive(false);
        }

        for (int i = 0; i < _stageList.Count; i++)
        {
            _stageList[i].SetStageNum(i + 1);
        }

        LevelBox();
    }



    public void LevelBox()
    {
        _levelBox.text = Managers.Game.HighestStage.ToString();
        Managers.Game.SaveGame();
    }

    public void ClickStageButton()//스타트 버튼 - 스테이지가 바로 진행되게끔
    {

        //if(_isStage)
        //{
        //    GameObject go = Instantiate(ResourcePoolManager._instance.GetUIPrefabFromType(EnumManager.eUIWindowType.StageInfoSelectWnd));


        //}

        SceneManager.LoadScene("IngameScene");
        SoundManager._instance.PlayBGMSound(EnumManager.eBGMClipType.IngameScene);

    }
     
    public void ClickOptionButton()
    {
        GameObject go = Instantiate(ResourcePoolManager._instance.GetUIPrefabFromType(EnumManager.eUIWindowType.OptionWnd));
    }
    
    public void ClickShopButton()
    {
        _shopWindow.SetActive(true);
        _firstRoomShop = _sroll.GetComponent<Transform>();
        _firstRoomShop.transform.localPosition = new Vector3(4, 662,0);
    }

    public void ClickShopExitButton()
    {
        _shopWindow.SetActive(false);
        _firstRoomShop = _sroll.GetComponent<Transform>();
        _firstRoomShop.transform.localPosition = new Vector3(4, -58.45f, 0);
    }

    public void ClickGenerateRoom()
    {
        _Room[0].SetActive(true);
        _moveRoof.ClickPosUpButton();
    }
    public void ClickGenerateThirdRoom()
    {
        _Room[1].SetActive(true);
        _moveRoof.ClickPosUpButton();
    }

    public void ClickHighLevel()
    {
        Managers.Game.HighestStage += 1;
        Managers.Game.Coin += 100;
        Managers.Game.SaveGame();
    }


}
