using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Debug = UnityEngine.Debug;

public class PetManager : MonoBehaviour
{
    //�y�b�g�̉摜
    public Sprite Sprite_dog, Sprite_cat, Sprite_bird, Sprite_rabbit;
    public Sprite dog_Good, dog_Bad, dog_Meat, dog_Vegetable, dog_Carbo;
    public Sprite cat_Good, cat_Bad, cat_Meat, cat_Vegetable, cat_Carbo;
    public Sprite bird_Good, bird_Bad, bird_Meat, bird_Vegetable, bird_Carbo;
    public Sprite rabbit_Good, rabbit_Bad, rabbit_Meat, rabbit_Vegetable, rabbit_Carbo;
    public Image image_pet;
    public Image image_pet2; //���O���͉�ʂ̃y�b�g�摜
    public Image image_pet3; //�z�[����ʂɑ؍݂���y�b�g�摜

    //�A�N�Z�̉摜
    //���̉摜�ɕύX����
    public Sprite Sprite_boushi1, Sprite_kubiwa1, Sprite_megane1;
    public Sprite Sprite_boushi2, Sprite_kubiwa2, Sprite_megane2;
    public Sprite Sprite_boushi3, Sprite_kubiwa3, Sprite_megane3;
    //�ǂ̉摜��ύX����H
    public Image image_boushi, image_kubiwa,image_megane;

    [SerializeField] GameObject SelectPetPanel;
    [SerializeField] GameObject NamePetPanel;

    public GameObject SelectButton_right;
    public GameObject SelectButton_left;
    public GameObject DecisionButton;

    public Text petText;

    int whatpet = 0;

    //���t�Ɋւ���ϐ�
    private string nowDay;
    private int nowDayInt;
    private int lastDayInt;
    private int day;

    //�p�����[�^�Ɋւ���ϐ�
     private float meatDog;
    private float vegetableDog;
    private float carboDog;

    //���L�̏������񐔂Ɋւ���ϐ�
    private int score;
    //�y�b�g��I������������
    private int selectPet = 0;

