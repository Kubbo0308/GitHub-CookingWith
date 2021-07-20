using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    //インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject ItemPanel_f; //家具の方のアイテムパネル
    public GameObject buttonComplete_f; //家具の方の完了ボタン
    [SerializeField] GameObject ItemPanel_a; //アクセの方のアイテムパネル
    public GameObject buttonComplete_a; //アクセの方の完了ボタン

    // publicで宣言し、inspectorで設定可能にする
    //この画像に変更する
    public Sprite Sprite_f1;
    public Sprite Sprite_f2;

    //どのボタンの画像か
    public Image image_f1;
    public Image image_f2;


    // Start is called before the first frame update
    void Start()
    {
        ItemPanel_f.SetActive(false);
        buttonComplete_f.SetActive(false);
        ItemPanel_a.SetActive(false);
        buttonComplete_a.SetActive(false);

        //「SCORE」というキーで保存されているInt値を読み込み
        int score = PlayerPrefs.GetInt("SCORE");
        Debug.Log(" 料理日記を書いた回数は" + score);

        if (score >= 1)
        {
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f1.sprite = Sprite_f1;
        }
        if (score >= 5)
        {
            image_f2.sprite = Sprite_f2;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Buttonが押されたときの処理
    //ItemPanelをアクティブにする
    //家具パネルの方
    public void AccessItem_f()
    {
        ItemPanel_f.SetActive(true);
    }
    public void back_f()
    {
        ItemPanel_f.SetActive(false);
    }
    public void directItem_f()
    {
        buttonComplete_f.SetActive(true);
        ItemPanel_f.SetActive(false);
    }
    public void back2_f()
    {
        buttonComplete_f.SetActive(false);
    }

    //Buttonが押されたときの処理
    //ItemPanelをアクティブにする
    //アクセパネルの方
    public void AccessItem_a()
    {
        ItemPanel_a.SetActive(true);
    }
    public void back_a()
    {
        ItemPanel_a.SetActive(false);
    }
    public void directItem_a()
    {
        buttonComplete_a.SetActive(true);
        ItemPanel_a.SetActive(false);
    }
    public void back2_a()
    {
        buttonComplete_a.SetActive(false);
    }

}
