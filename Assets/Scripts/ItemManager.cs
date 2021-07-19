using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    //�C���X�y�N�^�[�E�B���h�E����Q�[���I�u�W�F�N�g��ݒ肷��
    [SerializeField] GameObject ItemPanel_f; //�Ƌ�̕��̃A�C�e���p�l��
    public GameObject buttonComplete_f; //�Ƌ�̕��̊����{�^��
    [SerializeField] GameObject ItemPanel_a; //�A�N�Z�̕��̃A�C�e���p�l��
    public GameObject buttonComplete_a; //�A�N�Z�̕��̊����{�^��

    // Start is called before the first frame update
    void Start()
    {
        ItemPanel_f.SetActive(false);
        buttonComplete_f.SetActive(false);
        ItemPanel_a.SetActive(false);
        buttonComplete_a.SetActive(false);
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
