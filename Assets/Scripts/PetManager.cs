using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetManager : MonoBehaviour
{
    //�y�b�g�̉摜
    public Sprite Sprite_dog, Sprite_cat, Sprite_bird, Sprite_rabbit;
    public Sprite Sprite_dog1, Sprite_cat1, Sprite_bird1, Sprite_rabbit1;
    public Sprite Sprite_dog2, Sprite_cat2, Sprite_bird2, Sprite_rabbit2;
    public Sprite Sprite_dog3, Sprite_cat3, Sprite_bird3, Sprite_rabbit3;
    public Sprite Sprite_dog4, Sprite_cat4, Sprite_bird4, Sprite_rabbit4;
    public Sprite Sprite_dog5, Sprite_cat5, Sprite_bird5, Sprite_rabbit5;
    public Image image_pet;  //�I����ʂ̃y�b�g�摜
    public Image image_pet2; //���O���͉�ʂ̃y�b�g�摜
    public Image image_pet3; //�z�[����ʂɑ؍݂���y�b�g�摜

    public Image image_pet4; //�I����ʂ̃y�b�g�摜2
    public Image image_pet5; //���O���͉�ʂ̃y�b�g�摜2

    //�A�N�Z�̉摜
    //���̉摜�ɕύX����
    public Sprite Sprite_boushi1, Sprite_kubiwa1, Sprite_megane1;
    public Sprite Sprite_boushi2, Sprite_kubiwa2, Sprite_megane2;
    public Sprite Sprite_boushi3, Sprite_kubiwa3, Sprite_megane3;
    //�ǂ̉摜��ύX����H
    public Image image_boushi, image_kubiwa,image_megane;

    [SerializeField] GameObject SelectPetPanel;
    [SerializeField] GameObject SelectPetPanel2;
    [SerializeField] GameObject NamePetPanel;
    [SerializeField] GameObject NamePetPanel2;

    public GameObject SelectButton_right;
    public GameObject SelectButton_left;
    public GameObject SelectButton_right2;
    public GameObject SelectButton_left2;
    public GameObject DecisionButton;

    public Text petText;
    public Text petText2;

    int whatpet = 0;

    // Start is called before the first frame update
    void Start()
    {
        SelectPetPanel.SetActive(false); //�ŏ��͔�\��
        SelectPetPanel2.SetActive(false); //�ŏ��͔�\��
        NamePetPanel.SetActive(false); //�ŏ��͔�\��
        NamePetPanel2.SetActive(false); //�ŏ��͔�\��

        //�uSTART�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int start = PlayerPrefs.GetInt("START");
        //�uDECISION�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int decision = PlayerPrefs.GetInt("DECISION");

        Debug.Log("�^�C�g������X�^�[�g�{�^�����������񐔂�" + start);
        Debug.Log("���݃y�b�g��V�����I�����Ă��邩�ǂ����̏�Ԃ�" + decision);

        if (start == 1 && decision == 0)
        {
            image_pet3.enabled = false; //�ŏ��͔�\��
            SelectPetPanel.SetActive(true); //�\��
            SelectButton_left.SetActive(false); //�ŏ��͔�\��
        }

        //�uWHAT_PET�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int pet = PlayerPrefs.GetInt("WHAT_PET");
        Debug.Log("�琬���̃y�b�g��" + pet);

        //�������������ꍇ
        if (pet == 2 || pet == 3 || pet == 4 || pet == 5 || pet == 8 || pet == 9 || pet == 10 || pet == 11 || pet == 14 || pet == 15 || pet == 16 || pet == 17 || pet == 20 || pet == 21 || pet == 22 || pet == 23)
        {
            SelectPetPanel2.SetActive(true); //�\��
            SelectButton_left2.SetActive(false); //�ŏ��͔�\��
        }

        if (pet == 0)
        {
            image_pet3.sprite = Sprite_dog;
        }
        if (pet == 1)
        {
            image_pet3.sprite = Sprite_dog1;
        }
        if (pet == 2)
        {
            image_pet3.sprite = Sprite_dog2;
        }
        if (pet == 3)
        {
            image_pet3.sprite = Sprite_dog3;
        }
        if (pet == 4)
        {
            image_pet3.sprite = Sprite_dog4;
        }
        if (pet == 5)
        {
            image_pet3.sprite = Sprite_dog5;
        }
        if (pet == 6)
        {
            image_pet3.sprite = Sprite_cat;
        }
        if (pet == 7)
        {
            image_pet3.sprite = Sprite_cat1;
        }
        if (pet == 8)
        {
            image_pet3.sprite = Sprite_cat2;
        }
        if (pet == 9)
        {
            image_pet3.sprite = Sprite_cat3;
        }
        if (pet == 10)
        {
            image_pet3.sprite = Sprite_cat4;
        }
        if (pet == 11)
        {
            image_pet3.sprite = Sprite_cat5;
        }
        if (pet == 12)
        {
            image_pet3.sprite = Sprite_bird;
        }
        if (pet == 13)
        {
            image_pet3.sprite = Sprite_bird1;
        }
        if (pet == 14)
        {
            image_pet3.sprite = Sprite_bird2;
        }
        if (pet == 15)
        {
            image_pet3.sprite = Sprite_bird3;
        }
        if (pet == 16)
        {
            image_pet3.sprite = Sprite_bird4;
        }
        if (pet == 17)
        {
            image_pet3.sprite = Sprite_bird5;
        }
        if (pet == 18)
        {
            image_pet3.sprite = Sprite_rabbit;
        }
        if (pet == 19)
        {
            image_pet3.sprite = Sprite_rabbit1;
        }
        if (pet == 20)
        {
            image_pet3.sprite = Sprite_rabbit2;
        }
        if (pet == 21)
        {
            image_pet3.sprite = Sprite_rabbit3;
        }
        if (pet == 22)
        {
            image_pet3.sprite = Sprite_rabbit4;
        }
        if (pet == 23)
        {
            image_pet3.sprite = Sprite_rabbit5;
        }

        //�uAccessory_�����v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int Accessory_b = PlayerPrefs.GetInt("Accessory_b"); //�X�q����̂��߂̕ϐ�
        int Accessory_k = PlayerPrefs.GetInt("Accessory_k"); //��֒�̂��߂̕ϐ�
        int Accessory_m = PlayerPrefs.GetInt("Accessory_m"); //�ዾ����̂��߂̕ϐ�

        Debug.Log(" ���I������Ă���X�q��" + Accessory_b);
        Debug.Log(" ���I������Ă����ւ�" + Accessory_k);
        Debug.Log(" ���I������Ă���ዾ��" + Accessory_m);

        image_boushi.enabled = false; //�ŏ��͔�\��
        image_kubiwa.enabled = false; //�ŏ��͔�\��
        image_megane.enabled = false; //�ŏ��͔�\��

        //furniture(�ǂ̕ǎ���I�����Ă��邩)�ŕǎ��ύX
        if (Accessory_b == 1)
        {
            image_boushi.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_boushi.sprite = Sprite_boushi1;
        }
        if (Accessory_b == 2)
        {
            image_boushi.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_boushi.sprite = Sprite_boushi2;
        }
        if (Accessory_b == 3)
        {
            image_boushi.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_boushi.sprite = Sprite_boushi3;
        }
        if (Accessory_k == 1)
        {
            image_kubiwa.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_kubiwa.sprite = Sprite_kubiwa1;
        }
        if (Accessory_k == 2)
        {
            image_kubiwa.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_kubiwa.sprite = Sprite_kubiwa2;
        }
        if (Accessory_k == 3)
        {
            image_kubiwa.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_kubiwa.sprite = Sprite_kubiwa3;
        }
        if (Accessory_m == 1)
        {
            image_megane.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_megane.sprite = Sprite_megane1;
        }
        if (Accessory_m == 2)
        {
            image_megane.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_megane.sprite = Sprite_megane2;
        }
        if (Accessory_m == 3)
        {
            image_megane.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_megane.sprite = Sprite_megane3;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    //�O�p�{�^��(�E)�������ꂽ�Ƃ�
    public void SelectPet_right()
    {
        whatpet++;
        if (whatpet == 1)
        {
            image_pet.sprite = Sprite_cat;
            SelectButton_right.SetActive(true);
            SelectButton_left.SetActive(true);
            petText.text = "�l�R";
        }
        else if (whatpet == 2)
        {
            image_pet.sprite = Sprite_bird;
            SelectButton_right.SetActive(true);
            petText.text = "�g��";
        }
        else if (whatpet == 3)
        {
            image_pet.sprite = Sprite_rabbit;
            SelectButton_right.SetActive(false);
            petText.text = "�E�T�M";
        }
    }

    //�O�p�{�^��(��)�������ꂽ�Ƃ�
    public void SelectPet_left()
    {
        whatpet--;
        if (whatpet == 0)
        {
            SelectButton_left.SetActive(false);
            image_pet.sprite = Sprite_dog;
            petText.text = "�C�k";
        }
        else if (whatpet == 1)
        {
            SelectButton_right.SetActive(true);
            image_pet.sprite = Sprite_cat;
            petText.text = "�l�R";
        }
        else if (whatpet == 2)
        {
            SelectButton_right.SetActive(true);
            image_pet.sprite = Sprite_bird;
            petText.text = "�g��";
        }
    }

    //�O�p�{�^��(�E)�������ꂽ�Ƃ�
    public void SelectPet_right2()
    {
        whatpet++;
        if (whatpet == 1)
        {
            image_pet4.sprite = Sprite_cat;
            SelectButton_right2.SetActive(true);
            SelectButton_left2.SetActive(true);
            petText2.text = "�l�R";
        }
        else if (whatpet == 2)
        {
            image_pet4.sprite = Sprite_bird;
            SelectButton_right2.SetActive(true);
            petText2.text = "�g��";
        }
        else if (whatpet == 3)
        {
            image_pet4.sprite = Sprite_rabbit;
            SelectButton_right2.SetActive(false);
            petText2.text = "�E�T�M";
        }
    }

    //�O�p�{�^��(��)�������ꂽ�Ƃ�
    public void SelectPet_left2()
    {
        whatpet--;
        if (whatpet == 0)
        {
            SelectButton_left2.SetActive(false);
            image_pet4.sprite = Sprite_dog;
            petText2.text = "�C�k";
        }
        else if (whatpet == 1)
        {
            SelectButton_right2.SetActive(true);
            image_pet4.sprite = Sprite_cat;
            petText2.text = "�l�R";
        }
        else if (whatpet == 2)
        {
            SelectButton_right2.SetActive(true);
            image_pet4.sprite = Sprite_bird;
            petText2.text = "�g��";
        }
    }

    public void NamePet()
    {
        SelectPetPanel.SetActive(false);
        NamePetPanel.SetActive(true);

        if (whatpet == 0)
        {
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_pet2.sprite = Sprite_dog;
        }
        else if (whatpet == 1)
        {
            image_pet2.sprite = Sprite_cat;
        }
        else if (whatpet == 2)
        {
            image_pet2.sprite = Sprite_bird;
        }
        else if (whatpet == 3)
        {
            image_pet2.sprite = Sprite_rabbit;
        }

    }
    public void NamePet2()
    {
        SelectPetPanel2.SetActive(false);
        NamePetPanel2.SetActive(true);

        if (whatpet == 0)
        {
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_pet5.sprite = Sprite_dog;
        }
        else if (whatpet == 1)
        {
            image_pet5.sprite = Sprite_cat;
        }
        else if (whatpet == 2)
        {
            image_pet5.sprite = Sprite_bird;
        }
        else if (whatpet == 3)
        {
            image_pet5.sprite = Sprite_rabbit;
        }

    }
    public void back()
    {
        SelectPetPanel2.SetActive(false);
    }
    public void back_pet()
    {
        SelectPetPanel.SetActive(true);
        NamePetPanel.SetActive(false);
    }
    public void back_pet2()
    {
        SelectPetPanel2.SetActive(true);
        NamePetPanel2.SetActive(false);
    }
    public void decision_pet()
    {
        NamePetPanel.SetActive(false);
        image_pet3.enabled = true;

        //�I�������ꍇ��decision��1�ɐݒ肷��
        int decision = PlayerPrefs.GetInt("DECISION");
        decision = 1;
        PlayerPrefs.SetInt("DECISION", decision);
        PlayerPrefs.Save();

        //�uSCORE�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int score = PlayerPrefs.GetInt("SCORE");
        score = 0;
        PlayerPrefs.SetInt("SCORE", score);
        PlayerPrefs.Save();

        int Pet = PlayerPrefs.GetInt("WHAT_PET");

        if (whatpet == 0)
        {
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_pet3.sprite = Sprite_dog;

            Pet = 0;
            PlayerPrefs.SetInt("WHAT_PET", Pet);
            PlayerPrefs.Save();
        }
        else if (whatpet == 1)
        {
            image_pet3.sprite = Sprite_cat;

            Pet = 6;
            PlayerPrefs.SetInt("WHAT_PET", Pet);
            PlayerPrefs.Save();
        }
        else if (whatpet == 2)
        {
            image_pet3.sprite = Sprite_bird;
            Pet = 12;
            PlayerPrefs.SetInt("WHAT_PET", Pet);
            PlayerPrefs.Save();
        }
        else if (whatpet == 3)
        {
            image_pet3.sprite = Sprite_rabbit;

            Pet = 18;
            PlayerPrefs.SetInt("WHAT_PET", Pet);
            PlayerPrefs.Save();
        }
    }

    public void decision_pet2()
    {
        NamePetPanel2.SetActive(false);
        image_pet3.enabled = true;

        //�I�������ꍇ��decision��1�ɐݒ肷��
        int decision = PlayerPrefs.GetInt("DECISION");
        decision = 1;
        PlayerPrefs.SetInt("DECISION", decision);
        PlayerPrefs.Save();

        int PointPet = PlayerPrefs.GetInt("POINT");
        PointPet = 0;
        PlayerPrefs.SetInt("POINT", PointPet);
        PlayerPrefs.Save();

        int Pet = PlayerPrefs.GetInt("WHAT_PET");

        if (whatpet == 0)
        {
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_pet3.sprite = Sprite_dog;

            Pet = 0;
            PlayerPrefs.SetInt("WHAT_PET", Pet);
            PlayerPrefs.Save();
        }
        else if (whatpet == 1)
        {
            image_pet3.sprite = Sprite_cat;

            Pet = 6;
            PlayerPrefs.SetInt("WHAT_PET", Pet);
            PlayerPrefs.Save();
        }
        else if (whatpet == 2)
        {
            image_pet3.sprite = Sprite_bird;
            Pet = 12;
            PlayerPrefs.SetInt("WHAT_PET", Pet);
            PlayerPrefs.Save();
        }
        else if (whatpet == 3)
        {
            image_pet3.sprite = Sprite_rabbit;

            Pet = 18;
            PlayerPrefs.SetInt("WHAT_PET", Pet);
            PlayerPrefs.Save();
        }
    }
}
