using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class stage1Price
{
    public int ���� = 21;
    public int ���� = 12;
    public int �ٴ� = 15;
    public int �漮 = 14;
    public int ���� = 15;
    public int ����ε� = 16;
    public int �������� = 12;
    public int ���� = 15;
    public int �ð� = 14;
    public int ������ = 23;
    public int â�� = 20;
    public int ����å = 12;
    public int å�� = 24;
    public int å�� = 28;
    public int å����� = 10;
    public int ö������ = 22;
    public int ������ = 13;
    public int ȭ��Ʈ���� = 17;
    public int ���� = 26;
    public int ����ȭ�� = 23;
}
public class ShopManager : MonoBehaviour
{
    [SerializeField] GameObject[] _stage1;
    [SerializeField] GameObject[] _soldout;
    [SerializeField] GameObject[] _1unavailable;
    [SerializeField] GameObject[] _dontbuy;
    public bool[] _stage1State;

    stage1Price _stage1P = new stage1Price();

    [SerializeField] Animator[] _funiAni;
    Animator _ani;
    Animator _Buyani;

    [SerializeField] GameObject _buySaying;

    [SerializeField] GameObject _helloSaying;

    [SerializeField] GameObject _dontbuySaying;

    private void Start()
    {
        for(int i = 0; i < _stage1.Length; i++)
        {
           
            _stage1[i].SetActive(false);
        }

        for (int i = 0; i < _stage1State.Length; i++)
        {

            _stage1State[i] = false;
        }

        for(int i = 0; i < _soldout.Length; i++)
        {
            _soldout[i].SetActive(false);
        }


 
        for (int i = 0; i < Managers.Game.SaveData.furniture.Count; i++)
        {


            int funitureNum = Managers.Game.SaveData.furniture[i];
            Destroy(_funiAni[funitureNum]);
            RealTrueF(funitureNum);
            MakeSoldOutFuniture(funitureNum);

            #region ���� ���� 
            if (funitureNum == 7)
            {
                _1unavailable[3].SetActive(false);
                _1unavailable[2].SetActive(false);
            }
            if(funitureNum == 10)
            {
                _1unavailable[1].SetActive(false);
            }
            if (funitureNum == 13)
            {
                _1unavailable[4].SetActive(false);
            }
            if (funitureNum == 12)
            {
                _1unavailable[0].SetActive(false);
            }
            #endregion


        }





    }

    void checkBool()
    {

    }
    #region stage1


    public void BuyRugButton()
    {
        int fn = 0;
      
        if (_stage1State[fn] == false)
        {
            //_funiAni[fn].SetBool("moving", true);
            if (Managers.Game.Coin >= _stage1P.����)
            {

                Managers.Game.SpendCoin(_stage1P.����);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
                SayThankyou();


            }
        }

    }

