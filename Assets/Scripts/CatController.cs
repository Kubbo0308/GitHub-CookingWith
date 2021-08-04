using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Debug = UnityEngine.Debug;

public class CatController : MonoBehaviour
{
    private Animator animator;

    private string nowDay;

    private int nowDayInt;

    private int lastDayInt;

    private string character;

    private int day;

    private float meatCat;
    private float vegetableCat;
    private float carboCat;

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
        meatCat = PlayerPrefs.GetFloat("MEATCAT", 0);
        vegetableCat = PlayerPrefs.GetFloat("VEGETABLECAT", 0);
        carboCat = PlayerPrefs.GetFloat("CARBOCAT", 0);

        //「CHARACTER」というキーで保存されているstring値を読み込み
        character = PlayerPrefs.GetString("CHARACTER");

        int petPoint = PlayerPrefs.GetInt("WHAT_PET");

        if (petPoint == 6 || petPoint == 17 || petPoint == 8 || petPoint == 9 || petPoint == 10 || petPoint == 11)
        {
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
                petPoint = 7;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }
            else
            {
                //アニメを元に戻す
                petPoint = 6;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }

            //肉中心の時
            if ((score >= 5) && (meatCat > 20.0f))
            {
                petPoint = 8;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }
            else if ((score >= 5) && (vegetableCat > 20.0f))
            { //野菜中心の時
                petPoint = 9;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }
            else if ((score >= 5) && (carboCat > 20.0f))
            { //炭水化物中心の時
                petPoint = 10;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }
            else if (score >= 5)
            { //バランスが良い時
                petPoint = 11;
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

        if (character.Equals("CAT")) {
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
                animator.SetBool("isBad", true);
                petPoint = 7;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else {
                //アニメを元に戻す
                animator.SetBool("isBad", false);
                petPoint = 6;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }

            //肉中心の時
            if ((score >= 5) && (meatCat > 20.0f)){
                animator.SetBool("isMeat", true);
                petPoint = 8;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else if ((score >= 5) && (vegetableCat > 20.0f)){ //野菜中心の時
                animator.SetBool("isVegetable", true);
                petPoint = 9;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else if ((score >= 5) && (carboCat > 20.0f)){ //炭水化物中心の時
                animator.SetBool("isCarbo", true);
                petPoint = 10;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else if (score >= 5){ //バランスが良い時
                animator.SetBool("isGood", true);
                petPoint = 11;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }
        }
    }
}
