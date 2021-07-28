using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RabbitController : MonoBehaviour
{
    Animator animator;

    private string nowDay;

    private int nowDayInt;

    private int lastDayInt;

    private int day;

    private float meatRabbit;
    private float vegetableRabbit;
    private float carboRabbit;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //「SCORE」というキーで保存されているInt値を読み込み
        score = PlayerPrefs.GetInt("SCORE");

        //保存されている3つのパラメータのFloat値を読み込み
        meatRabbit = PlayerPrefs.GetFloat("MEATRABBIT", 0);
        vegetableRabbit = PlayerPrefs.GetFloat("VEGETABLERABBIT", 0);
        carboRabbit = PlayerPrefs.GetFloat("CARBORABBIT", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonManager.rabbit) {
            //現在の日付取得
            DateTime TodayNow = DateTime.Now;
            nowDay = TodayNow.Day.ToString();
            nowDayInt = int.Parse(nowDay);

            //料理日記を１回以上書いたら過去の料理日記を書いた時間を持ってくる
            if(score >= 1){
                lastDayInt = ButtonManager.lastInt;
            }
            
            //現在の日付から最後に料理日記を書いた日付を引く
            day = nowDayInt - lastDayInt;

            //dayが3日以上空いていたら
            if ((day > 3) || (day < -27))
            {
                //アニメを衰弱状態にする
                animator.SetBool("isBad", true);
            } else {
                //アニメを元に戻す
                animator.SetBool("isBad", false);
            }

            //肉中心の時
            if ((score >= 5) && (meatRabbit > 20.0f)){
                animator.SetBool("isMeat", true);
            } else if ((score >= 5) && (vegetableRabbit > 20.0f)){ //野菜中心の時
                animator.SetBool("isVegetable", true);
            } else if ((score >= 5) && (carboRabbit > 20.0f)){ //炭水化物中心の時
                animator.SetBool("isCarbo", true);
            } else if (score >= 5){ //バランスが良い時
                animator.SetBool("isGood", true);
            }
        }
    }
}
