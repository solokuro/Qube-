using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonclick : MonoBehaviour
{

    private Ray rayone,raytwo;
    private RaycastHit hitone,hittwo;//オブジェクトの情報取得変数
    private GameObject selectedObject, actioncomand;
    private float count = 0;
    public static string anwer;

    // Use this for initialization
    void Start()
    {
        controol.num = "";

    }

    // Update is called once per frame
    void Update()
    {
        if (goal.goalflag == false)
        {
            if (Input.GetMouseButtonDown(1) && count < 4)
            {
                SearchRoom();//右クリックを押したとき
            }
            if (Input.GetMouseButtonDown(1))//エンター押せるクリア押させる
            {
                Action();
            }

        }
    }



    void SearchRoom()
    {
        selectedObject = null;//selectedObjectを空にしておく
        rayone = Camera.main.ScreenPointToRay(Input.mousePosition);//メインカメラ上のマウスカーソルのある位置からRayを飛ばす
        if (Physics.Raycast(rayone, out hitone, Mathf.Infinity, 1 << 8))//ray：発射位置と方向  Mathf.Infinity距離は無限 
                                                                  //1 <<8: 左8ビットシフトしているこれによって8番目のレイヤーにあるオブジェクトにぶつかる
        {
            selectedObject = hitone.collider.gameObject;
            switch (selectedObject.name)
            {
                case "Number1"://オブジェクトの名前
                    Debug.Log("1おした");
                    controol.num += "1";
                    count++;
                    break;

                case "Number2":
                    Debug.Log("２押した");
                    controol.num += "2";
                    count++;
                    break;

                case "Number3":
                    Debug.Log("3押した");
                    controol.num += "3";
                    count++;
                    break;

                case "Number4":
                    Debug.Log("4押した");
                    controol.num += "4";
                    count++;
                    break;

                case "Number5":
                    Debug.Log("5押した");
                    controol.num += "5";
                    count++;
                    break;

                case "Number6":
                    Debug.Log("6押した");
                    controol.num += "6";
                    count++;
                    break;

                case "Number7":
                    Debug.Log("7押した");
                    controol.num += "7";
                    count++;
                    break;

                case "Number8":
                    Debug.Log("8押した");
                    controol.num += "8";
                    count++;
                    break;

                case "Number9":
                    Debug.Log("9押した");
                    controol.num += "9";
                    count++;
                    break;
               

            }
        }

    }
    void Action()
    {
        actioncomand = null;
        raytwo = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(raytwo, out hittwo, Mathf.Infinity, 1 << 9))
        {
            actioncomand = hittwo.collider.gameObject;
            switch (actioncomand.name)
            {
                case "Clear":if(count<4 || count == 4)
                    Debug.Log("クリア");
                    controol.num = "";
                    count = 0;
                    break;

                case "Enter":if(count == 4)
                    Debug.Log("決定");
                    anwer = controol.num;
                    count = 0;
                    break;
                //case "Back":if(count<4)
                //    Debug.Log("キャンセル");
                //    count--;
                //    break;
            }

        }
    }
   
}
