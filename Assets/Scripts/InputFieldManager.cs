using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;       // DateTime���g�����߂ɕK�v
using System.IO;    // CSV�ۑ������邽�߂ɕK�v
using System.Text;

public class InputFieldManager : MonoBehaviour
{
    //�I�u�W�F�N�g�ƌ��т���
    public InputField inputField;
    public Text text;
    public Text inputText;
    private GameObject SaveFunction;
    public int ItemPoint;

    // Start is called before the first frame update
    void Start()
    {

        //Component��������悤�ɂ���
        inputField = inputField.GetComponent<InputField>();
        text = text.GetComponent<Text>();

        //�t�@�C���݂̍肩
        string filePath = Application.dataPath + "/" + "DiaryFile.csv";

        //CSV�t�@�C���ǂݍ���
        if (System.IO.File.Exists(filePath))
        {
            using (StreamReader streamReader = new StreamReader(filePath, Encoding.UTF8))
            {
                while (!streamReader.EndOfStream)
                {
                    text.text += streamReader.ReadLine() + "\n\n";
                    Debug.Log("StreamReader Completed");
                }
            }
        }
    }

    public void InputText()
    {
        //InputField��Text�R���|�[�l���g���擾
        inputText = GameObject.Find("InputField/Text").GetComponent<Text>();

        //�������擾
        DateTime TodayNow = DateTime.Now;

        //Text�^��string�^�ɕϊ�
        //���t�E�������ꏏ�ɕ\��
        String diarytext = TodayNow.Year.ToString() + "�N" + TodayNow.Month.ToString() + "��" + TodayNow.Day.ToString() + "��" + DateTime.Now.ToLongTimeString() + "\n" + inputText.text;

        //CSV�ɕۑ�����
        CSVSave(diarytext, "DiaryFile");

        //���Ƃ���CSV�ɏ�����Ă������e�ɉ����č���̃R�����g�𔽉f������
        text.text += TodayNow.Year.ToString() + "�N" + TodayNow.Month.ToString() + "��" + TodayNow.Day.ToString() + "��" + DateTime.Now.ToLongTimeString() + "\n" + inputField.text;

        //�ۑ��{�^���������Ɠ��͂��Ă��镶����������
        InputField form = GameObject.Find("InputField").GetComponent<InputField>();
        form.text = "";
        int ItemPoint = PlayerPrefs.GetInt("SCORE");
        ItemPoint++;
        PlayerPrefs.SetInt("SCORE", ItemPoint);
        PlayerPrefs.Save();

        int PointPet = PlayerPrefs.GetInt("POINT");
        PointPet++;
        PlayerPrefs.SetInt("POINT", PointPet);
        PlayerPrefs.Save();
        Debug.Log("���݂̃|�C���g(�琬�̕K�v�ȃ|�C���g)��" + PointPet);

    }

    // CSV�`���ŕۑ����邽�߂̊֐�
    private void CSVSave(String data, string fileName)
    {
        StreamWriter sw;
        FileInfo fi;
        DateTime now = DateTime.Now;

        //�t�@�C���݂̍肩
        string filePath = Application.dataPath + "/" + "DiaryFile.csv";

        fi = new FileInfo(filePath);
        sw = fi.AppendText();
        sw.WriteLine(data);
        sw.Flush();
        sw.Close();
        Debug.Log("Diary Save Completed");
    }
}
