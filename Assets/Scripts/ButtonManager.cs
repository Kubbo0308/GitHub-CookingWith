using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class ButtonManager : MonoBehaviour
{
    public RawImage RawImage;
    public GameObject Text;
    //カメラボタン
    public GameObject buttonCamera;
    //下のボタン達
    public GameObject buttonHome;
    public GameObject buttonGoal;
    public GameObject buttonCooking;
    public GameObject buttonCharacter;
    public GameObject buttonFreindship;
    //撮影時に現れるボタン
    public GameObject buttonShot;
    public GameObject buttonCancel;

    //待たせるテキスト
    public GameObject waitText;

    WebCamTexture webCam;

    // Start is called before the first frame update
    void Start()
    {
        // WebCamTextureのインスタンスを生成
        webCam = new WebCamTexture();

        //RawImageのテクスチャにWebCamTextureのインスタンスを設定
        RawImage.texture = webCam;


        //縦横のサイズを要求
        webCam.requestedWidth = 3024;
        webCam.requestedHeight = 4032;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //カメラボタンタッチ
    public void OnCameraClick()
    {
        RawImage.enabled = true;
        //カメラ表示開始
        webCam.Play();

        //ボタン全非表示
        buttonCamera.SetActive(false);
        buttonHome.SetActive(false);
        buttonGoal.SetActive(false);
        buttonCooking.SetActive(false);
        buttonCharacter.SetActive(false);
        buttonFreindship.SetActive(false);

        //撮影、キャンセルボタン表示
        buttonShot.SetActive(true);
        buttonCancel.SetActive(true);
    }

    public void GoTitleButton()
    {
        //タイトル画面へ
        SceneManager.LoadScene("TitleScene");
    }

    public void GoGoalButton()
    {
        //目標画面へ
        SceneManager.LoadScene("GoalScene");
    }

    public void GoCookingButton()
    {
        //料理日記画面へ
        SceneManager.LoadScene("CookingScene");
    }

    public void GoCharacterButton()
    {
        //キャラ画面へ
        SceneManager.LoadScene("CharacterScene");
    }

    public void GoFriendButton()
    {
        //ふれあい画面へ
        SceneManager.LoadScene("FriendScene");
    }

    public void OnSaveClick()
    {
        // カメラを停止
        webCam.Pause();
        // インスタンス取得
        webCam = this.GetComponent<ButtonManager>().webCam;
        // Texture2Dを新規作成
        Texture2D texture = new Texture2D(webCam.width, webCam.height, TextureFormat.ARGB32, false);
        // カメラのピクセルデータを設定
        texture.SetPixels(webCam.GetPixels());
        // TextureをApply
        texture.Apply();

        // Encode
        byte[] bin = texture.EncodeToJPG();
        // Encodeが終わったら削除
        Object.Destroy(texture);

        Debug.Log("撮影成功");

#if UNITY_ANDROID
        File.WriteAllBytes(Application.persistentDataPath + "/test.jpg", bin);
#else
        File.WriteAllBytes(Application.dataPath + "/cooktest.jpg", bin);
#endif

        StartCoroutine("ExitCamera");

    }

    public void OnCancelClick()
    {
        //ボタン全非表示
        buttonCamera.SetActive(true);
        buttonHome.SetActive(true);
        buttonGoal.SetActive(true);
        buttonCooking.SetActive(true);
        buttonCharacter.SetActive(true);
        buttonFreindship.SetActive(true);
        RawImage.enabled = false;

        //撮影、キャンセルボタン表示
        buttonShot.SetActive(false);
        buttonCancel.SetActive(false);
    }

    private IEnumerator ExitCamera()
    {
        waitText.SetActive(true);

        yield return new WaitForSeconds(3.0f);

        //ボタン全非表示
        buttonCamera.SetActive(true);
        buttonHome.SetActive(true);
        buttonGoal.SetActive(true);
        buttonCooking.SetActive(true);
        buttonCharacter.SetActive(true);
        buttonFreindship.SetActive(true);
        RawImage.enabled = false;

        //撮影、キャンセルボタン表示
        buttonShot.SetActive(false);
        buttonCancel.SetActive(false);
        waitText.SetActive(false);
    }

}
