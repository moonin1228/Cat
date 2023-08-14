using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureBox : MonoBehaviour
{
    static TreasureBox _uniqueInstance;
    public int posx, posy;
    Animator _boxAni;
    bool _isOpen = false;

    private void Awake()
    {
        _boxAni = GetComponent<Animator>();
        _uniqueInstance = this;
    }
    public static TreasureBox _Instance
    {
        get { return _uniqueInstance; }
    }
    public void initBox(int x, int y)
    {
        posx = x;
        posy = y;
    }

    public void OpenBox()
    {
        _boxAni.SetBool("isOpen", true);
    }




}
