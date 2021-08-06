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
    public GameObject buttonStart;
    public GameObject buttonSettei;


    // Start is called before the first frame update
    void Start()
    {
        //BackToMenu���\�b�h���Ăяo��
        BackToMenu();
    }

    //TitlePanel��Button�������ꂽ�Ƃ��̏���
    //MenuPanel���A�N�e�B�u�ɂ���
    public void SelectMenuDescription()
    {
        TitlePanel.SetActive(false);
        MenuPanel.SetActive(true);
    }

    //MenuPanel��BackButton�������ꂽ�Ƃ��̏���
    //TitlePanel���A�N�e�B�u�ɂ���
    public void BackToMenu()
    {
        TitlePanel.SetActive(true);
        MenuPanel.SetActive(false);
    }

    //�X�^�[�g�{�^�����������Ƃ�
    public void PushStart()
    {
        //�uSTART�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int StartPoint = PlayerPrefs.GetInt("START");
        //�uDECISION�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int decision = PlayerPrefs.GetInt("DECISION");

        //���߂ăX�^�[�g�{�^�����������ꍇ
        if (StartPoint == 0)
        {
            StartPoint++; //������ς����(StartPoint = 1�Ƃ�)�e�X�g�ł���
            PlayerPrefs.SetInt("START", StartPoint);
            PlayerPrefs.Save();

            //�ŏ���decision��0�ɐݒ肵�Ă���
            decision = 0;
            PlayerPrefs.SetInt("DECISION", decision);
            PlayerPrefs.Save();
        }
        if (decision != 0)
        {
            StartPoint++;
            PlayerPrefs.SetInt("START", StartPoint);
            PlayerPrefs.Save();
        }
    }

}
