using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class ButtonManager : MonoBehaviour
{
    //下のボタン達
    public GameObject buttonHome;
    public GameObject buttonGoal;
    public GameObject buttonCooking;
    public GameObject buttonCharacter;
    //撮影時に現れるボタン

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
        //タイトル画面へ
        SceneManager.LoadScene("TitleScene");
    }

    public void GoGoalButton()
    {
        //目標画面へ
        SceneManager.LoadScene("GoalScene");
    }

    public void GoCookingButton()
    {
        //料理日記画面へ
        SceneManager.LoadScene("CookingScene");
    }

    public void GoCharacterButton()
    {
        //キャラ画面へ
        SceneManager.LoadScene("CharacterScene");
    }

    public void GoFriendButton()
    {
        //ふれあい画面へ
        SceneManager.LoadScene("FriendScene");
    }

}
