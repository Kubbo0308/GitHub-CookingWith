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
    private string lastDay;
    private int lastInt;
    //最初はイヌ以外オフにする
     private string character;
    public GameObject Dog;
    public GameObject Cat;
    public GameObject Bard;
    public GameObject Rabbit;

    //�B�e���Ɍ����{�^��

    // Start is called before the first frame update
    void Start()
    {
        lastInt = PlayerPrefs.GetInt("LAST", 0);
        character = PlayerPrefs.GetString("CHARACTER");
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
        lastInt = int.Parse(lastDay);
        PlayerPrefs.SetInt("LAST", lastInt);
        Debug.Log("現在の日付" + lastInt);
    }

    public void DogButton() //イヌ以外非表示
    {
        Dog.SetActive(true);
        Cat.SetActive(false);
        Bard.SetActive(false);
        Rabbit.SetActive(false);

        character = "DOG";
        PlayerPrefs.SetString("CHARACTER", character);
        PlayerPrefs.Save();
        Debug.Log("現在のキャラクター" + character);
    }

    public void CatButton() //ネコ以外非表示
    {
        Dog.SetActive(false);
        Cat.SetActive(true);
        Bard.SetActive(false);
        Rabbit.SetActive(false);

        character = "CAT";
        PlayerPrefs.SetString("CHARACTER", character);
        PlayerPrefs.Save();
        Debug.Log("現在のキャラクター" + character);
    }

    public void BardButton()　//トリ以外非表示
    {
        Dog.SetActive(false);
        Cat.SetActive(false);
        Bard.SetActive(true);
        Rabbit.SetActive(false);

        character = "BARD";
        PlayerPrefs.SetString("CHARACTER", character);
        PlayerPrefs.Save();
        Debug.Log("現在のキャラクター" + character);
    }

    public void RabbitButton() //ウサギ以外非表示
    {
        Dog.SetActive(false);
        Cat.SetActive(false);
        Bard.SetActive(false);
        Rabbit.SetActive(true);

        character = "RABBIT";
        PlayerPrefs.SetString("CHARACTER", character);
        PlayerPrefs.Save();
        Debug.Log("現在のキャラクター" + character);
    }

}
