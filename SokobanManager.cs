using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class SokobanManager : MonoBehaviour
{

    public GameObject _sokobanManager;
    public Skeleton _Player;
    public TreasureBox _Box;
    MapManager MAP;
    public float moveX, moveY;
    Animator ani;

    Button upButton, downButton, leftButton, rightButton;


    public virtual void Start()
    {
       
        _Player = GameObject.Find("Skeleton").GetComponent<Skeleton>();
        _Box = GameObject.Find("TreasureBox").GetComponent<TreasureBox>();
     
        _sokobanManager = this.gameObject;

        upButton = GameObject.Find("upButton").GetComponent<Button>();
        downButton = GameObject.Find("downButton").GetComponent<Button>();
        leftButton = GameObject.Find("leftButton").GetComponent<Button>();
        rightButton = GameObject.Find("rightButton").GetComponent<Button>();

    
    }

  
      

    




}
