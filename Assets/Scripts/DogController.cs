using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Debug = UnityEngine.Debug;

public class DogController : MonoBehaviour
{

    private Animator animator;

    private string nowDay;

    private int nowDayInt;

    private int lastDayInt;

    private string character;

    private int day;

    private float meatDog;
    private float vegetableDog;
    private float carboDog;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //「SCORE」というキーで保存されているInt値を読み込み
        score = PlayerPrefs.GetInt("SCORE");

        //「LAST」というキーで保存されているInt値を読み込み
        lastDayInt = PlayerPrefs.GetInt("LAST");

        //「CHARACTER」というキーで保存されているstring値を読み込み
        character = PlayerPrefs.GetString("CHARACTER");

        //保存されている3つのパラメータのFloat値を読み込み
        meatDog = PlayerPrefs.GetFloat("MEATDOG", 0);
        vegetableDog = PlayerPrefs.GetFloat("VEGETABLEDOG", 0);
        carboDog = PlayerPrefs.GetFloat("CARBODOG", 0);

                //「CHARACTER」というキーで保存されているstring値を読み込み
        character = PlayerPrefs.GetString("CHARACTER");

        int petPoint = PlayerPrefs.GetInt("WHAT_PET");

        if (petPoint == 0 || petPoint == 1 || petPoint == 2 || petPoint == 3 || petPoint == 4 || petPoint == 5) {
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
                petPoint = 1;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else {
                //アニメを元に戻す
                petPoint = 0;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }

            //肉中心の時
            if ((score >= 5) && (meatDog > 20.0f)){
                petPoint = 2;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else if ((score >= 5) && (vegetableDog > 20.0f)){ //野菜中心の時
                petPoint = 3;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else if ((score >= 5) && (carboDog > 20.0f)){ //炭水化物中心の時
                petPoint = 4;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else if (score >= 5){ //バランスが良い時
                petPoint = 5;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //「CHARACTER」というキーで保存されているstring値を読み込み
        character = PlayerPrefs.GetString("CHARACTER");

        int petPoint = PlayerPrefs.GetInt("WHAT_PET");

        if (character.Equals("DOG")) {
            //Debug.Log("イヌのUpDateは走っているよ");
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
                animator.SetBool("isBad", true);
                petPoint = 1;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else {
                //アニメを元に戻す
                animator.SetBool("isBad", false);
                petPoint = 0;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }

            //肉中心の時
            if ((score >= 5) && (meatDog > 20.0f)){
                animator.SetBool("isMeat", true);
                petPoint = 2;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else if ((score >= 5) && (vegetableDog > 20.0f)){ //野菜中心の時
                animator.SetBool("isVegetable", true);
                petPoint = 3;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else if ((score >= 5) && (carboDog > 20.0f)){ //炭水化物中心の時
                animator.SetBool("isCarbo", true);
                petPoint = 4;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else if (score >= 5){ //バランスが良い時
                animator.SetBool("isGood", true);
                petPoint = 5;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }
        }
    }

}
