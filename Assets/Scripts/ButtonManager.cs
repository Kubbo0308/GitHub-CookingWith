using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
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

}
