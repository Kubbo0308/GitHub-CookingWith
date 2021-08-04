using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Debug = UnityEngine.Debug;

public class PetManager : MonoBehaviour
{
    //ペットの画像
    public Sprite Sprite_dog, Sprite_cat, Sprite_bird, Sprite_rabbit;
    public Sprite dog_Good, dog_Bad, dog_Meat, dog_Vegetable, dog_Carbo;
    public Sprite cat_Good, cat_Bad, cat_Meat, cat_Vegetable, cat_Carbo;
    public Sprite bird_Good, bird_Bad, bird_Meat, bird_Vegetable, bird_Carbo;
    public Sprite rabbit_Good, rabbit_Bad, rabbit_Meat, rabbit_Vegetable, rabbit_Carbo;
    public Image image_pet;
    public Image image_pet2; //名前入力画面のペット画像
    public Image image_pet3; //ホーム画面に滞在するペット画像

    //アクセの画像
    //この画像に変更する
    public Sprite Sprite_boushi1, Sprite_kubiwa1, Sprite_megane1;
    public Sprite Sprite_boushi2, Sprite_kubiwa2, Sprite_megane2;
    public Sprite Sprite_boushi3, Sprite_kubiwa3, Sprite_megane3;
    //どの画像を変更する？
    public Image image_boushi, image_kubiwa,image_megane;

    [SerializeField] GameObject SelectPetPanel;
    [SerializeField] GameObject NamePetPanel;

    public GameObject SelectButton_right;
    public GameObject SelectButton_left;
    public GameObject DecisionButton;

    public Text petText;

    int whatpet = 0;

    //日付に関する変数
    private string nowDay;
    private int nowDayInt;
    private int lastDayInt;
    private int day;

    //パラメータに関する変数
     private float meatDog;
    private float vegetableDog;
    private float carboDog;

    //日記の書いた回数に関する変数
    private int score;
    //ペットを選択したか判定
    private int selectPet = 0;

