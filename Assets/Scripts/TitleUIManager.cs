using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleUIManager : MonoBehaviour
{
    //2��Panel���i�[����ϐ�
    //�C���X�y�N�^�[�E�B���h�E����Q�[���I�u�W�F�N�g��ݒ肷��
    [SerializeField] GameObject TitlePanel;
    [SerializeField] GameObject MenuPanel;


    // Start is called before the first frame update
    void Start()
    {
        //BackToMenu���\�b�h���Ăяo��
        BackToMenu();
    }

    //mainPanel��setteiButton�������ꂽ�Ƃ��̏���
    //menuPanel���A�N�e�B�u�ɂ���
    public void SelectMenuDescription()
    {
        TitlePanel.SetActive(false);
        MenuPanel.SetActive(true);
    }

    //2��DescriptionPanel��BackButton�������ꂽ�Ƃ��̏���
    //MenuPanel���A�N�e�B�u�ɂ���
    public void BackToMenu()
    {
        TitlePanel.SetActive(true);
        MenuPanel.SetActive(false);
    }

}
