using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    //�C���X�y�N�^�[�E�B���h�E����Q�[���I�u�W�F�N�g��ݒ肷��
    [SerializeField] GameObject ItemPanel_f; //�Ƌ�̕��̃A�C�e���p�l��
    public GameObject buttonComplete_f; //�Ƌ�̕��̊����{�^��
    [SerializeField] GameObject ItemPanel_a; //�A�N�Z�̕��̃A�C�e���p�l��
    public GameObject buttonComplete_a; //�A�N�Z�̕��̊����{�^��

    // public�Ő錾���Ainspector�Őݒ�\�ɂ���
    //���̉摜�ɕύX����
    public Sprite Sprite_f1;
    public Sprite Sprite_f2;

    //�ǂ̃{�^���̉摜��
    public Image image_f1;
    public Image image_f2;


    // Start is called before the first frame update
    void Start()
    {
        ItemPanel_f.SetActive(false);
        buttonComplete_f.SetActive(false);
        ItemPanel_a.SetActive(false);
        buttonComplete_a.SetActive(false);

        //�uSCORE�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int score = PlayerPrefs.GetInt("SCORE");
        Debug.Log(" �������L���������񐔂�" + score);

        if (score >= 1)
        {
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f1.sprite = Sprite_f1;
        }
        if (score >= 5)
        {
            image_f2.sprite = Sprite_f2;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Button�������ꂽ�Ƃ��̏���
    //ItemPanel���A�N�e�B�u�ɂ���
    //�Ƌ�p�l���̕�
    public void AccessItem_f()
    {
        ItemPanel_f.SetActive(true);
    }
    public void back_f()
    {
        ItemPanel_f.SetActive(false);
    }
    public void directItem_f()
    {
        buttonComplete_f.SetActive(true);
        ItemPanel_f.SetActive(false);
    }
    public void back2_f()
    {
        buttonComplete_f.SetActive(false);
    }

    //Button�������ꂽ�Ƃ��̏���
    //ItemPanel���A�N�e�B�u�ɂ���
    //�A�N�Z�p�l���̕�
    public void AccessItem_a()
    {
        ItemPanel_a.SetActive(true);
    }
    public void back_a()
    {
        ItemPanel_a.SetActive(false);
    }
    public void directItem_a()
    {
        buttonComplete_a.SetActive(true);
        ItemPanel_a.SetActive(false);
    }
    public void back2_a()
    {
        buttonComplete_a.SetActive(false);
    }

}
