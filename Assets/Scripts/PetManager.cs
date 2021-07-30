using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetManager : MonoBehaviour
{
    //�y�b�g�̉摜
    public Sprite Sprite_dog, Sprite_cat, Sprite_bird, Sprite_rabbit;
    public Image image_pet;
    public Image image_pet2; //���O���͉�ʂ̃y�b�g�摜
    public Image image_pet3; //�z�[����ʂɑ؍݂���y�b�g�摜

    [SerializeField] GameObject SelectPetPanel;
    [SerializeField] GameObject NamePetPanel;

    public GameObject SelectButton_right;
    public GameObject SelectButton_left;
    public GameObject DecisionButton;

    int whatpet = 0;

    // Start is called before the first frame update
    void Start()
    {
        image_pet3.enabled = false; //�ŏ��͔�\��
        SelectPetPanel.SetActive(false); //�ŏ��͔�\��
        NamePetPanel.SetActive(false); //�ŏ��͔�\��

        //�uSTART�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int start = PlayerPrefs.GetInt("START");
        Debug.Log("�^�C�g������X�^�[�g�{�^�����������񐔂�" + start);
        if (start == 0)
        {
            SelectPetPanel.SetActive(true); //�\��
            SelectButton_left.SetActive(false); //�ŏ��͔�\��
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
        }
        else if (whatpet == 2)
        {
            image_pet.sprite = Sprite_bird;
            SelectButton_right.SetActive(true);
        }
        else if (whatpet == 3)
        {
            image_pet.sprite = Sprite_rabbit;
            SelectButton_right.SetActive(false);
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
        }
        else if (whatpet == 1)
        {
            SelectButton_right.SetActive(true);
            image_pet.sprite = Sprite_cat;
        }
        else if (whatpet == 2)
        {
            SelectButton_right.SetActive(true);
            image_pet.sprite = Sprite_bird;
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
}
