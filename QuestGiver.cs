using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    [SerializeField]
    private Quest[] quests;
    public Button _completeButton;
    int currentQuestNum = 0;

    [SerializeField] Image _image;
    [SerializeField] Sprite[] _image1;

    public GameObject _Newquest;
    [SerializeField] int checkNewQuest;
    private void Start()
    {
        _Newquest.SetActive(false);
     
        foreach (var quest in quests)
        {
            if (quest.IsAcceptable && !QuestSystem.Instance.ContainsInCompleteQuests(quest))
            {
                
                QuestSystem.Instance.Register(quest);
           
                _Newquest.SetActive(true);
              
                   
                    
             

                _image.sprite =_image1[0];
              
            }
          

        }



    }



    public void ClickNext()
    {
        QuestSystem.Instance.CompleteWaitingQuests();
       
    }
}




