using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleUIManager : MonoBehaviour
{
    //2つのPanelを格納する変数
    //インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject TitlePanel;
    [SerializeField] GameObject MenuPanel;
    public GameObject buttonStart;
    public GameObject buttonSettei;


    // Start is called before the first frame update
    void Start()
    {
        //BackToMenuメソッドを呼び出す
        BackToMenu();
    }

    //TitlePanelでButtonが押されたときの処理
    //MenuPanelをアクティブにする
    public void SelectMenuDescription()
    {
        TitlePanel.SetActive(false);
        MenuPanel.SetActive(true);
    }

    //MenuPanelでBackButtonが押されたときの処理
    //TitlePanelをアクティブにする
    public void BackToMenu()
    {
        TitlePanel.SetActive(true);
        MenuPanel.SetActive(false);
    }

    //スタートボタンを押したとき
    public void PushStart()
    {
        //「START」というキーで保存されているInt値を読み込み
        int StartPoint = PlayerPrefs.GetInt("START");
        //「DECISION」というキーで保存されているInt値を読み込み
        int decision = PlayerPrefs.GetInt("DECISION");

        //初めてスタートボタンを押した場合
        if (StartPoint == 0)
        {
            StartPoint++; //ここを変えると(StartPoint = 1とか)テストできる
            PlayerPrefs.SetInt("START", StartPoint);
            PlayerPrefs.Save();

            //最初はdecisionを0に設定しておく
            decision = 0;
            PlayerPrefs.SetInt("DECISION", decision);
            PlayerPrefs.Save();
        }
        if (decision != 0)
        {
            StartPoint++;
            PlayerPrefs.SetInt("START", StartPoint);
            PlayerPrefs.Save();
        }
    }

}
