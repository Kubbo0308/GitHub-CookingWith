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
        //AccessFurnitureメソッドを呼び出す
        AccessFurniture();
    }

    //AccessoryButtonが押されたときの処理
    //AccessoryPanelをアクティブにする
    public void SelectAccessoryDescription()
    {
        AccessoryPanel.SetActive(true);
        FurniturePanel.SetActive(false);
    }

    //FurnitureButtonが押されたときの処理
    //FurniturePanelをアクティブにする
    public void AccessFurniture()
    {
        AccessoryPanel.SetActive(false);
        FurniturePanel.SetActive(true);
    }

}

