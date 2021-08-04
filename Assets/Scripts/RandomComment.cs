using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using System.Text;

public class RandomComment : MonoBehaviour
{
    private static readonly string[] COMMENTS = new string[] { " �J���[���C�X", "  �I�����C�X ", "  �n���o�[�O " , "  ���D�ݏĂ� ", "����؂͂ǂ��H", "  �I�����c�` ", "  �Ă����΁` ", "�V�Ôт͂ǂ��H", " �������݂���", "  �؂̊p�ρ` ", "  ���I�Ă��` ", "  �g���J�c�` ", "�e�q���͂ǂ��H", "  �`���[�n���` ", "  ����u�߁` ", "  �L���`��` ", " �ؘ��H�ׂ���", "  �����Ⴊ�I�I ", " �|�e�g�T���_", " �T�o�̉��Ă�", "  �O���^���` ", "�C�N���͂ǂ��H", "  ���k�����I�I ", " �L�q�H�ׂ���", "  �i�|���^�� ", "  ���R���R�� ", " �����H�ׂ���", " �s�U�H�ׂ���", " ���i�H�ׂ���", "���ł�͂ǂ��H" };
    public Text text;

    void Start()
    {
        //COMMENTS�̒������������_���Ŏ擾����
        string comment = COMMENTS.ElementAt(Random.Range(0, COMMENTS.Count()));
        text.text = string.Format(comment);

        Debug.Log(comment);
    }

}