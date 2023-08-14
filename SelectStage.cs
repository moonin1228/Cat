using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectStage : MonoBehaviour
{
    [SerializeField] GameObject _selectBG;
    [SerializeField] RectTransform _closePos;


    [SerializeField] StageInfoWindow _infoWnd;

    [SerializeField] List<StageSlot> _stageList = new List<StageSlot>();


    void Start()
    {
        for(int i = 0; i < _stageList.Count; i++)
        {
            _stageList[i].SetStageNum(i + 1);
        }
    }

    public void ClickCloseButton()
    {
        MainSceneManager._isStage = true; //static ������ ���������δ� ���� ���� ��
        iTween.MoveTo(_selectBG, iTween.Hash("position", _closePos.position, "time", 0.5f));

    }

    public void ShowStageInfo(int no)
    {
        EnumManager.stStageInfo info = ResourcePoolManager._instance.GetStageInfo(no);
        UserInfoManager._Instance._nowStageNumber = no;

 

            


    }
}
