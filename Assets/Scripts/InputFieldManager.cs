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
    public int ItemPoint;

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
                    text.text += streamReader.ReadLine() + "\n\n";
                    Debug.Log("StreamReader Completed");
                }
            }
        }
    }

    public void InputText()
    {
        //InputFieldのTextコンポーネントを取得
        inputText = GameObject.Find("InputField/Text").GetComponent<Text>();

        //時刻を取得
        DateTime TodayNow = DateTime.Now;

        //Text型をstring型に変換
        //日付・時刻も一緒に表示
        String diarytext = TodayNow.Year.ToString() + "年" + TodayNow.Month.ToString() + "月" + TodayNow.Day.ToString() + "日" + DateTime.Now.ToLongTimeString() + "\n" + inputText.text;

        //CSVに保存する
        CSVSave(diarytext, "DiaryFile");

        //もともとCSVに書かれていた内容に加えて今回のコメントを反映させる
        text.text += TodayNow.Year.ToString() + "年" + TodayNow.Month.ToString() + "月" + TodayNow.Day.ToString() + "日" + DateTime.Now.ToLongTimeString() + "\n" + inputField.text;

        //保存ボタンを押すと入力している文字が消える
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
        Debug.Log("現在のポイント(育成の必要なポイント)は" + PointPet);

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