    // Start is called before the first frame update
    void Start()
    {
        SelectPetPanel.SetActive(false); //�ŏ��͔�\��
        NamePetPanel.SetActive(false); //�ŏ��͔�\��

        //�uSTART�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int start = PlayerPrefs.GetInt("START");
        Debug.Log("�^�C�g������X�^�[�g�{�^�����������񐔂�" + start);
        if (start == 1)
        {
            image_pet3.enabled = false; //�ŏ��͔�\��
            SelectPetPanel.SetActive(true); //�\��
            SelectButton_left.SetActive(false); //�ŏ��͔�\��

            //�Ⴄ�V�[������߂����Ƃ��ɂ�����x�I����ʂ��o��̂ɑΏ�
            start++;
            PlayerPrefs.SetInt("START", start);
            PlayerPrefs.Save();
        }

        int PetPoint = PlayerPrefs.GetInt("PET");
        Debug.Log("�I�����Ă���y�b�g��" + PetPoint);

        if (PetPoint == 0)
        {
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_pet3.sprite = Sprite_dog;
        }
        else if (PetPoint == 1)
        {
            image_pet3.sprite = Sprite_cat;
        }
        else if (PetPoint == 2)
        {
            image_pet3.sprite = Sprite_bird;
        }
        else if (PetPoint == 3)
        {
            image_pet3.sprite = Sprite_rabbit;
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

         //�uSCORE�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        score = PlayerPrefs.GetInt("SCORE");

        //�uLAST�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        lastDayInt = PlayerPrefs.GetInt("LAST");

        //�ۑ�����Ă���3�̃p�����[�^��Float�l��ǂݍ���
        meatDog = PlayerPrefs.GetFloat("MEATDOG", 0);
        vegetableDog = PlayerPrefs.GetFloat("VEGETABLEDOG", 0);
        carboDog = PlayerPrefs.GetFloat("CARBODOG", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (whatpet == 0) {
            Debug.Log("�C�k��UpDate�͑����Ă����");
            //���݂̓��t�擾
            DateTime TodayNow = DateTime.Now;
            nowDay = TodayNow.Day.ToString();
            nowDayInt = int.Parse(nowDay);
  
            //���݂̓��t����Ō�ɗ������L�����������t������
            day = nowDayInt - lastDayInt;

            //day��3���ȏ�󂢂Ă�����
            if ((day > 3) || (day < -27))
            {
                //�A�j���𐊎��Ԃɂ���
                image_pet3.sprite = dog_Bad;
            } else {
                //�A�j�������ɖ߂�
                image_pet3.sprite = Sprite_dog;
            }

            //�����S�̎�
            if ((score >= 5) && (meatDog > 20.0f)){
                image_pet3.sprite = dog_Meat;
            } else if ((score >= 5) && (vegetableDog > 20.0f)){ //��ؒ��S�̎�
                image_pet3.sprite = dog_Vegetable;
            } else if ((score >= 5) && (carboDog > 20.0f)){ //�Y���������S�̎�
                image_pet3.sprite = dog_Carbo;
            } else if (score >= 5){ //�o�����X���ǂ���
                image_pet3.sprite = dog_Good;
            }
        } else if (whatpet == 1) {
            Debug.Log("�l�R��UpDate�͑����Ă����");
            //���݂̓��t�擾
            DateTime TodayNow = DateTime.Now;
            nowDay = TodayNow.Day.ToString();
            nowDayInt = int.Parse(nowDay);
  
            //���݂̓��t����Ō�ɗ������L�����������t������
            day = nowDayInt - lastDayInt;

            //day��3���ȏ�󂢂Ă�����
            if ((day > 3) || (day < -27))
            {
                //�A�j���𐊎��Ԃɂ���
                image_pet3.sprite = cat_Bad;
            } else {
                //�A�j�������ɖ߂�
                image_pet3.sprite = Sprite_cat;
            }

            //�����S�̎�
            if ((score >= 5) && (meatDog > 20.0f)){
                image_pet3.sprite = cat_Meat;
            } else if ((score >= 5) && (vegetableDog > 20.0f)){ //��ؒ��S�̎�
                image_pet3.sprite = cat_Vegetable;
            } else if ((score >= 5) && (carboDog > 20.0f)){ //�Y���������S�̎�
                image_pet3.sprite = cat_Carbo;
            } else if (score >= 5){ //�o�����X���ǂ���
                image_pet3.sprite = cat_Good;
            }

        } else if (whatpet == 2) {
            Debug.Log("�g����UpDate�͑����Ă����");
            //���݂̓��t�擾
            DateTime TodayNow = DateTime.Now;
            nowDay = TodayNow.Day.ToString();
            nowDayInt = int.Parse(nowDay);
  
            //���݂̓��t����Ō�ɗ������L�����������t������
            day = nowDayInt - lastDayInt;

            //day��3���ȏ�󂢂Ă�����
            if ((day > 3) || (day < -27))
            {
                //�A�j���𐊎��Ԃɂ���
                image_pet3.sprite = bird_Bad;
            } else {
                //�A�j�������ɖ߂�
                image_pet3.sprite = Sprite_bird;
            }

            //�����S�̎�
            if ((score >= 5) && (meatDog > 20.0f)){
                image_pet3.sprite = bird_Meat;
            } else if ((score >= 5) && (vegetableDog > 20.0f)){ //��ؒ��S�̎�
                image_pet3.sprite = bird_Vegetable;
            } else if ((score >= 5) && (carboDog > 20.0f)){ //�Y���������S�̎�
                image_pet3.sprite = bird_Carbo;
            } else if (score >= 5){ //�o�����X���ǂ���
                image_pet3.sprite = bird_Good;
            }
        } else {
            Debug.Log("�E�T�M��UpDate�͑����Ă����");
            //���݂̓��t�擾
            DateTime TodayNow = DateTime.Now;
            nowDay = TodayNow.Day.ToString();
            nowDayInt = int.Parse(nowDay);
  
            //���݂̓��t����Ō�ɗ������L�����������t������
            day = nowDayInt - lastDayInt;

            //day��3���ȏ�󂢂Ă�����
            if ((day > 3) || (day < -27))
            {
                //�A�j���𐊎��Ԃɂ���
                image_pet3.sprite = rabbit_Bad;
            } else {
                //�A�j�������ɖ߂�
                image_pet3.sprite = Sprite_rabbit;
            }

            //�����S�̎�
            if ((score >= 5) && (meatDog > 20.0f)){
                image_pet3.sprite = rabbit_Meat;
            } else if ((score >= 5) && (vegetableDog > 20.0f)){ //��ؒ��S�̎�
                image_pet3.sprite = rabbit_Vegetable;
            } else if ((score >= 5) && (carboDog > 20.0f)){ //�Y���������S�̎�
                image_pet3.sprite = rabbit_Carbo;
            } else if (score >= 5){ //�o�����X���ǂ���
                image_pet3.sprite = rabbit_Good;
            }
        }
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

    public void back_pet()
    {
        SelectPetPanel.SetActive(true);
        NamePetPanel.SetActive(false);
    }
    public void decision_pet()
    {
        NamePetPanel.SetActive(false);
        image_pet3.enabled = true;

        PlayerPrefs.SetInt("PET", whatpet);
        PlayerPrefs.Save();

        if (whatpet == 0)
        {
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_pet3.sprite = Sprite_dog;
        }
        else if (whatpet == 1)
        {
            image_pet3.sprite = Sprite_cat;
        }
        else if (whatpet == 2)
        {
            image_pet3.sprite = Sprite_bird;
        }
        else if (whatpet == 3)
        {
            image_pet3.sprite = Sprite_rabbit;
        }
    }
}
