using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class ButtonManager : MonoBehaviour
{
    //���̃{�^���B
    public GameObject buttonHome;
    public GameObject buttonGoal;
    public GameObject buttonCooking;
    public GameObject buttonCharacter;
    private string lastDay;
    private int lastInt;
    //最初はイヌ以外オフにする
 
    WebCamTexture webCam;

    public GameObject cameraManager;
    public GameObject canvas;
    public GameObject image;

    //imageはスプライトを使って描画しているので
    Sprite sprite;
    //画像リンクから画像をテクスチャにする
    Texture2D texture;

    //�B�e���Ɍ����{�^��

    // Start is called before the first frame update
    void Start()
    {
        lastInt = PlayerPrefs.GetInt("LAST", 0);
        
        // WebCamTextureのインスタンスを生成
        webCam = new WebCamTexture();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GoTitleButton()
    {
        //�^�C�g����ʂ�
        SceneManager.LoadScene("TitleScene");
    }

    public void GoGoalButton()
    {
        //�ڕW��ʂ�
        SceneManager.LoadScene("GoalScene");
    }

    public void GoCookingButton()
    {
        //�������L��ʂ�
        SceneManager.LoadScene("CookingScene");
    }

    public void GoCharacterButton()
    {
        //�L������ʂ�
        SceneManager.LoadScene("CharacterScene");
    }

    public void GoFriendButton()
    {
        //�ӂꂠ����ʂ�
        SceneManager.LoadScene("FriendScene");
    }
    public void GoTrueTitleButton()
    {
        SceneManager.LoadScene("TrueTitleScene");
    }

    public void SaveButton() //保存ボタン押されたときの日付取得
    {
        DateTime TodayNow = DateTime.Now;
        lastDay = TodayNow.Day.ToString();
        lastInt = int.Parse(lastDay);
        PlayerPrefs.SetInt("LAST", lastInt);
        Debug.Log("現在の日付" + lastInt);

        // インスタンス取得
        webCam = cameraManager.GetComponent<CameraManager>().webCam;
        // Texture2Dを新規作成
        Texture2D texture = new Texture2D(webCam.width, webCam.height, TextureFormat.ARGB32, false);
        // カメラのピクセルデータを設定
        texture.SetPixels(webCam.GetPixels());
        // TextureをApply
        texture.Apply();

        // Encode
        byte[] bin = texture.EncodeToJPG();
        // Encodeが終わったら削除
        UnityEngine.Object.Destroy(texture);

        File.WriteAllBytes(Application.dataPath + "/Resources/cook.jpg", bin);

        GameObject prefab = (GameObject)Instantiate (image);
        prefab.transform.SetParent (canvas.transform, false); 

        texture = Resources.Load("cook") as Texture2D;
        //textureからspriteに変換
        sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), Vector2.zero);
        //Imageにspriteを張り付ける
        image.GetComponent<Image>().sprite = sprite;
    }

}
