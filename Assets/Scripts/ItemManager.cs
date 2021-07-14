using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    //インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject ItemPanel;
    public GameObject buttonComplete;

    // Start is called before the first frame update
    void Start()
    {
        ItemPanel.SetActive(false);
        buttonComplete.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Buttonが押されたときの処理
    //ItemPanelをアクティブにする
    public void AccessItem()
    {
        ItemPanel.SetActive(true);
    }
    public void back()
    {
        ItemPanel.SetActive(false);
    }
    public void directItem()
    {
        buttonComplete.SetActive(true);
        ItemPanel.SetActive(false);
    }
    public void back2()
    {
        buttonComplete.SetActive(false);
    }
}
