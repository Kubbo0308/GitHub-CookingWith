using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Debug = UnityEngine.Debug;

public class BardController : MonoBehaviour
{
    private Animator animator;

    private string nowDay;

    private int nowDayInt;

    private int lastDayInt;

    private string character;

    private int day;

    private float meatBard;
    private float vegetableBard;
    private float carboBard;

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
        meatBard = PlayerPrefs.GetFloat("MEATBARD", 0);
        vegetableBard = PlayerPrefs.GetFloat("VEGETABLEBARD", 0);
        carboBard = PlayerPrefs.GetFloat("CARBOBARD", 0);

        int petPoint = PlayerPrefs.GetInt("WHAT_PET");

        int Point = PlayerPrefs.GetInt("POINT");

        if (petPoint == 12 || petPoint == 13 || petPoint == 14 || petPoint == 15 || petPoint == 16 || petPoint == 17)
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
                petPoint = 13;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();

            }
            else
            {
                //アニメを元に戻す
                petPoint = 12;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }

            //肉中心の時
            if ((Point >= 5) && (meatBard > 20.0f))
            {
                petPoint = 14;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }
            else if ((Point >= 5) && (vegetableBard > 20.0f))
            { //野菜中心の時
                petPoint = 15;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }
            else if ((Point >= 5) && (carboBard > 20.0f))
            { //炭水化物中心の時
                petPoint = 16;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }
            else if (Point >= 5)
            { //バランスが良い時
                petPoint = 17;
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

        if (character.Equals("BARD")) {
            Debug.Log("トリのUpDateは走っているよ");
            //現在の日付取得
            DateTime TodayNow = DateTime.Now;
            nowDay = TodayNow.Day.ToString();
            nowDayInt = int.Parse(nowDay);

            //現在の日付から最後に料理日記を書いた日付を引く
            day = nowDayInt - lastDayInt;

            int petPoint = PlayerPrefs.GetInt("WHAT_PET");

            //dayが3日以上空いていたら
            if ((day > 3) || (day < -27))
            {
                //アニメを衰弱状態にする
                animator.SetBool("isBad", true);
                petPoint=13;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();

            } else {
                //アニメを元に戻す
                animator.SetBool("isBad", false);
                petPoint = 12;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }

            //肉中心の時
            if ((score >= 5) && (meatBard > 20.0f)){
                animator.SetBool("isMeat", true);
                petPoint = 14;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else if ((score >= 5) && (vegetableBard > 20.0f)){ //野菜中心の時
                animator.SetBool("isVegetable", true);
                petPoint = 15;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else if ((score >= 5) && (carboBard > 20.0f)){ //炭水化物中心の時
                animator.SetBool("isCarbo", true);
                petPoint = 16;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            } else if (score >= 5){ //バランスが良い時
                animator.SetBool("isGood", true);
                petPoint = 17;
                PlayerPrefs.SetInt("WHAT_PET", petPoint);
                PlayerPrefs.Save();
            }
        }
    }
}
