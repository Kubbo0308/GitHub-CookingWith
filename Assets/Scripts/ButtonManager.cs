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
    public GameObject buttonTitle;
    private string lastDay;
    private int lastInt;
    //最初はイヌ以外オフにする
    public static bool dog;
    public static bool cat;
    public static bool bard;
    public static bool rabbit;
    public GameObject Dog;
    public GameObject Cat;
    public GameObject Bard;
    public GameObject Rabbit;

    //�B�e���Ɍ����{�^��

    // Start is called before the first frame update
    void Start()
    {
        lastInt = PlayerPrefs.GetInt("LAST", 0);
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

    public void bkTitleButton()
    {
        //�ӂꂠ����ʂ�
        SceneManager.LoadScene("TrueTitleScene");
    }

    public void SaveButton() //保存ボタン押されたときの日付取得
    {
        DateTime TodayNow = DateTime.Now;
        lastDay = TodayNow.Day.ToString();
        lastInt = int.Parse(lastDay);
        PlayerPrefs.SetInt("LAST", lastInt);
        Debug.Log("現在の日付" + lastInt);
    }

    public void DogButton() //イヌ以外非表示
    {
        dog = true;
        cat = false;
        bard = false;
        rabbit = false;

        Dog.SetActive(true);
        Cat.SetActive(false);
        Bard.SetActive(false);
        Rabbit.SetActive(false);
    }

    public void CatButton() //ネコ以外非表示
    {
        dog = false;
        cat = true;
        bard = false;
        rabbit = false;

        Dog.SetActive(false);
        Cat.SetActive(true);
        Bard.SetActive(false);
        Rabbit.SetActive(false);
    }

    public void BardButton()　//トリ以外非表示
    {
        dog = false;
        cat = false;
        bard = true;
        rabbit = false;

        Dog.SetActive(false);
        Cat.SetActive(false);
        Bard.SetActive(true);
        Rabbit.SetActive(false);
    }

    public void RabbitButton() //ウサギ以外非表示
    {
        dog = false;
        cat = false;
        bard = false;
        rabbit = true;

        Dog.SetActive(false);
        Cat.SetActive(false);
        Bard.SetActive(false);
        Rabbit.SetActive(true);
    }

}