    public void BuyNameButton()
    {
        int fn = 1;
     
        if (_stage1State[fn] == false)
        {

            if (Managers.Game.Coin >= _stage1P.����)
            {
                Managers.Game.SpendCoin(_stage1P.����);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
            }
        }

        
 

    }
    public void BuyFloorButton()
    {
        int fn = 2;
        if (_stage1State[fn] == false)
        {
            if (Managers.Game.Coin >= _stage1P.�ٴ�)
            {
                Managers.Game.SpendCoin(_stage1P.�ٴ�);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
            }
        }

    }
    public void BuyCushionButton()
    {
        int fn = 3;
        if (_stage1State[fn] == false)
        {
            if (Managers.Game.Coin >= _stage1P.�漮)
            {
                Managers.Game.SpendCoin(_stage1P.�漮);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
            }
        }

    }
    public void BuyWallPaperButton()
    {
        int fn = 4;
        if (_stage1State[fn] == false)
        {

            if (Managers.Game.Coin >= _stage1P.����)
            {
                Managers.Game.SpendCoin(_stage1P.����);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
            }
        }
    }
    public void BuyBlindButton()
    {
        int fn = 5;
        if (_stage1State[fn] == false)
        {
            if (Managers.Game.Coin >= _stage1P.����ε�)
            {
                Managers.Game.SpendCoin(_stage1P.����ε�);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
            }
        }

    }
    public void BuyPapersButton()
    {
        int fn = 6;
        if (_stage1State[fn] == false)
        {

            if (Managers.Game.Coin >= _stage1P.��������)
            {
                Managers.Game.SpendCoin(_stage1P.��������);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
            }
        }
        else
        {
            
        }

    }
    public void BuyShelfButton()
    {
        int fn = 7;
        if (_stage1State[fn] == false)
        {

            if (Managers.Game.Coin >= _stage1P.����)
            {
                Managers.Game.SpendCoin(_stage1P.����);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
                _1unavailable[3].SetActive(false);
                _1unavailable[2].SetActive(false);
            }
        }

    }
    public void BuyClockButton()
    {
        int fn = 8;
        if (_stage1State[fn] == false)
        {

            if (Managers.Game.Coin >= _stage1P.�ð�)
            {
                Managers.Game.SpendCoin(_stage1P.�ð�);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
            }
        }
    }
    public void BuyPurifierButton()
    {
        int fn = 9;
        if (_stage1State[fn] == false)
        {

            if (Managers.Game.Coin >= _stage1P.������)
            {
                Managers.Game.SpendCoin(_stage1P.������);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
            }
        }

    }
    public void BuyWindowButton()
    {
        int fn = 10;
        if (_stage1State[fn] == false)
        {

            if (Managers.Game.Coin >= _stage1P.â��)
            {
                Managers.Game.SpendCoin(_stage1P.â��);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
                _1unavailable[1].SetActive(false);
            }
        }

    }
    public void BuyBooksButton()
    {
        int fn = 11;
        if (_stage1State[fn] == false)
        {
            if (Managers.Game.Coin >= _stage1P.����å)
            {
                Managers.Game.SpendCoin(_stage1P.����å);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
              
            }
        }

    }
    public void BuyDeskButton()
    {
        int fn = 12;
        if (_stage1State[fn] == false)
        {

            if (Managers.Game.Coin >= _stage1P.å��)
            {
                Managers.Game.SpendCoin(_stage1P.å��);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
                _1unavailable[0].SetActive(false);

            }
        }


    }
    public void BuyBookShelfButton()
    {
        int fn = 13;
        if (_stage1State[fn] == false)
        {

            if (Managers.Game.Coin >= _stage1P.å��)
            {
                Managers.Game.SpendCoin(_stage1P.å��);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
                _1unavailable[4].SetActive(false);
            }
        }

    }
    public void BuyInsideBookShelfButton()
    {
        int fn = 14;
        if (_stage1State[fn] == false)
        {

            if (Managers.Game.Coin >= _stage1P.å�����)
            {
                Managers.Game.SpendCoin(_stage1P.å�����);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
            }
        }

    }
    public void BuyIronShelfButton()
    {
        int fn = 15;
        if (_stage1State[fn] == false)
        {

            if (Managers.Game.Coin >= _stage1P.ö������)
            {
                Managers.Game.SpendCoin(_stage1P.ö������);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
            }
        }

    }
    public void BuyPorsterButton()
    {
        int fn = 16;
        if (_stage1State[fn] == false)
        {
           if(Managers.Game.Coin >= _stage1P.������)
           {
                Managers.Game.SpendCoin(_stage1P.������);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
           }
           else
           {
                CantBuy();
           }
      



        }
        else
        {
            CantBuy();
        }

    }
    public void BuyWhiteBoradButton()
    {
        int fn = 17;
        if (_stage1State[fn] == false)
        {

            if (Managers.Game.Coin >= _stage1P.ȭ��Ʈ����)
            {
                Managers.Game.SpendCoin(_stage1P.ȭ��Ʈ����);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
            }

        }

    }

    public void BuySofaButton()
    {
        int fn = 18;
        if (_stage1State[fn] == false)
        {

            if (Managers.Game.Coin >= _stage1P.����)
            {
                Managers.Game.SpendCoin(_stage1P.����);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
            }
        }

    }

    public void BuyPlantButton()
    {
        int fn = 19;
        if (_stage1State[fn] == false)
        {

            if (Managers.Game.Coin >= _stage1P.����ȭ��)
            {
                Managers.Game.SpendCoin(_stage1P.����ȭ��);
                Managers.Game.SaveGame();
                MakeTrueFuniture(fn);
                MakeSoldOutFuniture(fn);
            }
        }
    }

    public void MakeTrueFuniture(int i)
    {
        _stage1[i].SetActive(true);
        Managers.Game.SaveData.AddFuniture(i);
        Managers.Game.SaveGame();
    }

    public void MakeSoldOutFuniture(int i)
    {
        _soldout[i].SetActive(true);
        Managers.Game.SaveGame();
    }


    public void RealTrueF(int i)
    {

        _stage1[i].SetActive(true);

    }

    public void SayThankyou()
    {
        _helloSaying.SetActive(false);
        _buySaying.SetActive(true);
        _ani = _buySaying.GetComponent<Animator>();
        _ani.Play("New Animation");
        _helloSaying.SetActive(true);

    }

    public void CantBuy()
    {
        
        
        _dontbuySaying.SetActive(true);
        _Buyani = _dontbuySaying.GetComponent<Animator>();
        _Buyani.Play("dontBuy");
        _dontbuySaying.SetActive(false);
    }

    #endregion
}
