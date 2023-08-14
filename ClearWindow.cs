using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearWindow : MonoBehaviour
{
    MapManager _map;
   public void ClickGoToMain()
   {
        Managers.Game.CheckHighestStage();
        Managers.Game.SaveGame();
        SceneManager.LoadScene("MainScene");
   }

    public void ClickReStage()
    {

        SceneManager.LoadScene("IngameScene");
    }

    public void ClickNext()
    {
        Managers.Game.CheckHighestStage();
        Managers.Game.SaveGame();
        SceneManager.LoadScene("IngameScene");
    }
}
