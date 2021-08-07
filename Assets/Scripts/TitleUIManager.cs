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

    //そのペットを育てたことがあるか判定するための変数
    int Point0, Point1, Point2, Point3, Point4, Point5;
    int Point6, Point7, Point8, Point9, Point10, Point11;
    int Point12, Point13, Point14, Point15, Point16, Point17;
    int Point18, Point19, Point20, Point21, Point22, Point23;

    // Start is called before the first frame update
    void Start()
    {
        /*
        int POINT0 = PlayerPrefs.GetInt("POINT0");
        int POINT1 = PlayerPrefs.GetInt("POINT1");
        int POINT2 = PlayerPrefs.GetInt("POINT2");
        int POINT3 = PlayerPrefs.GetInt("POINT3");
        int POINT4 = PlayerPrefs.GetInt("POINT4");
        int POINT5 = PlayerPrefs.GetInt("POINT5");
        int POINT6 = PlayerPrefs.GetInt("POINT6");
        int POINT7 = PlayerPrefs.GetInt("POINT7");
        int POINT8 = PlayerPrefs.GetInt("POINT8");
        int POINT9 = PlayerPrefs.GetInt("POINT9");
        int POINT10 = PlayerPrefs.GetInt("POINT10");
        int POINT11 = PlayerPrefs.GetInt("POINT11");
        int POINT12 = PlayerPrefs.GetInt("POINT12");
        int POINT13 = PlayerPrefs.GetInt("POINT13");
        int POINT14 = PlayerPrefs.GetInt("POINT14");
        int POINT15 = PlayerPrefs.GetInt("POINT15");
        int POINT16 = PlayerPrefs.GetInt("POINT16");
        int POINT17 = PlayerPrefs.GetInt("POINT17");
        int POINT18 = PlayerPrefs.GetInt("POINT18");
        int POINT19 = PlayerPrefs.GetInt("POINT19");
        int POINT20 = PlayerPrefs.GetInt("POINT20");
        int POINT21 = PlayerPrefs.GetInt("POINT21");
        int POINT22 = PlayerPrefs.GetInt("POINT22");
        int POINT23 = PlayerPrefs.GetInt("POINT23");

        Point0 = 0;
        PlayerPrefs.SetInt("POINT0", Point0);
        PlayerPrefs.Save();
        Point1 = 0;
        PlayerPrefs.SetInt("POINT1", Point1);
        PlayerPrefs.Save();
        Point2 = 0;
        PlayerPrefs.SetInt("POINT2", Point2);
        PlayerPrefs.Save();
        Point3 = 0;
        PlayerPrefs.SetInt("POINT3", Point3);
        PlayerPrefs.Save();
        Point4 = 0;
        PlayerPrefs.SetInt("POINT4", Point4);
        PlayerPrefs.Save();
        Point5 = 0;
        PlayerPrefs.SetInt("POINT5", Point5);
        PlayerPrefs.Save();
        Point6 = 0;
        PlayerPrefs.SetInt("POINT6", Point6);
        PlayerPrefs.Save();
        Point7 = 0;
        PlayerPrefs.SetInt("POINT7", Point7);
        PlayerPrefs.Save();
        Point8 = 0;
        PlayerPrefs.SetInt("POINT8", Point8);
        PlayerPrefs.Save();
        Point9 = 0;
        PlayerPrefs.SetInt("POINT9", Point9);
        PlayerPrefs.Save();
        Point10 = 0;
        PlayerPrefs.SetInt("POINT10", Point10);
        PlayerPrefs.Save();
        Point11 = 0;
        PlayerPrefs.SetInt("POINT11", Point11);
        PlayerPrefs.Save();
        Point12 = 0;
        PlayerPrefs.SetInt("POINT12", Point12);
        PlayerPrefs.Save();
        Point13 = 0;
        PlayerPrefs.SetInt("POINT13", Point13);
        PlayerPrefs.Save();
        Point14 = 0;
        PlayerPrefs.SetInt("POINT14", Point14);
        PlayerPrefs.Save();
        Point15 = 0;
        PlayerPrefs.SetInt("POINT15", Point15);
        PlayerPrefs.Save();
        Point16 = 0;
        PlayerPrefs.SetInt("POINT16", Point16);
        PlayerPrefs.Save();
        Point17 = 0;
        PlayerPrefs.SetInt("POINT17", Point17);
        PlayerPrefs.Save();
        Point18 = 0;
        PlayerPrefs.SetInt("POINT18", Point18);
        PlayerPrefs.Save();
        Point19 = 0;
        PlayerPrefs.SetInt("POINT19", Point19);
        PlayerPrefs.Save();
        Point20 = 0;
        PlayerPrefs.SetInt("POINT20", Point20);
        PlayerPrefs.Save();
        Point21 = 0;
        PlayerPrefs.SetInt("POINT21", Point21);
        PlayerPrefs.Save();
        Point22 = 0;
        PlayerPrefs.SetInt("POINT22", Point22);
        PlayerPrefs.Save();
        Point23 = 0;
        PlayerPrefs.SetInt("POINT23", Point23);
        PlayerPrefs.Save();

        //「START」というキーで保存されているInt値を読み込み
        int StartPoint = PlayerPrefs.GetInt("START");
        StartPoint = 0; //ここを変えると(StartPoint = 1とか)テストできる
        PlayerPrefs.SetInt("START", StartPoint);
        PlayerPrefs.Save();

        //「DECISION」というキーで保存されているInt値を読み込み
        int decision = PlayerPrefs.GetInt("DECISION");
        decision = 0;
        PlayerPrefs.SetInt("DECISION", decision);
        PlayerPrefs.Save();

        int ItemPoint = PlayerPrefs.GetInt("SCORE");
        ItemPoint = 0;
        PlayerPrefs.SetInt("SCORE", ItemPoint);
        PlayerPrefs.Save();

        int PointPet = PlayerPrefs.GetInt("POINT");
        PointPet = 0;
        PlayerPrefs.SetInt("POINT", PointPet);
        PlayerPrefs.Save();

        int petPoint = PlayerPrefs.GetInt("WHAT_PET");
        petPoint = 0;
        PlayerPrefs.SetInt("WHAT_PET", petPoint);
        PlayerPrefs.Save();*/

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
