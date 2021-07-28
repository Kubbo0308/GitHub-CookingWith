using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeItemManager : MonoBehaviour
{
    // public�Ő錾���Ainspector�Őݒ�\�ɂ���
    //���̉摜�ɕύX����
    public Sprite Sprite_f1, Sprite_f2, Sprite_f3, Sprite_f4, Sprite_f5;
    public Sprite Sprite_f6, Sprite_f7, Sprite_f8, Sprite_f9, Sprite_f10;
    public Sprite Sprite_f11, Sprite_f12, Sprite_f13, Sprite_f14, Sprite_f15;
    public Sprite Sprite_f16, Sprite_f17, Sprite_f18, Sprite_f19, Sprite_f20;
    public Sprite Sprite_f21, Sprite_f22, Sprite_f23, Sprite_f24;

    //�ǂ̉摜��ύX����H
    public Image image_f1, image_f2, image_f3;
    public Image image_f4, image_f5, image_f6;

    // Start is called before the first frame update
    void Start()
    {
        //�uFurniture_�����v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int furniture_k = PlayerPrefs.GetInt("Furniture_k");
        int furniture_y = PlayerPrefs.GetInt("Furniture_y");
        int furniture_z = PlayerPrefs.GetInt("Furniture_z");
        int furniture_t = PlayerPrefs.GetInt("Furniture_t");
        int furniture_ku = PlayerPrefs.GetInt("Furniture_ku");
        int furniture_m = PlayerPrefs.GetInt("Furniture_m");

        Debug.Log(" ���I������Ă���ǎ���" + furniture_k);
        Debug.Log(" ���I������Ă��鏰��" + furniture_y);
        Debug.Log(" ���I������Ă�����z�c��" + furniture_z);
        Debug.Log(" ���I������Ă������" + furniture_t);
        Debug.Log(" ���I������Ă���N���[�[�b�g��" + furniture_ku);
        Debug.Log(" ���I������Ă��鑋��" + furniture_m);

        image_f2.enabled = false; //�ŏ��͔�\��
        image_f3.enabled = false; //�ŏ��͔�\��
        image_f4.enabled = false; //�ŏ��͔�\��
        image_f5.enabled = false; //�ŏ��͔�\��
        image_f6.enabled = false; //�ŏ��͔�\��

        //furniture(�ǂ̕ǎ���I�����Ă��邩)�ŕǎ��ύX
        if (furniture_k == 1)
        {
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f1.sprite = Sprite_f1;
        }
        if (furniture_k == 2)
        {
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f1.sprite = Sprite_f2;
        }
        if (furniture_k == 3)
        {
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f1.sprite = Sprite_f3;
        }
        if (furniture_k == 4)
        {
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f1.sprite = Sprite_f4;
        }
        if (furniture_y == 1)
        {
            image_f2.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f2.sprite = Sprite_f5;
        }
        if (furniture_y == 2)
        {
            image_f2.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f2.sprite = Sprite_f6;
        }
        if (furniture_y == 3)
        {
            image_f2.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f2.sprite = Sprite_f7;
        }
        if (furniture_y == 4)
        {
            image_f2.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f2.sprite = Sprite_f8;
        }
        if (furniture_z == 1)
        {
            image_f3.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f3.sprite = Sprite_f9;
        }
        if (furniture_z == 2)
        {
            image_f3.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f3.sprite = Sprite_f10;
        }
        if (furniture_z == 3)
        {
            image_f3.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f3.sprite = Sprite_f11;
        }
        if (furniture_z == 4)
        {
            image_f3.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f3.sprite = Sprite_f12;
        }
        if (furniture_t == 1)
        {
            image_f4.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f4.sprite = Sprite_f13;
        }
        if (furniture_t == 2)
        {
            image_f4.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f4.sprite = Sprite_f14;
        }
        if (furniture_t == 3)
        {
            image_f4.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f4.sprite = Sprite_f15;
        }
        if (furniture_t == 4)
        {
            image_f4.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f4.sprite = Sprite_f16;
        }
        if (furniture_ku == 1)
        {
            image_f5.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f5.sprite = Sprite_f17;
        }
        if (furniture_ku == 2)
        {
            image_f5.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f5.sprite = Sprite_f18;
        }
        if (furniture_ku == 3)
        {
            image_f5.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f5.sprite = Sprite_f19;
        }
        if (furniture_ku == 4)
        {
            image_f5.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f5.sprite = Sprite_f20;
        }
        if (furniture_m == 1)
        {
            image_f6.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f6.sprite = Sprite_f21;
        }
        if (furniture_m == 2)
        {
            image_f6.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f6.sprite = Sprite_f22;
        }
        if (furniture_m == 3)
        {
            image_f6.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f6.sprite = Sprite_f23;
        }
        if (furniture_m == 4)
        {
            image_f6.enabled = true; //�\������
            // SpriteRender��sprite��ݒ�ς݂̑���sprite�ɕύX
            image_f6.sprite = Sprite_f24;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
