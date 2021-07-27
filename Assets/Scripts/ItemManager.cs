using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    //�C���X�y�N�^�[�E�B���h�E����Q�[���I�u�W�F�N�g��ݒ肷��
    //�Ƌ�̕��̃A�C�e���p�l��
    [SerializeField] GameObject ItemPanel_f1, ItemPanel_f2, ItemPanel_f3, ItemPanel_f4;
    [SerializeField] GameObject ItemPanel_f5, ItemPanel_f6, ItemPanel_f7, ItemPanel_f8;
    [SerializeField] GameObject ItemPanel_f9, ItemPanel_f10, ItemPanel_f11, ItemPanel_f12;
    [SerializeField] GameObject ItemPanel_f13, ItemPanel_f14, ItemPanel_f15, ItemPanel_f16;
    [SerializeField] GameObject ItemPanel_f17, ItemPanel_f18, ItemPanel_f19, ItemPanel_f20;
    [SerializeField] GameObject ItemPanel_f21, ItemPanel_f22, ItemPanel_f23, ItemPanel_f24;

    public GameObject buttonComplete_f; //�Ƌ�̕��̊����{�^��
    [SerializeField] GameObject ItemPanel_a; //�A�N�Z�̕��̃A�C�e���p�l��
    public GameObject buttonComplete_a; //�A�N�Z�̕��̊����{�^��

    //�Ƌ�̕��̖߂�{�^��
    public GameObject bkbutton_f1, bkbutton_f2, bkbutton_f3, bkbutton_f4;
    public GameObject bkbutton_f5, bkbutton_f6, bkbutton_f7, bkbutton_f8;
    public GameObject bkbutton_f9, bkbutton_f10, bkbutton_f11, bkbutton_f12;
    public GameObject bkbutton_f13, bkbutton_f14, bkbutton_f15, bkbutton_f16;
    public GameObject bkbutton_f17, bkbutton_f18, bkbutton_f19, bkbutton_f20;
    public GameObject bkbutton_f21, bkbutton_f22, bkbutton_f23, bkbutton_f24;


    //�Ƌ�̕��̔z�u�{�^��
    public GameObject drbutton_f1, drbutton_f2, drbutton_f3, drbutton_f4;
    public GameObject drbutton_f5, drbutton_f6, drbutton_f7, drbutton_f8;
    public GameObject drbutton_f9, drbutton_f10, drbutton_f11, drbutton_f12;
    public GameObject drbutton_f13, drbutton_f14, drbutton_f15, drbutton_f16;
    public GameObject drbutton_f17, drbutton_f18, drbutton_f19, drbutton_f20;
    public GameObject drbutton_f21, drbutton_f22, drbutton_f23, drbutton_f24;

    public GameObject bkbutton_a; //�A�N�Z�̕��̖߂�{�^��
    public GameObject drbutton_a; //�A�N�Z�̕��̔z�u�{�^��

    // public�Ő錾���Ainspector�Őݒ�\�ɂ���
    //���̉摜�ɕύX����
    public Sprite Sprite_f1, Sprite_f2, Sprite_f3, Sprite_f4, Sprite_f5;
    public Sprite Sprite_f6, Sprite_f7, Sprite_f8, Sprite_f9, Sprite_f10;
    public Sprite Sprite_f11, Sprite_f12, Sprite_f13, Sprite_f14, Sprite_f15;
    public Sprite Sprite_f16, Sprite_f17, Sprite_f18, Sprite_f19, Sprite_f20;
    public Sprite Sprite_f21, Sprite_f22, Sprite_f23, Sprite_f24;

    public Sprite Sprite_a1, Sprite_a2, Sprite_a3, Sprite_a4, Sprite_a5;
    public Sprite Sprite_a6, Sprite_a7, Sprite_a8, Sprite_a9, Sprite_a10;
    public Sprite Sprite_a11, Sprite_a12, Sprite_a13, Sprite_a14, Sprite_a15;
    public Sprite Sprite_a16, Sprite_a17, Sprite_a18, Sprite_a19, Sprite_20;
    public Sprite Sprite_a21, Sprite_a22, Sprite_a23, Sprite_a24, Sprite_a25;
    public Sprite Sprite_a26, Sprite_a27, Sprite_a28, Sprite_a29, Sprite_a30;
    public Sprite Sprite_a31, Sprite_a32, Sprite_a33, Sprite_a34, Sprite_a35, Sprite_a36;

    //�ǂ̃{�^���̉摜��
    public Image image_f1, image_f2, image_f3, image_f4, image_f5;
    public Image image_f6, image_f7, image_f8, image_f9, image_f10;
    public Image image_f11, image_f12, image_f13, image_f14, image_f15;
    public Image image_f16, image_f17, image_f18, image_f19, image_f20;
    public Image image_f21, image_f22, image_f23, image_f24;

    public Image image_a1, image_a2, image_a3, image_a4, image_a5;
    public Image image_a6, image_a7, image_a8, image_a9, image_a10;
    public Image image_a11, image_a12, image_a13, image_a14, image_a15;
    public Image image_a16, image_a17, image_a18, image_a19, image_a20;
    public Image image_a21, image_a22, image_a23, image_a24, image_a25;
    public Image image_a26, image_a27, image_a28, image_a29, image_a30;
    public Image image_a31, image_a32, image_a33, image_a34, image_a35, image_a36;


    // Start is called before the first frame update
    void Start()
    {
        ItemPanel_f1.SetActive(false);
        ItemPanel_f2.SetActive(false);
        ItemPanel_f3.SetActive(false);
        ItemPanel_f4.SetActive(false);
        ItemPanel_f5.SetActive(false);
        ItemPanel_f6.SetActive(false);
        ItemPanel_f7.SetActive(false);
        ItemPanel_f8.SetActive(false);
        ItemPanel_f9.SetActive(false);
        ItemPanel_f10.SetActive(false);
        ItemPanel_f11.SetActive(false);
        ItemPanel_f12.SetActive(false);
        ItemPanel_f13.SetActive(false);
        ItemPanel_f14.SetActive(false);
        ItemPanel_f15.SetActive(false);
        ItemPanel_f16.SetActive(false);
        ItemPanel_f17.SetActive(false);
        ItemPanel_f18.SetActive(false);
        ItemPanel_f19.SetActive(false);
        ItemPanel_f20.SetActive(false);
        ItemPanel_f21.SetActive(false);
        ItemPanel_f22.SetActive(false);
        ItemPanel_f23.SetActive(false);
        ItemPanel_f24.SetActive(false);

        buttonComplete_f.SetActive(false);
        ItemPanel_a.SetActive(false);
        buttonComplete_a.SetActive(false);

        //�uSCORE�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int score = PlayerPrefs.GetInt("SCORE");
        Debug.Log(" �������L���������񐔂�" + score);

        //score(�������L����������)������ȏ�ŃA�C�e�����
        if (score >= 1)
        {
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f1.sprite = Sprite_f1;
        }
        if (score >= 3)
        {
            image_f2.sprite = Sprite_f2;
        }
        if (score >= 5)
        {
            image_f3.sprite = Sprite_f3;
            image_a1.sprite = Sprite_a1;
        }
        if (score >= 7)
        {
            image_f4.sprite = Sprite_f4;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Button�������ꂽ�Ƃ��̏���
    //ItemPanel���A�N�e�B�u�ɂ���
    //�Ƌ�p�l���̕�
    public void AccessItem_f(int number)
    {
        switch (number)
        {
            case 0:
                ItemPanel_f1.SetActive(true);
                bkbutton_f1.SetActive(true);
                drbutton_f1.SetActive(true);
                break;
            case 1:
                ItemPanel_f2.SetActive(true);
                bkbutton_f2.SetActive(true);
                drbutton_f2.SetActive(true);
                break;
            case 2:
                ItemPanel_f3.SetActive(true);
                bkbutton_f3.SetActive(true);
                drbutton_f3.SetActive(true);
                break;
            case 3:
                ItemPanel_f4.SetActive(true);
                bkbutton_f4.SetActive(true);
                drbutton_f4.SetActive(true);
                break;
            case 4:
                ItemPanel_f5.SetActive(true);
                bkbutton_f5.SetActive(true);
                drbutton_f5.SetActive(true);
                break;
            case 5:
                ItemPanel_f6.SetActive(true);
                bkbutton_f6.SetActive(true);
                drbutton_f6.SetActive(true);
                break;
            case 6:
                ItemPanel_f7.SetActive(true);
                bkbutton_f7.SetActive(true);
                drbutton_f7.SetActive(true);
                break;
            case 7:
                ItemPanel_f8.SetActive(true);
                bkbutton_f8.SetActive(true);
                drbutton_f8.SetActive(true);
                break;
            case 8:
                ItemPanel_f9.SetActive(true);
                bkbutton_f9.SetActive(true);
                drbutton_f9.SetActive(true);
                break;
            case 9:
                ItemPanel_f10.SetActive(true);
                bkbutton_f10.SetActive(true);
                drbutton_f10.SetActive(true);
                break;
            case 10:
                ItemPanel_f11.SetActive(true);
                bkbutton_f11.SetActive(true);
                drbutton_f11.SetActive(true);
                break;
            case 11:
                ItemPanel_f12.SetActive(true);
                bkbutton_f12.SetActive(true);
                drbutton_f12.SetActive(true);
                break;
            case 12:
                ItemPanel_f13.SetActive(true);
                bkbutton_f13.SetActive(true);
                drbutton_f13.SetActive(true);
                break;
            case 13:
                ItemPanel_f14.SetActive(true);
                bkbutton_f14.SetActive(true);
                drbutton_f14.SetActive(true);
                break;
            case 14:
                ItemPanel_f15.SetActive(true);
                bkbutton_f15.SetActive(true);
                drbutton_f15.SetActive(true);
                break;
            case 15:
                ItemPanel_f16.SetActive(true);
                bkbutton_f16.SetActive(true);
                drbutton_f16.SetActive(true);
                break;
            case 16:
                ItemPanel_f17.SetActive(true);
                bkbutton_f17.SetActive(true);
                drbutton_f17.SetActive(true);
                break;
            case 17:
                ItemPanel_f18.SetActive(true);
                bkbutton_f18.SetActive(true);
                drbutton_f18.SetActive(true);
                break;
            case 18:
                ItemPanel_f19.SetActive(true);
                bkbutton_f19.SetActive(true);
                drbutton_f19.SetActive(true);
                break;
            case 19:
                ItemPanel_f20.SetActive(true);
                bkbutton_f20.SetActive(true);
                drbutton_f20.SetActive(true);
                break;
            case 20:
                ItemPanel_f21.SetActive(true);
                bkbutton_f21.SetActive(true);
                drbutton_f21.SetActive(true);
                break;
            case 21:
                ItemPanel_f22.SetActive(true);
                bkbutton_f22.SetActive(true);
                drbutton_f22.SetActive(true);
                break;
            case 22:
                ItemPanel_f23.SetActive(true);
                bkbutton_f23.SetActive(true);
                drbutton_f23.SetActive(true);
                break;
            case 23:
                ItemPanel_f24.SetActive(true);
                bkbutton_f24.SetActive(true);
                drbutton_f24.SetActive(true);
                break;

        }

    }
    public void back_f()
    {
        ItemPanel_f1.SetActive(false);
        ItemPanel_f2.SetActive(false);
        ItemPanel_f3.SetActive(false);
        ItemPanel_f4.SetActive(false);
        ItemPanel_f5.SetActive(false);
        ItemPanel_f6.SetActive(false);
        ItemPanel_f7.SetActive(false);
        ItemPanel_f8.SetActive(false);
        ItemPanel_f9.SetActive(false);
        ItemPanel_f10.SetActive(false);
        ItemPanel_f11.SetActive(false);
        ItemPanel_f12.SetActive(false);
        ItemPanel_f13.SetActive(false);
        ItemPanel_f14.SetActive(false);
        ItemPanel_f15.SetActive(false);
        ItemPanel_f16.SetActive(false);
        ItemPanel_f17.SetActive(false);
        ItemPanel_f18.SetActive(false);
        ItemPanel_f19.SetActive(false);
        ItemPanel_f20.SetActive(false);
        ItemPanel_f21.SetActive(false);
        ItemPanel_f22.SetActive(false);
        ItemPanel_f23.SetActive(false);
        ItemPanel_f24.SetActive(false);
    }
    public void directItem_f()
    {
        buttonComplete_f.SetActive(true); //�z�u���܂������b�Z�[�W
        ItemPanel_f1.SetActive(false);
        ItemPanel_f2.SetActive(false);
        ItemPanel_f3.SetActive(false);
        ItemPanel_f4.SetActive(false);
        ItemPanel_f5.SetActive(false);
        ItemPanel_f6.SetActive(false);
        ItemPanel_f7.SetActive(false);
        ItemPanel_f8.SetActive(false);
        ItemPanel_f9.SetActive(false);
        ItemPanel_f10.SetActive(false);
        ItemPanel_f11.SetActive(false);
        ItemPanel_f12.SetActive(false);
        ItemPanel_f13.SetActive(false);
        ItemPanel_f14.SetActive(false);
        ItemPanel_f15.SetActive(false);
        ItemPanel_f16.SetActive(false);
        ItemPanel_f17.SetActive(false);
        ItemPanel_f18.SetActive(false);
        ItemPanel_f19.SetActive(false);
        ItemPanel_f20.SetActive(false);
        ItemPanel_f21.SetActive(false);
        ItemPanel_f22.SetActive(false);
        ItemPanel_f23.SetActive(false);
        ItemPanel_f24.SetActive(false);
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
        bkbutton_a.SetActive(true);
        drbutton_a.SetActive(true);
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