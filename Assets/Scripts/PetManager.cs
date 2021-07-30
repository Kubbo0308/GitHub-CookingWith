using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetManager : MonoBehaviour
{
    //ペットの画像
    public Sprite Sprite_dog, Sprite_cat, Sprite_bird, Sprite_rabbit;
    public Image image_pet;
    public Image image_pet2; //名前入力画面のペット画像
    public Image image_pet3; //ホーム画面に滞在するペット画像

    [SerializeField] GameObject SelectPetPanel;
    [SerializeField] GameObject NamePetPanel;

    public GameObject SelectButton_right;
    public GameObject SelectButton_left;
    public GameObject DecisionButton;

    int whatpet = 0;

    // Start is called before the first frame update
    void Start()
    {
        image_pet3.enabled = false; //最初は非表示
        SelectPetPanel.SetActive(false); //最初は非表示
        NamePetPanel.SetActive(false); //最初は非表示

        //「START」というキーで保存されているInt値を読み込み
        int start = PlayerPrefs.GetInt("START");
        Debug.Log("タイトルからスタートボタンを押した回数は" + start);
        if (start == 0)
        {
            SelectPetPanel.SetActive(true); //表示
            SelectButton_left.SetActive(false); //最初は非表示
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    //三角ボタン(右)が押されたとき
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

    //三角ボタン(左)が押されたとき
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
            // SpriteRenderのspriteを設定済みの他のspriteに変更
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
