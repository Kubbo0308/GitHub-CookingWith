using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;       // DateTimeを使うために必要
using System.IO;    // CSV保存をするために必要
using System.Text;

public class InputFieldManager : MonoBehaviour
{
    //オブジェクトと結びつける
    public InputField inputField;
    public Text text;
    public Text inputText;
    private GameObject SaveFunction;

    // Start is called before the first frame update
    void Start()
    {
        //Componentを扱えるようにする
        inputField = inputField.GetComponent<InputField>();
        text = text.GetComponent<Text>();

        //ファイルの在りか
        string filePath = Application.dataPath + "/" + "DiaryFile.csv";

        //CSVファイル読み込み
        if (System.IO.File.Exists(filePath))
        {
            using (StreamReader streamReader = new StreamReader(filePath, Encoding.UTF8))
            {
                while (!streamReader.EndOfStream)
                {
                    text.text += streamReader.ReadLine() + "\n";
                    Debug.Log("StreamReader Completed");
                }
            }
        }
    }

    public void InputText()
    {
        //InputFieldのTextコンポーネントを取得
        inputText = GameObject.Find("InputField/Text").GetComponent<Text>();

        //Text型をstring型に変換
        String diarytext = inputText.text;

        //CSVに保存する
        CSVSave(diarytext, "DiaryFile");

        //もともとCSVに書かれていた内容に加えて今回のコメントを反映させる
        text.text += inputField.text;

        //保存ボタンを押すと入力している文字が消える
        InputField form = GameObject.Find("InputField").GetComponent<InputField>();
        form.text = "";

    }

    // CSV形式で保存するための関数
    private void CSVSave(String data, string fileName)
    {
        StreamWriter sw;
        FileInfo fi;
        DateTime now = DateTime.Now;

        //ファイルの在りか
        string filePath = Application.dataPath + "/" + "DiaryFile.csv";

        fi = new FileInfo(filePath);
        sw = fi.AppendText();
        sw.WriteLine(data);
        sw.Flush();
        sw.Close();
        Debug.Log("Diary Save Completed");
    }
}
