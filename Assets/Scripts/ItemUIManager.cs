using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUIManager : MonoBehaviour
{
    //2つのPanelを格納する変数
    //インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject AccessoryPanel;
    [SerializeField] GameObject FurniturePanel;


    // Start is called before the first frame update
    void Start()
    {
        //BackToMenuメソッドを呼び出す
        AccessFurniture();
    }

    //TitlePanelでButtonが押されたときの処理
    //MenuPanelをアクティブにする
    public void SelectAccessoryDescription()
    {
        AccessoryPanel.SetActive(true);
        FurniturePanel.SetActive(false);
    }

    //MenuPanelでBackButtonが押されたときの処理
    //TitlePanelをアクティブにする
    public void AccessFurniture()
    {
        AccessoryPanel.SetActive(false);
        FurniturePanel.SetActive(true);
    }

}

