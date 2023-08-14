using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    public static Managers _uniqueinstance = null;
    public static Managers _instance
    {
        get { return _uniqueinstance; }
    }

    
    GameManagerR _game = new GameManagerR();
   
    public static GameManagerR Game 
    { 
        get { return _instance?._game; } 
    }
    public static void Init()
    {
        if(_uniqueinstance == null)
        {
            GameObject go = GameObject.Find("Managers");
           
            if (go == null)
                go = new GameObject { name = "Managers" };

        
               
            _uniqueinstance = Utils.GetOrAddComponent<Managers>(go);
            DontDestroyOnLoad(go);



            _uniqueinstance._game.Init();
            

        }
    }


}
