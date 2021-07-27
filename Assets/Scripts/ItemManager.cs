using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    //インスペクターウィンドウからゲームオブジェクトを設定する
    //家具の方のアイテムパネル
    [SerializeField] GameObject ItemPanel_f1,ItemPanel_f2,ItemPanel_f3,ItemPanel_f4;
    [SerializeField] GameObject ItemPanel_f5,ItemPanel_f6,ItemPanel_f7,ItemPanel_f8;
    [SerializeField] GameObject ItemPanel_f9,ItemPanel_f10,ItemPanel_f11,ItemPanel_f12;
    [SerializeField] GameObject ItemPanel_f13,ItemPanel_f14,ItemPanel_f15,ItemPanel_f16;
    [SerializeField] GameObject ItemPanel_f17,ItemPanel_f18,ItemPanel_f19,ItemPanel_f20;
    [SerializeField] GameObject ItemPanel_f21,ItemPanel_f22,ItemPanel_f23,ItemPanel_f24;

    public GameObject buttonComplete_f; //家具の方の完了ボタン
    [SerializeField] GameObject ItemPanel_a; //アクセの方のアイテムパネル
    public GameObject buttonComplete_a; //アクセの方の完了ボタン

    public GameObject bkbutton_f; //アクセの方の戻るボタン
    public GameObject drbutton_f; //アクセの方の配置ボタン
    public GameObject bkbutton_a; //アクセの方の戻るボタン
    public GameObject drbutton_a; //アクセの方の配置ボタン

    // publicで宣言し、inspectorで設定可能にする
    //この画像に変更する
    public Sprite Sprite_f1, Sprite_f2, Sprite_f3, Sprite_f4, Sprite_f5;
    public Sprite Sprite_f6, Sprite_f7, Sprite_f8, Sprite_f9, Sprite_f10;
    public Sprite Sprite_f11, Sprite_f12, Sprite_f13, Sprite_f14, Sprite_f15;
    public Sprite Sprite_f16,Sprite_f17,Sprite_f18, Sprite_f19, Sprite_f20;
    public Sprite Sprite_f21, Sprite_f22, Sprite_f23, Sprite_f24;

    public Sprite Sprite_a1, Sprite_a2, Sprite_a3, Sprite_a4, Sprite_a5;
    public Sprite Sprite_a6, Sprite_a7, Sprite_a8, Sprite_a9, Sprite_a10;
    public Sprite Sprite_a11, Sprite_a12, Sprite_a13, Sprite_a14, Sprite_a15;
    public Sprite Sprite_a16, Sprite_a17, Sprite_a18, Sprite_a19, Sprite_20;
    public Sprite Sprite_a21, Sprite_a22, Sprite_a23, Sprite_a24, Sprite_a25;
    public Sprite Sprite_a26, Sprite_a27, Sprite_a28, Sprite_a29, Sprite_a30;
    public Sprite Sprite_a31, Sprite_a32, Sprite_a33, Sprite_a34, Sprite_a35, Sprite_a36;

    //どのボタンの画像か
    public Image image_f1, image_f2, image_f3, image_f4, image_f5;
    public Image image_f6, image_f7, image_f8, image_f9, image_f10;
    public Image image_f11, image_f12, image_f13, image_f14, image_f15;
    public Image image_f16, image_f17, image_f18, image_f19, image_f20;
    public Image image_f21, image_f22, image_f23, image_f24;

    public Image image_a1, image_a2, image_a3, image_a4, image_a5;
    public Image image_a6, image_a7, image_a8, image_a9, image_a10;
    public Image image_a11, image_a12, image_a13, image_a14, image_a15;
    public Image image_a16, image_a17, image_a18, image_a19, image_a20;
    public Image image_a21, image_a22, image_a23, image_a24, image_a25;
    public Image image_a26, image_a27, image_a28, image_a29, image_a30;
    public Image image_a31, image_a32, image_a33, image_a34, image_a35, image_a36;


    // Start is called before the first frame update
    void Start()
    {
        ItemPanel_f1.SetActive(false);
        ItemPanel_f2.SetActive(false);
        ItemPanel_f3.SetActive(false);
        ItemPanel_f4.SetActive(false);
        ItemPanel_f5.SetActive(false);
        ItemPanel_f6.SetActive(false);
        ItemPanel_f7.SetActive(false);
        ItemPanel_f8.SetActive(false);
        ItemPanel_f9.SetActive(false);
        ItemPanel_f10.SetActive(false);
        ItemPanel_f11.SetActive(false);
        ItemPanel_f12.SetActive(false);
        ItemPanel_f13.SetActive(false);
        ItemPanel_f14.SetActive(false);
        ItemPanel_f15.SetActive(false);
        ItemPanel_f16.SetActive(false);
        ItemPanel_f17.SetActive(false);
        ItemPanel_f18.SetActive(false);
        ItemPanel_f19.SetActive(false);
        ItemPanel_f20.SetActive(false);
        ItemPanel_f21.SetActive(false);
        ItemPanel_f22.SetActive(false);
        ItemPanel_f23.SetActive(false);
        ItemPanel_f24.SetActive(false);

        buttonComplete_f.SetActive(false);
        ItemPanel_a.SetActive(false);
        buttonComplete_a.SetActive(false);

        //「SCORE」というキーで保存されているInt値を読み込み
        int score = PlayerPrefs.GetInt("SCORE");
        Debug.Log(" 料理日記を書いた回数は" + score);

        //score(料理日記を書いた回数)が○回以上でアイテム解放
        if (score >= 1)
        {
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f1.sprite = Sprite_f1;
        }
        if (score >= 3)
        {
            image_f2.sprite = Sprite_f2;
        }
        if (score >= 5)
        {
            image_f3.sprite = Sprite_f3;
            image_a1.sprite = Sprite_a1;
        }
        if (score >= 7)
        {
            image_f4.sprite = Sprite_f4;
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
        ItemPanel_f1.SetActive(true);
        bkbutton_f.SetActive(true);
        drbutton_f.SetActive(true);

    }
    public void back_f()
    {
        ItemPanel_f1.SetActive(false);
    }
    public void directItem_f()
    {
        buttonComplete_f.SetActive(true);
        ItemPanel_f1.SetActive(false);
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
        bkbutton_a.SetActive(true);
        drbutton_a.SetActive(true);
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
