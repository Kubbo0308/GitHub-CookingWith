using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class ButtonManager : MonoBehaviour
{
    //���̃{�^���B
    public GameObject buttonHome;
    public GameObject buttonGoal;
    public GameObject buttonCooking;
    public GameObject buttonCharacter;
    public static string lastDay;

    //�B�e���Ɍ����{�^��

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GoTitleButton()
    {
        //�^�C�g����ʂ�
        SceneManager.LoadScene("TitleScene");
    }

    public void GoGoalButton()
    {
        //�ڕW��ʂ�
        SceneManager.LoadScene("GoalScene");
    }

    public void GoCookingButton()
    {
        //�������L��ʂ�
        SceneManager.LoadScene("CookingScene");
    }

    public void GoCharacterButton()
    {
        //�L������ʂ�
        SceneManager.LoadScene("CharacterScene");
    }

    public void GoFriendButton()
    {
        //�ӂꂠ����ʂ�
        SceneManager.LoadScene("FriendScene");
    }

    public void SaveButton() //保存ボタン押されたときの日付取得
    {
        DateTime TodayNow = DateTime.Now;
        lastDay = TodayNow.Day.ToString();
        Debug.Log("現在の日付" + lastDay);
    }


}
