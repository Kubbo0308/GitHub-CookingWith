using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetIconManager : MonoBehaviour
{
    //インスペクターウィンドウからゲームオブジェクトを設定する
    //アイテムパネル
    [SerializeField] GameObject ItemPanel_f1, ItemPanel_f2, ItemPanel_f3, ItemPanel_f4;
    [SerializeField] GameObject ItemPanel_f5, ItemPanel_f6, ItemPanel_f7, ItemPanel_f8;
    [SerializeField] GameObject ItemPanel_f9, ItemPanel_f10, ItemPanel_f11, ItemPanel_f12;
    [SerializeField] GameObject ItemPanel_f13, ItemPanel_f14, ItemPanel_f15, ItemPanel_f16;
    [SerializeField] GameObject ItemPanel_f17, ItemPanel_f18, ItemPanel_f19, ItemPanel_f20;
    [SerializeField] GameObject ItemPanel_f21, ItemPanel_f22, ItemPanel_f23, ItemPanel_f24;

    public GameObject buttonComplete_f; //家具の方の完了ボタン

    //戻るボタン
    public GameObject bkbutton_f1, bkbutton_f2, bkbutton_f3, bkbutton_f4;
    public GameObject bkbutton_f5, bkbutton_f6, bkbutton_f7, bkbutton_f8;
    public GameObject bkbutton_f9, bkbutton_f10, bkbutton_f11, bkbutton_f12;
    public GameObject bkbutton_f13, bkbutton_f14, bkbutton_f15, bkbutton_f16;
    public GameObject bkbutton_f17, bkbutton_f18, bkbutton_f19, bkbutton_f20;
    public GameObject bkbutton_f21, bkbutton_f22, bkbutton_f23, bkbutton_f24;

    //配置ボタン
    public GameObject drbutton_f1, drbutton_f2, drbutton_f3, drbutton_f4;
    public GameObject drbutton_f5, drbutton_f6, drbutton_f7, drbutton_f8;
    public GameObject drbutton_f9, drbutton_f10, drbutton_f11, drbutton_f12;
    public GameObject drbutton_f13, drbutton_f14, drbutton_f15, drbutton_f16;
    public GameObject drbutton_f17, drbutton_f18, drbutton_f19, drbutton_f20;
    public GameObject drbutton_f21, drbutton_f22, drbutton_f23, drbutton_f24;

    // publicで宣言し、inspectorで設定可能にする
    //この画像に変更する
    public Sprite Sprite_f1, Sprite_f2, Sprite_f3, Sprite_f4, Sprite_f5;
    public Sprite Sprite_f6, Sprite_f7, Sprite_f8, Sprite_f9, Sprite_f10;
    public Sprite Sprite_f11, Sprite_f12, Sprite_f13, Sprite_f14, Sprite_f15;
    public Sprite Sprite_f16, Sprite_f17, Sprite_f18, Sprite_f19, Sprite_f20;
    public Sprite Sprite_f21, Sprite_f22, Sprite_f23, Sprite_f24;

    //どのボタンの画像か
    public Image image_f1, image_f2, image_f3, image_f4, image_f5;
    public Image image_f6, image_f7, image_f8, image_f9, image_f10;
    public Image image_f11, image_f12, image_f13, image_f14, image_f15;
    public Image image_f16, image_f17, image_f18, image_f19, image_f20;
    public Image image_f21, image_f22, image_f23, image_f24;

    //そのペットを育てたことがあるか判定するための変数
    int Point0, Point1, Point2, Point3, Point4, Point5;
    int Point6, Point7, Point8, Point9, Point10, Point11;
    int Point12, Point13, Point14, Point15, Point16, Point17;
    int Point18, Point19, Point20, Point21, Point22, Point23;


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

        //「PET」というキーで保存されているInt値を読み込み
        int PetPoint = PlayerPrefs.GetInt("PET");


        //どの種類のペットを育成したかで画像を表示する
        if (PetPoint == 0)
        {
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f1.sprite = Sprite_f1;
            Point0 = 1;
        }
        if (PetPoint == 4)
        {
            image_f2.sprite = Sprite_f2;
            Point4 = 1;
        }
        if (PetPoint == 5)
        {
            image_f3.sprite = Sprite_f3;
            Point5 = 1;
        }
        if (PetPoint == 6)
        {
            image_f4.sprite = Sprite_f4;
            Point6 = 1;
        }
        if (PetPoint == 7)
        {
            image_f5.sprite = Sprite_f5;
            Point7 = 1;
        }
        if (PetPoint == 8)
        {
            image_f6.sprite = Sprite_f6;
            Point8 = 1;
        }
        if (PetPoint == 1)
        {
            image_f7.sprite = Sprite_f7;
            Point1 = 1;
        }
        if (PetPoint == 9)
        {
            image_f8.sprite = Sprite_f8;
            Point9 = 1;
        }
        if (PetPoint == 10)
        {
            image_f9.sprite = Sprite_f9;
            Point10 = 1;
        }
        if (PetPoint == 11)
        {
            image_f10.sprite = Sprite_f10;
            Point11 = 1;
        }
        if (PetPoint == 12)
        {
            image_f11.sprite = Sprite_f11;
            Point12 = 1;
        }
        if (PetPoint == 13)
        {
            image_f12.sprite = Sprite_f12;
            Point13 = 1;
        }
        if (PetPoint == 2)
        {
            image_f13.sprite = Sprite_f13;
            Point2 = 1;
        }
        if (PetPoint == 14)
        {
            image_f14.sprite = Sprite_f14;
            Point14 = 1;
        }
        if (PetPoint == 15)
        {
            image_f15.sprite = Sprite_f15;
            Point15 = 1;
        }
        if (PetPoint == 16)
        {
            image_f16.sprite = Sprite_f16;
            Point16 = 1;
        }
        if (PetPoint == 17)
        {
            image_f17.sprite = Sprite_f17;
            Point17 = 1;
        }
        if (PetPoint == 18)
        {
            image_f18.sprite = Sprite_f18;
            Point18 = 1;
        }
        if (PetPoint == 3)
        {
            image_f19.sprite = Sprite_f19;
            Point3 = 1;
        }
        if (PetPoint == 19)
        {
            image_f20.sprite = Sprite_f20;
            Point19 = 1;
        }
        if (PetPoint == 20)
        {
            image_f21.sprite = Sprite_f21;
            Point20 = 1;
        }
        if (PetPoint == 21)
        {
            image_f22.sprite = Sprite_f22;
            Point21 = 1;
        }
        if (PetPoint == 22)
        {
            image_f23.sprite = Sprite_f23;
            Point22 = 1;
        }
        if (PetPoint == 23)
        {
            image_f24.sprite = Sprite_f24;
            Point23 = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Buttonが押されたときの処理
    //ItemPanelをアクティブにする
    public void AccessPet(int number)
    {
        switch (number)
        {
            case 0:
                if (Point0 == 1)
                {
                    ItemPanel_f1.SetActive(true);
                    bkbutton_f1.SetActive(true);
                    drbutton_f1.SetActive(false);
                }
                break;
            case 1:
                if (Point4 == 1)
                {
                    ItemPanel_f2.SetActive(true);
                    bkbutton_f2.SetActive(true);
                    drbutton_f2.SetActive(true);
                }
                break;
            case 2:
                if (Point5 == 1)
                {
                    ItemPanel_f3.SetActive(true);
                    bkbutton_f3.SetActive(true);
                    drbutton_f3.SetActive(false);
                }
                break;
            case 3:
                if (Point6 == 1)
                {
                    ItemPanel_f4.SetActive(true);
                    bkbutton_f4.SetActive(true);
                    drbutton_f4.SetActive(true);
                }
                break;
            case 4:
               if (Point7 == 1)
                {
                    ItemPanel_f5.SetActive(true);
                    bkbutton_f5.SetActive(true);
                    drbutton_f5.SetActive(true);
                }
                break;
            case 5:
                if (Point8 == 1)
                {
                    ItemPanel_f6.SetActive(true);
                    bkbutton_f6.SetActive(true);
                    drbutton_f6.SetActive(true);
                }
                break;
            case 6:
               if (Point1 == 1)
                {
                    ItemPanel_f7.SetActive(true);
                    bkbutton_f7.SetActive(true);
                    drbutton_f7.SetActive(false);
                }
                break;
            case 7:
                if (Point9 == 1)
                {
                    ItemPanel_f8.SetActive(true);
                    bkbutton_f8.SetActive(true);
                    drbutton_f8.SetActive(true);
                }
                break;
            case 8:
                if (Point10 == 1)
                {
                    ItemPanel_f9.SetActive(true);
                    bkbutton_f9.SetActive(true);
                    drbutton_f9.SetActive(false);
                }
                break;
            case 9:
                 if (Point11 == 1)
                {
                    ItemPanel_f10.SetActive(true);
                    bkbutton_f10.SetActive(true);
                    drbutton_f10.SetActive(true);
                }
                break;
            case 10:
                if (Point12 == 1)
                {
                    ItemPanel_f11.SetActive(true);
                    bkbutton_f11.SetActive(true);
                    drbutton_f11.SetActive(true);
                }
                break;
            case 11:
                if (Point13 == 1)
                {
                    ItemPanel_f12.SetActive(true);
                    bkbutton_f12.SetActive(true);
                    drbutton_f12.SetActive(true);
                }
                break;
            case 12:
                if (Point2 == 1)
                {
                    ItemPanel_f13.SetActive(true);
                    bkbutton_f13.SetActive(true);
                    drbutton_f13.SetActive(false);
                }
                break;
            case 13:
                if (Point14 == 1)
                {
                    ItemPanel_f14.SetActive(true);
                    bkbutton_f14.SetActive(true);
                    drbutton_f14.SetActive(true);
                }
                break;
            case 14:
                if (Point15 == 1)
                {
                    ItemPanel_f15.SetActive(true);
                    bkbutton_f15.SetActive(true);
                    drbutton_f15.SetActive(false);
                }
                break;
            case 15:
                if (Point16 == 1)
                {
                    ItemPanel_f16.SetActive(true);
                    bkbutton_f16.SetActive(true);
                    drbutton_f16.SetActive(true);
                }
                break;
            case 16:
                if (Point17 == 1)
                {
                    ItemPanel_f17.SetActive(true);
                    bkbutton_f17.SetActive(true);
                    drbutton_f17.SetActive(true);
                }
                break;
            case 17:
                if (Point18 == 1)
                {
                    ItemPanel_f18.SetActive(true);
                    bkbutton_f18.SetActive(true);
                    drbutton_f18.SetActive(true);
                }
                break;
            case 18:
                if (Point3 == 1)
                {
                    ItemPanel_f19.SetActive(true);
                    bkbutton_f19.SetActive(true);
                    drbutton_f19.SetActive(false);
                }
                break;
            case 19:
                if (Point19 == 1)
                {
                    ItemPanel_f20.SetActive(true);
                    bkbutton_f20.SetActive(true);
                    drbutton_f20.SetActive(true);
                }
                break;
            case 20:
                if (Point20 == 1)
                {
                    ItemPanel_f21.SetActive(true);
                    bkbutton_f21.SetActive(true);
                    drbutton_f21.SetActive(false);
                }
                break;
            case 21:
                if (Point21 == 1)
                {
                    ItemPanel_f22.SetActive(true);
                    bkbutton_f22.SetActive(true);
                    drbutton_f22.SetActive(true);
                }
                break;
            case 22:
                if (Point22 == 1)
                {
                    ItemPanel_f23.SetActive(true);
                    bkbutton_f23.SetActive(true);
                    drbutton_f23.SetActive(true);
                }
                break;
            case 23:
                if (Point23 == 1)
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
    public void drPet(int drnumber)
    {
        buttonComplete_f.SetActive(true); //配置しましたメッセージ

        int PetPoint = PlayerPrefs.GetInt("pet"); //ペット判定のための変数

        //ホーム画面に配置できるのは育成完了後のペットのみ(通常・衰弱除く)
        switch (drnumber)
        {
            case 1:
                PetPoint = 0;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 3:
                PetPoint = 1;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 4:
                PetPoint = 2;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 5:
                PetPoint = 3;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 7:
                PetPoint = 4;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 9:
                PetPoint = 5;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 10:
                PetPoint = 6;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 11:
                PetPoint = 7;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 13:
                PetPoint = 8;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 15:
                PetPoint = 9;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 16:
                PetPoint = 10;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 17:
                PetPoint = 11;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 19:
                PetPoint =12;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 21:
                PetPoint = 13;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 22:
                PetPoint = 14;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
            case 23:
                PetPoint = 15;
                Debug.Log(PetPoint);
                PlayerPrefs.SetInt("pet", PetPoint);
                PlayerPrefs.Save();
                break;
        }

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

  
}
