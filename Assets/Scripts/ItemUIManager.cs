using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUIManager : MonoBehaviour
{
    //2��Panel���i�[����ϐ�
    //�C���X�y�N�^�[�E�B���h�E����Q�[���I�u�W�F�N�g��ݒ肷��
    [SerializeField] GameObject AccessoryPanel;
    [SerializeField] GameObject FurniturePanel;


    // Start is called before the first frame update
    void Start()
    {
        //BackToMenu���\�b�h���Ăяo��
        AccessFurniture();
    }

    //TitlePanel��Button�������ꂽ�Ƃ��̏���
    //MenuPanel���A�N�e�B�u�ɂ���
    public void SelectAccessoryDescription()
    {
        AccessoryPanel.SetActive(true);
        FurniturePanel.SetActive(false);
    }

    //MenuPanel��BackButton�������ꂽ�Ƃ��̏���
    //TitlePanel���A�N�e�B�u�ɂ���
    public void AccessFurniture()
    {
        AccessoryPanel.SetActive(false);
        FurniturePanel.SetActive(true);
    }

}

