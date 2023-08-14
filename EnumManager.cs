using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumManager : MonoBehaviour
{
    public enum eSceneIndex
    {
        none,
        TitleScene,
        IngameScene,
        HomeScene,
        Max
    }

    public enum eTileType
    {
      
        _Moveable,
        _Moveunable,
        None

    }

    public enum eTilePropType
    {
        None,
        Box,
        Goal,
        Wall
    }
    public enum eUIWindowType
    {

        StageInfoSelectWnd = 0,
        StageInfoWnd,
        ClearWnd,
        OptionWnd,
        LoadingWnd,
        ResultWnd,
        ShopWnd
      

    
    }

    public struct stStageInfo
    {
        public string _stageNum;
        public int _ghostCount;
        public int _heart;

        public stStageInfo(string _stage, int ghost, int heart)
        {
            _stageNum = _stage;
            _ghostCount = ghost;
            _heart = heart;
        }
    }

    public enum eStageState
    {
        Locked   = 0,
        Free,
        Selected
    }

    public enum eBGMClipType
    {
        TitleScene = 0,
        MainHomeScene,
        IngameScene,
        Max
    }
    public enum eSFXClipType
    {
        TaptoStart = 0,
        Move,
        Clear,
        Max
       

    }
    public enum eMuteType
    {
        None,
        Mute
    }

    public enum eStage1List
    {
        None,
        f1_����,
        f1_����,
        ����,
        �ٴ�,
        �漮,
        ����,
        ����ε�,
        ��������,
        ����,
        ����,
        �ð�,
        ����ȭ��,
        â��,
        ��,
        å��,
        å��,
        å�峻��,
        ö������,
        ������,
        ȭ��Ʈ����,
        Max


    }
}


