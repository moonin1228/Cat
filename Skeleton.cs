using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour
{

    public float posx, posy;
    public int moveX, moveY;
    public GameObject[] collideBlock = new GameObject[4];

    GameObject gameManager;


   // public Vector3 targetPosition;


    private void Update()
    {
        this.gameObject.transform.localPosition = new Vector2(posx, -posy * 0.8f);// Vector3.Lerp(this.gameObject.transform.position, targetPosition, 0.5f);
        
    }

    public void moveWay()
    {

        //this.gameObject.transform.position = new Vector3(posx /2, posy/2, 0);
    }

    //public void resetPosition()
    //{
    //    this.gameObject.transform.position = targetPosition;
    // //   posx = (int)targetPosition.x; posy = (int)targetPosition.y;

     
    //}

    bool isCantMoveTile()
    {
       
        Debug.Log("current pos : " + posx + ", " + posy);
        
       
        // Ÿ���� ���ʿ� ���� ���
        //if (posy == eTile.posy - 1 && posx == eTile.posx)
        //{
        //    targetPosition = this.gameObject.transform.position;
        //    return true;
        //}
        //// Ÿ���� �Ʒ��ʿ� ���� ���
        //else if (posy == eTile.posy + 1 && posx == eTile.posx)
        //{
        //    targetPosition = this.gameObject.transform.position;
        //    return true;
        //}
        //// Ÿ���� �����ʿ� ���� ���
        //else if (posx == eTile.posx - 1 && posy == eTile.posy) 
        //{
        //    targetPosition = this.gameObject.transform.position;
        //    return true;
        //}
        //// Ÿ���� ���ʿ� ���� ���
        //else if (posx == eTile.posx + 1 && posy == eTile.posy) 
        //{
        //    targetPosition = this.gameObject.transform.position;
        //    return true;
        //}
        return true;
    }
















}