    // Start is called before the first frame update
    void Start()
    {
        SelectPetPanel.SetActive(false); //最初は非表示
        NamePetPanel.SetActive(false); //最初は非表示

        //「START」というキーで保存されているInt値を読み込み
        int start = PlayerPrefs.GetInt("START");
        Debug.Log("タイトルからスタートボタンを押した回数は" + start);
        if (start == 1)
        {
            image_pet3.enabled = false; //最初は非表示
            SelectPetPanel.SetActive(true); //表示
            SelectButton_left.SetActive(false); //最初は非表示

            //違うシーンから戻ったときにもう一度選択画面が出るのに対処
            start++;
            PlayerPrefs.SetInt("START", start);
            PlayerPrefs.Save();
        }

        int PetPoint = PlayerPrefs.GetInt("PET");
        Debug.Log("選択しているペットは" + PetPoint);

        if (PetPoint == 0)
        {
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_pet3.sprite = Sprite_dog;
        }
        else if (PetPoint == 1)
        {
            image_pet3.sprite = Sprite_cat;
        }
        else if (PetPoint == 2)
        {
            image_pet3.sprite = Sprite_bird;
        }
        else if (PetPoint == 3)
        {
            image_pet3.sprite = Sprite_rabbit;
        }

        //「Accessory_○○」というキーで保存されているInt値を読み込み
        int Accessory_b = PlayerPrefs.GetInt("Accessory_b"); //帽子判定のための変数
        int Accessory_k = PlayerPrefs.GetInt("Accessory_k"); //首輪定のための変数
        int Accessory_m = PlayerPrefs.GetInt("Accessory_m"); //眼鏡判定のための変数

        Debug.Log(" 今選択されている帽子は" + Accessory_b);
        Debug.Log(" 今選択されている首輪は" + Accessory_k);
        Debug.Log(" 今選択されている眼鏡は" + Accessory_m);

        image_boushi.enabled = false; //最初は非表示
        image_kubiwa.enabled = false; //最初は非表示
        image_megane.enabled = false; //最初は非表示

        //furniture(どの壁紙を選択しているか)で壁紙変更
        if (Accessory_b == 1)
        {
            image_boushi.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_boushi.sprite = Sprite_boushi1;
        }
        if (Accessory_b == 2)
        {
            image_boushi.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_boushi.sprite = Sprite_boushi2;
        }
        if (Accessory_b == 3)
        {
            image_boushi.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_boushi.sprite = Sprite_boushi3;
        }
        if (Accessory_k == 1)
        {
            image_kubiwa.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_kubiwa.sprite = Sprite_kubiwa1;
        }
        if (Accessory_k == 2)
        {
            image_kubiwa.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_kubiwa.sprite = Sprite_kubiwa2;
        }
        if (Accessory_k == 3)
        {
            image_kubiwa.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_kubiwa.sprite = Sprite_kubiwa3;
        }
        if (Accessory_m == 1)
        {
            image_megane.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_megane.sprite = Sprite_megane1;
        }
        if (Accessory_m == 2)
        {
            image_megane.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_megane.sprite = Sprite_megane2;
        }
        if (Accessory_m == 3)
        {
            image_megane.enabled = true; //表示する
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_megane.sprite = Sprite_megane3;
        }

         //「SCORE」というキーで保存されているInt値を読み込み
        score = PlayerPrefs.GetInt("SCORE");

        //「LAST」というキーで保存されているInt値を読み込み
        lastDayInt = PlayerPrefs.GetInt("LAST");

        //保存されている3つのパラメータのFloat値を読み込み
        meatDog = PlayerPrefs.GetFloat("MEATDOG", 0);
        vegetableDog = PlayerPrefs.GetFloat("VEGETABLEDOG", 0);
        carboDog = PlayerPrefs.GetFloat("CARBODOG", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (whatpet == 0) {
            Debug.Log("イヌのUpDateは走っているよ");
            //現在の日付取得
            DateTime TodayNow = DateTime.Now;
            nowDay = TodayNow.Day.ToString();
            nowDayInt = int.Parse(nowDay);
  
            //現在の日付から最後に料理日記を書いた日付を引く
            day = nowDayInt - lastDayInt;

            //dayが3日以上空いていたら
            if ((day > 3) || (day < -27))
            {
                //アニメを衰弱状態にする
                image_pet3.sprite = dog_Bad;
            } else {
                //アニメを元に戻す
                image_pet3.sprite = Sprite_dog;
            }

            //肉中心の時
            if ((score >= 5) && (meatDog > 20.0f)){
                image_pet3.sprite = dog_Meat;
            } else if ((score >= 5) && (vegetableDog > 20.0f)){ //野菜中心の時
                image_pet3.sprite = dog_Vegetable;
            } else if ((score >= 5) && (carboDog > 20.0f)){ //炭水化物中心の時
                image_pet3.sprite = dog_Carbo;
            } else if (score >= 5){ //バランスが良い時
                image_pet3.sprite = dog_Good;
            }
        } else if (whatpet == 1) {
            Debug.Log("ネコのUpDateは走っているよ");
            //現在の日付取得
            DateTime TodayNow = DateTime.Now;
            nowDay = TodayNow.Day.ToString();
            nowDayInt = int.Parse(nowDay);
  
            //現在の日付から最後に料理日記を書いた日付を引く
            day = nowDayInt - lastDayInt;

            //dayが3日以上空いていたら
            if ((day > 3) || (day < -27))
            {
                //アニメを衰弱状態にする
                image_pet3.sprite = cat_Bad;
            } else {
                //アニメを元に戻す
                image_pet3.sprite = Sprite_cat;
            }

            //肉中心の時
            if ((score >= 5) && (meatDog > 20.0f)){
                image_pet3.sprite = cat_Meat;
            } else if ((score >= 5) && (vegetableDog > 20.0f)){ //野菜中心の時
                image_pet3.sprite = cat_Vegetable;
            } else if ((score >= 5) && (carboDog > 20.0f)){ //炭水化物中心の時
                image_pet3.sprite = cat_Carbo;
            } else if (score >= 5){ //バランスが良い時
                image_pet3.sprite = cat_Good;
            }

        } else if (whatpet == 2) {
            Debug.Log("トリのUpDateは走っているよ");
            //現在の日付取得
            DateTime TodayNow = DateTime.Now;
            nowDay = TodayNow.Day.ToString();
            nowDayInt = int.Parse(nowDay);
  
            //現在の日付から最後に料理日記を書いた日付を引く
            day = nowDayInt - lastDayInt;

            //dayが3日以上空いていたら
            if ((day > 3) || (day < -27))
            {
                //アニメを衰弱状態にする
                image_pet3.sprite = bird_Bad;
            } else {
                //アニメを元に戻す
                image_pet3.sprite = Sprite_bird;
            }

            //肉中心の時
            if ((score >= 5) && (meatDog > 20.0f)){
                image_pet3.sprite = bird_Meat;
            } else if ((score >= 5) && (vegetableDog > 20.0f)){ //野菜中心の時
                image_pet3.sprite = bird_Vegetable;
            } else if ((score >= 5) && (carboDog > 20.0f)){ //炭水化物中心の時
                image_pet3.sprite = bird_Carbo;
            } else if (score >= 5){ //バランスが良い時
                image_pet3.sprite = bird_Good;
            }
        } else {
            Debug.Log("ウサギのUpDateは走っているよ");
            //現在の日付取得
            DateTime TodayNow = DateTime.Now;
            nowDay = TodayNow.Day.ToString();
            nowDayInt = int.Parse(nowDay);
  
            //現在の日付から最後に料理日記を書いた日付を引く
            day = nowDayInt - lastDayInt;

            //dayが3日以上空いていたら
            if ((day > 3) || (day < -27))
            {
                //アニメを衰弱状態にする
                image_pet3.sprite = rabbit_Bad;
            } else {
                //アニメを元に戻す
                image_pet3.sprite = Sprite_rabbit;
            }

            //肉中心の時
            if ((score >= 5) && (meatDog > 20.0f)){
                image_pet3.sprite = rabbit_Meat;
            } else if ((score >= 5) && (vegetableDog > 20.0f)){ //野菜中心の時
                image_pet3.sprite = rabbit_Vegetable;
            } else if ((score >= 5) && (carboDog > 20.0f)){ //炭水化物中心の時
                image_pet3.sprite = rabbit_Carbo;
            } else if (score >= 5){ //バランスが良い時
                image_pet3.sprite = rabbit_Good;
            }
        }
    }

    //三角ボタン(右)が押されたとき
    public void SelectPet_right()
    {
        whatpet++;
        if (whatpet == 1)
        {
            image_pet.sprite = Sprite_cat;
            SelectButton_right.SetActive(true);
            SelectButton_left.SetActive(true);
            petText.text = "ネコ";
        }
        else if (whatpet == 2)
        {
            image_pet.sprite = Sprite_bird;
            SelectButton_right.SetActive(true);
            petText.text = "トリ";
        }
        else if (whatpet == 3)
        {
            image_pet.sprite = Sprite_rabbit;
            SelectButton_right.SetActive(false);
            petText.text = "ウサギ";
        }
    }

    //三角ボタン(左)が押されたとき
    public void SelectPet_left()
    {
        whatpet--;
        if (whatpet == 0)
        {
            SelectButton_left.SetActive(false);
            image_pet.sprite = Sprite_dog;
            petText.text = "イヌ";
        }
        else if (whatpet == 1)
        {
            SelectButton_right.SetActive(true);
            image_pet.sprite = Sprite_cat;
            petText.text = "ネコ";
        }
        else if (whatpet == 2)
        {
            SelectButton_right.SetActive(true);
            image_pet.sprite = Sprite_bird;
            petText.text = "トリ";
        }
    }

    public void NamePet()
    {
        SelectPetPanel.SetActive(false);
        NamePetPanel.SetActive(true);

        if (whatpet == 0)
        {
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_pet2.sprite = Sprite_dog;
        }
        else if (whatpet == 1)
        {
            image_pet2.sprite = Sprite_cat;
        }
        else if (whatpet == 2)
        {
            image_pet2.sprite = Sprite_bird;
        }
        else if (whatpet == 3)
        {
            image_pet2.sprite = Sprite_rabbit;
        }

    }

    public void back_pet()
    {
        SelectPetPanel.SetActive(true);
        NamePetPanel.SetActive(false);
    }
    public void decision_pet()
    {
        NamePetPanel.SetActive(false);
        image_pet3.enabled = true;

        PlayerPrefs.SetInt("PET", whatpet);
        PlayerPrefs.Save();

        if (whatpet == 0)
        {
            // SpriteRenderのspriteを設定済みの他のspriteに変更
            image_pet3.sprite = Sprite_dog;
        }
        else if (whatpet == 1)
        {
            image_pet3.sprite = Sprite_cat;
        }
        else if (whatpet == 2)
        {
            image_pet3.sprite = Sprite_bird;
        }
        else if (whatpet == 3)
        {
            image_pet3.sprite = Sprite_rabbit;
        }
    }
}
