using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DogController : MonoBehaviour
{

    Animator animator;

    private string nowDay;

    private int nowDayInt;

    private int lastDayInt;

    private int day;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //現在の日付取得
        DateTime TodayNow = DateTime.Now;
        nowDay = TodayNow.Day.ToString();
        nowDayInt = int.Parse(nowDay);

        lastDayInt = int.Parse(ButtonManager.lastDay);
        
        //現在の日付から最後に料理日記を書いた日付を引く
        day = nowDayInt - lastDayInt;

        //dayが3日以上空いていたら
        if ((day > 3) || (day < -20))
        {
            //アニメを衰弱状態にする
            animator.SetBool("isBad", true);
        } else {
            //アニメを元に戻す
            animator.SetBool("isBad", true);
        }

    }
}
