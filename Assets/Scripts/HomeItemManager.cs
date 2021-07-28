using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeItemManager : MonoBehaviour
{
    // publicで宣言し、inspectorで設定可能にする
    //この画像に変更する
    public Sprite Sprite_f1, Sprite_f2, Sprite_f3, Sprite_f4, Sprite_f5;
    public Sprite Sprite_f6, Sprite_f7, Sprite_f8, Sprite_f9, Sprite_f10;
    public Sprite Sprite_f11, Sprite_f12, Sprite_f13, Sprite_f14, Sprite_f15;
    public Sprite Sprite_f16, Sprite_f17, Sprite_f18, Sprite_f19, Sprite_f20;
    public Sprite Sprite_f21, Sprite_f22, Sprite_f23, Sprite_f24;

    //どの画像を変更する？
    public Image image_f1, image_f2, image_f3;
    public Image image_f4, image_f5, image_f6;

    // Start is called before the first frame update
    void Start()
    {
        //「Furniture_○○」というキーで保存されているInt値を読み込み
        int furniture_k = PlayerPrefs.GetInt("Furniture_k");
        int furniture_y = PlayerPrefs.GetInt("Furniture_y");
        int furniture_z = PlayerPrefs.GetInt("Furniture_z");
        int furniture_t = PlayerPrefs.GetInt("Furniture_t");
        int furniture_ku = PlayerPrefs.GetInt("Furniture_ku");
        int furniture_m = PlayerPrefs.GetInt("Furniture_m");

        Debug.Log(" 今選択されている壁紙は" + furniture_k);
        Debug.Log(" 今選択されている床は" + furniture_y);
        Debug.Log(" 今選択されている座布団は" + furniture_z);
        Debug.Log(" 今選択されている机は" + furniture_t);
        Debug.Log(" 今選択されているクローゼットは" + furniture_ku);
        Debug.Log(" 今選択されている窓は" + furniture_m);

        image_f2.enabled = false; //最初は非表示
        image_f3.enabled = false; //最初は非表示
        image_f4.enabled = false; //最初は非表示
        image_f5.enabled = false; //最初は非表示
        image_f6.enabled = false; //最初は非表示

        //furniture(どの壁紙を選択しているか)で壁紙変更
        if (furniture_k == 1)
        {
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f1.sprite = Sprite_f1;
        }
        if (furniture_k == 2)
        {
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f1.sprite = Sprite_f2;
        }
        if (furniture_k == 3)
        {
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f1.sprite = Sprite_f3;
        }
        if (furniture_k == 4)
        {
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f1.sprite = Sprite_f4;
        }
        if (furniture_y == 1)
        {
            image_f2.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f2.sprite = Sprite_f5;
        }
        if (furniture_y == 2)
        {
            image_f2.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f2.sprite = Sprite_f6;
        }
        if (furniture_y == 3)
        {
            image_f2.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f2.sprite = Sprite_f7;
        }
        if (furniture_y == 4)
        {
            image_f2.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f2.sprite = Sprite_f8;
        }
        if (furniture_z == 1)
        {
            image_f3.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f3.sprite = Sprite_f9;
        }
        if (furniture_z == 2)
        {
            image_f3.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f3.sprite = Sprite_f10;
        }
        if (furniture_z == 3)
        {
            image_f3.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f3.sprite = Sprite_f11;
        }
        if (furniture_z == 4)
        {
            image_f3.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f3.sprite = Sprite_f12;
        }
        if (furniture_t == 1)
        {
            image_f4.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f4.sprite = Sprite_f13;
        }
        if (furniture_t == 2)
        {
            image_f4.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f4.sprite = Sprite_f14;
        }
        if (furniture_t == 3)
        {
            image_f4.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f4.sprite = Sprite_f15;
        }
        if (furniture_t == 4)
        {
            image_f4.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f4.sprite = Sprite_f16;
        }
        if (furniture_ku == 1)
        {
            image_f5.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f5.sprite = Sprite_f17;
        }
        if (furniture_ku == 2)
        {
            image_f5.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f5.sprite = Sprite_f18;
        }
        if (furniture_ku == 3)
        {
            image_f5.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f5.sprite = Sprite_f19;
        }
        if (furniture_ku == 4)
        {
            image_f5.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f5.sprite = Sprite_f20;
        }
        if (furniture_m == 1)
        {
            image_f6.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f6.sprite = Sprite_f21;
        }
        if (furniture_m == 2)
        {
            image_f6.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f6.sprite = Sprite_f22;
        }
        if (furniture_m == 3)
        {
            image_f6.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f6.sprite = Sprite_f23;
        }
        if (furniture_m == 4)
        {
            image_f6.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_f6.sprite = Sprite_f24;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
