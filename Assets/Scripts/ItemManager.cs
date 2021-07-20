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
    public Sprite Sprite_f1, Sprite_f2, Sprite_f3, Sprite_f4, Sprite_f5;
    public Sprite Sprite_f6, Sprite_f7, Sprite_f8, Sprite_f9, Sprite_f10;
    public Sprite Sprite_f11, Sprite_f12, Sprite_f13, Sprite_f14, Sprite_f15;
    public Sprite Sprite_f16,Sprite_f17,Sprite_f18, Sprite_f19, Sprite_f20;
    public Sprite Sprite_f21, Sprite_f22, Sprite_f23, Sprite_f24;

    //�ǂ̃{�^���̉摜��
    public Image image_f1, image_f2, image_f3, image_f4, image_f5;
    public Image image_f6, image_f7, image_f8, image_f9, image_f10;
    public Image image_f11, image_f12, image_f13, image_f14, image_f15;
    public Image image_f16, image_f17, image_f18, image_f19, image_f20;
    public Image image_f21, image_f22, image_f23, image_f24;


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
