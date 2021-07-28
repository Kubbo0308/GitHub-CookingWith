using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    //インスペクターウィンドウからゲームオブジェクトを設定する
    //家具の方のアイテムパネル
    [SerializeField] GameObject ItemPanel_f1, ItemPanel_f2, ItemPanel_f3, ItemPanel_f4;
    [SerializeField] GameObject ItemPanel_f5, ItemPanel_f6, ItemPanel_f7, ItemPanel_f8;
    [SerializeField] GameObject ItemPanel_f9, ItemPanel_f10, ItemPanel_f11, ItemPanel_f12;
    [SerializeField] GameObject ItemPanel_f13, ItemPanel_f14, ItemPanel_f15, ItemPanel_f16;
    [SerializeField] GameObject ItemPanel_f17, ItemPanel_f18, ItemPanel_f19, ItemPanel_f20;
    [SerializeField] GameObject ItemPanel_f21, ItemPanel_f22, ItemPanel_f23, ItemPanel_f24;

    public GameObject buttonComplete_f; //家具の方の完了ボタン

    //アクセの方のアイテムパネル
    [SerializeField] GameObject ItemPanel_a1, ItemPanel_a2, ItemPanel_a3, ItemPanel_a4;
    [SerializeField] GameObject ItemPanel_a5, ItemPanel_a6, ItemPanel_a7, ItemPanel_a8;
    [SerializeField] GameObject ItemPanel_a9, ItemPanel_a10, ItemPanel_a11, ItemPanel_a12;
    [SerializeField] GameObject ItemPanel_a13, ItemPanel_a14, ItemPanel_a15, ItemPanel_a16;
    [SerializeField] GameObject ItemPanel_a17, ItemPanel_a18, ItemPanel_a19, ItemPanel_a20;
    [SerializeField] GameObject ItemPanel_a21, ItemPanel_a22, ItemPanel_a23, ItemPanel_a24;
    [SerializeField] GameObject ItemPanel_a25, ItemPanel_a26, ItemPanel_a27, ItemPanel_a28;
    [SerializeField] GameObject ItemPanel_a29, ItemPanel_a30, ItemPanel_a31, ItemPanel_a32;
    [SerializeField] GameObject ItemPanel_a33, ItemPanel_a34, ItemPanel_a35, ItemPanel_a36;

    public GameObject buttonComplete_a; //アクセの方の完了ボタン

    //家具の方の戻るボタン
    public GameObject bkbutton_f1, bkbutton_f2, bkbutton_f3, bkbutton_f4;
    public GameObject bkbutton_f5, bkbutton_f6, bkbutton_f7, bkbutton_f8;
    public GameObject bkbutton_f9, bkbutton_f10, bkbutton_f11, bkbutton_f12;
    public GameObject bkbutton_f13, bkbutton_f14, bkbutton_f15, bkbutton_f16;
    public GameObject bkbutton_f17, bkbutton_f18, bkbutton_f19, bkbutton_f20;
    public GameObject bkbutton_f21, bkbutton_f22, bkbutton_f23, bkbutton_f24;

    //家具の方の配置ボタン
    public GameObject drbutton_f1, drbutton_f2, drbutton_f3, drbutton_f4;
    public GameObject drbutton_f5, drbutton_f6, drbutton_f7, drbutton_f8;
    public GameObject drbutton_f9, drbutton_f10, drbutton_f11, drbutton_f12;
    public GameObject drbutton_f13, drbutton_f14, drbutton_f15, drbutton_f16;
    public GameObject drbutton_f17, drbutton_f18, drbutton_f19, drbutton_f20;
    public GameObject drbutton_f21, drbutton_f22, drbutton_f23, drbutton_f24;

    //アクセの方の戻るボタン
    public GameObject bkbutton_a1, bkbutton_a2, bkbutton_a3, bkbutton_a4;
    public GameObject bkbutton_a5, bkbutton_a6, bkbutton_a7, bkbutton_a8;
    public GameObject bkbutton_a9, bkbutton_a10, bkbutton_a11, bkbutton_a12;
    public GameObject bkbutton_a13, bkbutton_a14, bkbutton_a15, bkbutton_a16;
    public GameObject bkbutton_a17, bkbutton_a18, bkbutton_a19, bkbutton_a20;
    public GameObject bkbutton_a21, bkbutton_a22, bkbutton_a23, bkbutton_a24;
    public GameObject bkbutton_a25, bkbutton_a26, bkbutton_a27, bkbutton_a28;
    public GameObject bkbutton_a29, bkbutton_a30, bkbutton_a31, bkbutton_a32;
    public GameObject bkbutton_a33, bkbutton_a34, bkbutton_a35, bkbutton_a36;

    //アクセの方の配置ボタン
    public GameObject drbutton_a1, drbutton_a2, drbutton_a3, drbutton_a4;
    public GameObject drbutton_a5, drbutton_a6, drbutton_a7, drbutton_a8;
    public GameObject drbutton_a9, drbutton_a10, drbutton_a11, drbutton_a12;
    public GameObject drbutton_a13, drbutton_a14, drbutton_a15, drbutton_a16;
    public GameObject drbutton_a17, drbutton_a18, drbutton_a19, drbutton_a20;
    public GameObject drbutton_a21, drbutton_a22, drbutton_a23, drbutton_a24;
    public GameObject drbutton_a25, drbutton_a26, drbutton_a27, drbutton_a28;
    public GameObject drbutton_a29, drbutton_a30, drbutton_a31, drbutton_a32;
    public GameObject drbutton_a33, drbutton_a34, drbutton_a35, drbutton_a36;

    // publicで宣言し、inspectorで設定可能にする
    //この画像に変更する
    public Sprite Sprite_f1, Sprite_f2, Sprite_f3, Sprite_f4, Sprite_f5;
    public Sprite Sprite_f6, Sprite_f7, Sprite_f8, Sprite_f9, Sprite_f10;
    public Sprite Sprite_f11, Sprite_f12, Sprite_f13, Sprite_f14, Sprite_f15;
    public Sprite Sprite_f16, Sprite_f17, Sprite_f18, Sprite_f19, Sprite_f20;
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

        ItemPanel_a1.SetActive(false);
        ItemPanel_a2.SetActive(false);
        ItemPanel_a3.SetActive(false);
        ItemPanel_a4.SetActive(false);
        ItemPanel_a5.SetActive(false);
        ItemPanel_a6.SetActive(false);
        ItemPanel_a7.SetActive(false);
        ItemPanel_a8.SetActive(false);
        ItemPanel_a9.SetActive(false);
        ItemPanel_a10.SetActive(false);
        ItemPanel_a11.SetActive(false);
        ItemPanel_a12.SetActive(false);
        ItemPanel_a13.SetActive(false);
        ItemPanel_a14.SetActive(false);
        ItemPanel_a15.SetActive(false);
        ItemPanel_a16.SetActive(false);
        ItemPanel_a17.SetActive(false);
        ItemPanel_a18.SetActive(false);
        ItemPanel_a19.SetActive(false);
        ItemPanel_a20.SetActive(false);
        ItemPanel_a21.SetActive(false);
        ItemPanel_a22.SetActive(false);
        ItemPanel_a23.SetActive(false);
        ItemPanel_a24.SetActive(false);
        ItemPanel_a25.SetActive(false);
        ItemPanel_a26.SetActive(false);
        ItemPanel_a27.SetActive(false);
        ItemPanel_a28.SetActive(false);
        ItemPanel_a29.SetActive(false);
        ItemPanel_a30.SetActive(false);
        ItemPanel_a31.SetActive(false);
        ItemPanel_a32.SetActive(false);
        ItemPanel_a33.SetActive(false);
        ItemPanel_a34.SetActive(false);
        ItemPanel_a35.SetActive(false);
        ItemPanel_a36.SetActive(false);

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
            image_a2.sprite = Sprite_a1;
        }
        if (score >= 10)
        {
            image_f5.sprite = Sprite_f2;
            image_a3.sprite = Sprite_a1;
        }
        if (score >= 12)
        {
            image_f6.sprite = Sprite_f3;
            image_a4.sprite = Sprite_a1;
        }
        if (score >= 15)
        {
            image_f7.sprite = Sprite_f4;
            image_a5.sprite = Sprite_a1;
        }
        if (score >= 17)
        {
            image_f8.sprite = Sprite_f2;
            image_a6.sprite = Sprite_a1;
        }
        if (score >= 20)
        {
            image_f9.sprite = Sprite_f3;
            image_a7.sprite = Sprite_a1;
        }
        if (score >= 22)
        {
            image_f10.sprite = Sprite_f4;
            image_a8.sprite = Sprite_a1;
        }
        if (score >= 25)
        {
            image_f11.sprite = Sprite_f2;
            image_a9.sprite = Sprite_a1;
        }
        if (score >= 27)
        {
            image_f12.sprite = Sprite_f3;
            image_a10.sprite = Sprite_a1;
        }
        if (score >= 30)
        {
            image_f13.sprite = Sprite_f4;
            image_a11.sprite = Sprite_a1;
        }
        if (score >= 32)
        {
            image_f14.sprite = Sprite_f2;
            image_a12.sprite = Sprite_a1;
        }
        if (score >= 35)
        {
            image_f15.sprite = Sprite_f3;
            image_a13.sprite = Sprite_a1;
        }
        if (score >= 37)
        {
            image_f16.sprite = Sprite_f4;
            image_a14.sprite = Sprite_a1;
        }
        if (score >= 40)
        {
            image_f17.sprite = Sprite_f2;
            image_a15.sprite = Sprite_a1;
        }
        if (score >= 42)
        {
            image_f18.sprite = Sprite_f3;
            image_a16.sprite = Sprite_a1;
        }
        if (score >= 45)
        {
            image_f19.sprite = Sprite_f4;
            image_a17.sprite = Sprite_a1;
        }
        if (score >= 47)
        {
            image_f20.sprite = Sprite_f2;
            image_a18.sprite = Sprite_a1;
        }
        if (score >= 50)
        {
            image_f21.sprite = Sprite_f3;
            image_a19.sprite = Sprite_a1;
        }
        if (score >= 52)
        {
            image_f22.sprite = Sprite_f4;
            image_a20.sprite = Sprite_a1;
        }
        if (score >= 55)
        {
            image_f23.sprite = Sprite_f3;
            image_a21.sprite = Sprite_a1;
        }
        if (score >= 57)
        {
            image_f24.sprite = Sprite_f4;
            image_a22.sprite = Sprite_a1;
        }
        if (score >= 60)
        {
            image_a23.sprite = Sprite_f2;
        }
        if (score >= 62)
        {
            image_a24.sprite = Sprite_a1;
        }
        if (score >= 65)
        {
            image_a25.sprite = Sprite_a1;
        }
        if (score >= 67)
        {
            image_a26.sprite = Sprite_f2;
        }
        if (score >= 70)
        {
            image_a27.sprite = Sprite_a1;
        }
        if (score >= 72)
        {
            image_a28.sprite = Sprite_a1;
        }
        if (score >= 75)
        {
            image_a29.sprite = Sprite_a1;
        }
        if (score >= 77)
        {
            image_a30.sprite = Sprite_a1;
        }
        if (score >= 80)
        {
            image_a31.sprite = Sprite_f2;
        }
        if (score >= 82)
        {
            image_a32.sprite = Sprite_a1;
        }
        if (score >= 85)
        {
            image_a33.sprite = Sprite_a1;
        }
        if (score >= 87)
        {
            image_a34.sprite = Sprite_f2;
        }
        if (score >= 90)
        {
            image_a35.sprite = Sprite_a1;
        }
        if (score >= 92)
        {
            image_a36.sprite = Sprite_a1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Buttonが押されたときの処理
    //ItemPanelをアクティブにする
    //家具パネルの方
    public void AccessItem_f(int number)
    {
        //「SCORE」というキーで保存されているInt値を読み込み
        int score = PlayerPrefs.GetInt("SCORE");

        switch (number)
        {
            case 0:
                if (score >= 1)
                {
                    ItemPanel_f1.SetActive(true);
                    bkbutton_f1.SetActive(true);
                    drbutton_f1.SetActive(true);
                }
                break;
            case 1:
                if (score >= 3)
                {
                    ItemPanel_f2.SetActive(true);
                    bkbutton_f2.SetActive(true);
                    drbutton_f2.SetActive(true);
                }
                break;
            case 2:
                if (score >= 5)
                {
                    ItemPanel_f3.SetActive(true);
                    bkbutton_f3.SetActive(true);
                    drbutton_f3.SetActive(true);
                }
                break;
            case 3:
                if (score >= 7)
                {
                    ItemPanel_f4.SetActive(true);
                    bkbutton_f4.SetActive(true);
                    drbutton_f4.SetActive(true);
                }
                break;
            case 4:
                if (score >= 10)
                {
                    ItemPanel_f5.SetActive(true);
                    bkbutton_f5.SetActive(true);
                    drbutton_f5.SetActive(true);
                }
                break;
            case 5:
                if (score >= 12)
                {
                    ItemPanel_f6.SetActive(true);
                    bkbutton_f6.SetActive(true);
                    drbutton_f6.SetActive(true);
                }
                break;
            case 6:
                if (score >= 15)
                {
                    ItemPanel_f7.SetActive(true);
                    bkbutton_f7.SetActive(true);
                    drbutton_f7.SetActive(true);
                }
                break;
            case 7:
                if (score >= 17)
                {
                    ItemPanel_f8.SetActive(true);
                    bkbutton_f8.SetActive(true);
                    drbutton_f8.SetActive(true);
                }
                break;
            case 8:
                if (score >= 20)
                {
                    ItemPanel_f9.SetActive(true);
                    bkbutton_f9.SetActive(true);
                    drbutton_f9.SetActive(true);
                }
                break;
            case 9:
                if (score >= 22)
                {
                    ItemPanel_f10.SetActive(true);
                    bkbutton_f10.SetActive(true);
                    drbutton_f10.SetActive(true);
                }
                break;
            case 10:
                if (score >= 25)
                {
                    ItemPanel_f11.SetActive(true);
                    bkbutton_f11.SetActive(true);
                    drbutton_f11.SetActive(true);
                }
                break;
            case 11:
                if (score >= 27)
                {
                    ItemPanel_f12.SetActive(true);
                    bkbutton_f12.SetActive(true);
                    drbutton_f12.SetActive(true);
                }
                break;
            case 12:
                if (score >= 30)
                {
                    ItemPanel_f13.SetActive(true);
                    bkbutton_f13.SetActive(true);
                    drbutton_f13.SetActive(true);
                }
                break;
            case 13:
                if (score >= 32)
                {
                    ItemPanel_f14.SetActive(true);
                    bkbutton_f14.SetActive(true);
                    drbutton_f14.SetActive(true);
                }
                break;
            case 14:
                if (score >= 35)
                {
                    ItemPanel_f15.SetActive(true);
                    bkbutton_f15.SetActive(true);
                    drbutton_f15.SetActive(true);
                }
                break;
            case 15:
                if (score >= 37)
                {
                    ItemPanel_f16.SetActive(true);
                    bkbutton_f16.SetActive(true);
                    drbutton_f16.SetActive(true);
                }
                break;
            case 16:
                if (score >= 40)
                {
                    ItemPanel_f17.SetActive(true);
                    bkbutton_f17.SetActive(true);
                    drbutton_f17.SetActive(true);
                }
                break;
            case 17:
                if (score >= 42)
                {
                    ItemPanel_f18.SetActive(true);
                    bkbutton_f18.SetActive(true);
                    drbutton_f18.SetActive(true);
                }
                break;
            case 18:
                if (score >= 45)
                {
                    ItemPanel_f19.SetActive(true);
                    bkbutton_f19.SetActive(true);
                    drbutton_f19.SetActive(true);
                }
                break;
            case 19:
                if (score >= 47)
                {
                    ItemPanel_f20.SetActive(true);
                    bkbutton_f20.SetActive(true);
                    drbutton_f20.SetActive(true);
                }
                break;
            case 20:
                if (score >= 50)
                {
                    ItemPanel_f21.SetActive(true);
                    bkbutton_f21.SetActive(true);
                    drbutton_f21.SetActive(true);
                }
                break;
            case 21:
                if (score >= 52)
                {
                    ItemPanel_f22.SetActive(true);
                    bkbutton_f22.SetActive(true);
                    drbutton_f22.SetActive(true);
                }
                break;
            case 22:
                if (score >= 55)
                {
                    ItemPanel_f23.SetActive(true);
                    bkbutton_f23.SetActive(true);
                    drbutton_f23.SetActive(true);
                }
                break;
            case 23:
                if (score >= 57)
                {
                    ItemPanel_f24.SetActive(true);
                    bkbutton_f24.SetActive(true);
                    drbutton_f24.SetActive(true);
                }
                break;
        }

    }
    public void back_f()
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
    }
    public void directItem_f()
    {
        buttonComplete_f.SetActive(true); //配置しましたメッセージ
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
    }
    public void back2_f()
    {
        buttonComplete_f.SetActive(false);
    }

    //Buttonが押されたときの処理
    //ItemPanelをアクティブにする
    //アクセパネルの方
    public void AccessItem_a(int number2)
    {
        //「SCORE」というキーで保存されているInt値を読み込み
        int score = PlayerPrefs.GetInt("SCORE");

        switch (number2)
        {
            case 0:
                if (score >= 5)
                {
                    ItemPanel_a1.SetActive(true);
                    bkbutton_a1.SetActive(true);
                    drbutton_a1.SetActive(true);
                }
                break;
            case 1:
                if (score >= 7)
                {
                    ItemPanel_a2.SetActive(true);
                    bkbutton_a2.SetActive(true);
                    drbutton_a2.SetActive(true);
                }
                break;
            case 2:
                if (score >= 10)
                {
                    ItemPanel_a3.SetActive(true);
                    bkbutton_a3.SetActive(true);
                    drbutton_a3.SetActive(true);
                }
                break;
            case 3:
                if (score >= 12)
                {
                    ItemPanel_a4.SetActive(true);
                    bkbutton_a4.SetActive(true);
                    drbutton_a4.SetActive(true);
                }
                break;
            case 4:
                if (score >= 15)
                {
                    ItemPanel_a5.SetActive(true);
                    bkbutton_a5.SetActive(true);
                    drbutton_a5.SetActive(true);
                }
                break;
            case 5:
                if (score >= 17)
                {
                    ItemPanel_a6.SetActive(true);
                    bkbutton_a6.SetActive(true);
                    drbutton_a6.SetActive(true);
                }
                break;
            case 6:
                if (score >= 20)
                {
                    ItemPanel_a7.SetActive(true);
                    bkbutton_a7.SetActive(true);
                    drbutton_a7.SetActive(true);
                }
                break;
            case 7:
                if (score >= 22)
                {
                    ItemPanel_a8.SetActive(true);
                    bkbutton_a8.SetActive(true);
                    drbutton_a8.SetActive(true);
                }
                break;
            case 8:
                if (score >= 25)
                {
                    ItemPanel_a9.SetActive(true);
                    bkbutton_a9.SetActive(true);
                    drbutton_a9.SetActive(true);
                }
                break;
            case 9:
                if (score >= 27)
                {
                    ItemPanel_a10.SetActive(true);
                    bkbutton_a10.SetActive(true);
                    drbutton_a10.SetActive(true);
                }
                break;
            case 10:
                if (score >= 30)
                {
                    ItemPanel_a11.SetActive(true);
                    bkbutton_a11.SetActive(true);
                    drbutton_a11.SetActive(true);
                }
                break;
            case 11:
                if (score >= 32)
                {
                    ItemPanel_a12.SetActive(true);
                    bkbutton_a12.SetActive(true);
                    drbutton_a12.SetActive(true);
                }
                break;
            case 12:
                if (score >= 35)
                {
                    ItemPanel_a13.SetActive(true);
                    bkbutton_a13.SetActive(true);
                    drbutton_a13.SetActive(true);
                }
                break;
            case 13:
                if (score >= 37)
                {
                    ItemPanel_a14.SetActive(true);
                    bkbutton_a14.SetActive(true);
                    drbutton_a14.SetActive(true);
                }
                break;
            case 14:
                if (score >= 40)
                {
                    ItemPanel_a15.SetActive(true);
                    bkbutton_a15.SetActive(true);
                    drbutton_a15.SetActive(true);
                }
                break;
            case 15:
                if (score >= 42)
                {
                    ItemPanel_a16.SetActive(true);
                    bkbutton_a16.SetActive(true);
                    drbutton_a16.SetActive(true);
                }
                break;
            case 16:
                if (score >= 45)
                {
                    ItemPanel_a17.SetActive(true);
                    bkbutton_a17.SetActive(true);
                    drbutton_a17.SetActive(true);
                }
                break;
            case 17:
                if (score >= 47)
                {
                    ItemPanel_a18.SetActive(true);
                    bkbutton_a18.SetActive(true);
                    drbutton_a18.SetActive(true);
                }
                break;
            case 18:
                if (score >= 50)
                {
                    ItemPanel_a19.SetActive(true);
                    bkbutton_a19.SetActive(true);
                    drbutton_a19.SetActive(true);
                }
                break;
            case 19:
                if (score >= 52)
                {
                    ItemPanel_a20.SetActive(true);
                    bkbutton_a20.SetActive(true);
                    drbutton_a20.SetActive(true);
                }
                break;
            case 20:
                if (score >= 55)
                {
                    ItemPanel_a21.SetActive(true);
                    bkbutton_a21.SetActive(true);
                    drbutton_a21.SetActive(true);
                }
                break;
            case 21:
                if (score >= 57)
                {
                    ItemPanel_a22.SetActive(true);
                    bkbutton_a22.SetActive(true);
                    drbutton_a22.SetActive(true);
                }
                break;
            case 22:
                if (score >= 60)
                {
                    ItemPanel_a23.SetActive(true);
                    bkbutton_a23.SetActive(true);
                    drbutton_a23.SetActive(true);
                }
                break;
            case 23:
                if (score >= 62)
                {
                    ItemPanel_a24.SetActive(true);
                    bkbutton_a24.SetActive(true);
                    drbutton_a24.SetActive(true);
                }
                break;
            case 24:
                if (score >= 65)
                {
                    ItemPanel_a25.SetActive(true);
                    bkbutton_a25.SetActive(true);
                    drbutton_a25.SetActive(true);
                }
                break;
            case 25:
                if (score >= 67)
                {
                    ItemPanel_a26.SetActive(true);
                    bkbutton_a26.SetActive(true);
                    drbutton_a26.SetActive(true);
                }
                break;
            case 26:
                if (score >= 70)
                {
                    ItemPanel_a27.SetActive(true);
                    bkbutton_a27.SetActive(true);
                    drbutton_a27.SetActive(true);
                }
                break;
            case 27:
                if (score >= 72)
                {
                    ItemPanel_a28.SetActive(true);
                    bkbutton_a28.SetActive(true);
                    drbutton_a28.SetActive(true);
                }
                break;
            case 28:
                if (score >= 75)
                {
                    ItemPanel_a29.SetActive(true);
                    bkbutton_a29.SetActive(true);
                    drbutton_a29.SetActive(true);
                }
                break;
            case 29:
                if (score >= 77)
                {
                    ItemPanel_a30.SetActive(true);
                    bkbutton_a30.SetActive(true);
                    drbutton_a30.SetActive(true);
                }
                break;
            case 30:
                if (score >= 80)
                {
                    ItemPanel_a31.SetActive(true);
                    bkbutton_a31.SetActive(true);
                    drbutton_a31.SetActive(true);
                }
                break;
            case 31:
                if (score >= 82)
                {
                    ItemPanel_a32.SetActive(true);
                    bkbutton_a32.SetActive(true);
                    drbutton_a32.SetActive(true);
                }
                break;
            case 32:
                if (score >= 85)
                {
                    ItemPanel_a33.SetActive(true);
                    bkbutton_a33.SetActive(true);
                    drbutton_a33.SetActive(true);
                }
                break;
            case 33:
                if (score >= 87)
                {
                    ItemPanel_a34.SetActive(true);
                    bkbutton_a34.SetActive(true);
                    drbutton_a34.SetActive(true);
                }
                break;
            case 34:
                if (score >= 90)
                {
                    ItemPanel_a35.SetActive(true);
                    bkbutton_a35.SetActive(true);
                    drbutton_a35.SetActive(true);
                }
                break;
            case 35:
                if (score >= 92)
                {
                    ItemPanel_a36.SetActive(true);
                    bkbutton_a36.SetActive(true);
                    drbutton_a36.SetActive(true);
                }
                break;
        }
    }
    public void back_a()
    {
        ItemPanel_a1.SetActive(false);
        ItemPanel_a2.SetActive(false);
        ItemPanel_a3.SetActive(false);
        ItemPanel_a4.SetActive(false);
        ItemPanel_a5.SetActive(false);
        ItemPanel_a6.SetActive(false);
        ItemPanel_a7.SetActive(false);
        ItemPanel_a8.SetActive(false);
        ItemPanel_a9.SetActive(false);
        ItemPanel_a10.SetActive(false);
        ItemPanel_a11.SetActive(false);
        ItemPanel_a12.SetActive(false);
        ItemPanel_a13.SetActive(false);
        ItemPanel_a14.SetActive(false);
        ItemPanel_a15.SetActive(false);
        ItemPanel_a16.SetActive(false);
        ItemPanel_a17.SetActive(false);
        ItemPanel_a18.SetActive(false);
        ItemPanel_a19.SetActive(false);
        ItemPanel_a20.SetActive(false);
        ItemPanel_a21.SetActive(false);
        ItemPanel_a22.SetActive(false);
        ItemPanel_a23.SetActive(false);
        ItemPanel_a24.SetActive(false);
        ItemPanel_a25.SetActive(false);
        ItemPanel_a26.SetActive(false);
        ItemPanel_a27.SetActive(false);
        ItemPanel_a28.SetActive(false);
        ItemPanel_a29.SetActive(false);
        ItemPanel_a30.SetActive(false);
        ItemPanel_a31.SetActive(false);
        ItemPanel_a32.SetActive(false);
        ItemPanel_a33.SetActive(false);
        ItemPanel_a34.SetActive(false);
        ItemPanel_a35.SetActive(false);
        ItemPanel_a36.SetActive(false);
    }
    public void directItem_a()
    {
        buttonComplete_a.SetActive(true);
        ItemPanel_a1.SetActive(false);
        ItemPanel_a2.SetActive(false);
        ItemPanel_a3.SetActive(false);
        ItemPanel_a4.SetActive(false);
        ItemPanel_a5.SetActive(false);
        ItemPanel_a6.SetActive(false);
        ItemPanel_a7.SetActive(false);
        ItemPanel_a8.SetActive(false);
        ItemPanel_a9.SetActive(false);
        ItemPanel_a10.SetActive(false);
        ItemPanel_a11.SetActive(false);
        ItemPanel_a12.SetActive(false);
        ItemPanel_a13.SetActive(false);
        ItemPanel_a14.SetActive(false);
        ItemPanel_a15.SetActive(false);
        ItemPanel_a16.SetActive(false);
        ItemPanel_a17.SetActive(false);
        ItemPanel_a18.SetActive(false);
        ItemPanel_a19.SetActive(false);
        ItemPanel_a20.SetActive(false);
        ItemPanel_a21.SetActive(false);
        ItemPanel_a22.SetActive(false);
        ItemPanel_a23.SetActive(false);
        ItemPanel_a24.SetActive(false);
        ItemPanel_a25.SetActive(false);
        ItemPanel_a26.SetActive(false);
        ItemPanel_a27.SetActive(false);
        ItemPanel_a28.SetActive(false);
        ItemPanel_a29.SetActive(false);
        ItemPanel_a30.SetActive(false);
        ItemPanel_a31.SetActive(false);
        ItemPanel_a32.SetActive(false);
        ItemPanel_a33.SetActive(false);
        ItemPanel_a34.SetActive(false);
        ItemPanel_a35.SetActive(false);
        ItemPanel_a36.SetActive(false);
    }
    public void back2_a()
    {
        buttonComplete_a.SetActive(false);
    }

}