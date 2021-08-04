using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using Debug = UnityEngine.Debug;


public class CameraManager : MonoBehaviour
{
    public RawImage RawImage;
    public Image Image;
    //カメラボタン
    public GameObject buttonCamera;
    //下のボタン達
    public GameObject buttonHome;
    public GameObject buttonGoal;
    public GameObject buttonCooking;
    public GameObject buttonCharacter;
    //撮影時に現れるボタン
    public GameObject buttonShot;
    public GameObject buttonCancel;

    //撮影後に現れるボタン
    public GameObject buttonSelect;

    //待たせるテキスト
    public GameObject waitText;

    //コメント入力テキスト＆保存ボタン
    public GameObject inputFieldGameObject;
    public GameObject buttonsave;

    //料理日記ボタン&過去の料理日記ボタン
    public GameObject buttonNowCooking;
    public GameObject buttonPastCooking;

    //スライダー
    public Slider slider_m;
    public Slider slider_v;
    public Slider slider_c;

    //テキスト
    [SerializeField] GameObject text_m;
    [SerializeField] GameObject text_v;
    [SerializeField] GameObject text_c;

    public WebCamTexture webCam;

    // Start is called before the first frame update
    void Start()
    {
        // WebCamTextureのインスタンスを生成
        webCam = new WebCamTexture();

        //RawImageのテクスチャにWebCamTextureのインスタンスを設定
        RawImage.texture = webCam;

        //Imageを最初は非表示
        Image.enabled = false;

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
        Image.enabled = false;
        //カメラ表示開始
        webCam.Play();

        //ボタン等全非表示
        buttonCamera.SetActive(false);
        buttonHome.SetActive(false);
        buttonGoal.SetActive(false);
        buttonCooking.SetActive(false);
        buttonCharacter.SetActive(false);
        buttonSelect.SetActive(false);
        waitText.SetActive(false);
        buttonsave.SetActive(false);

        inputFieldGameObject.SetActive(false);

        buttonNowCooking.SetActive(false);
        buttonPastCooking.SetActive(false);

        slider_m.gameObject.SetActive(false);
        slider_v.gameObject.SetActive(false);
        slider_c.gameObject.SetActive(false);

        text_m.SetActive(false);
        text_v.SetActive(false);
        text_c.SetActive(false);

        //撮影、キャンセルボタン表示
        buttonShot.SetActive(true);
        buttonCancel.SetActive(true);
    }

    public void OnSaveClick()
    {
        // カメラを停止
        webCam.Pause();
        // インスタンス取得
        webCam = this.GetComponent<CameraManager>().webCam;
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

        //#if UNITY_ANDROID
        //    File.WriteAllBytes(Application.persistentDataPath + "/test.jpg", bin);
        //#else
        File.WriteAllBytes(Application.dataPath + "/Resources/cooktest.jpg", bin);
        //#endif

        StartCoroutine("ExitCamera");

    }

    public void OnCancelClick()
    {
        //ボタン全表示
        buttonCamera.SetActive(true);
        buttonHome.SetActive(true);
        buttonGoal.SetActive(true);
        buttonCooking.SetActive(true);
        buttonCharacter.SetActive(true);
        RawImage.enabled = false;

        inputFieldGameObject.SetActive(true);
        buttonsave.SetActive(true);
        buttonNowCooking.SetActive(true);
        buttonPastCooking.SetActive(true);

        slider_m.gameObject.SetActive(true);
        slider_v.gameObject.SetActive(true);
        slider_c.gameObject.SetActive(true);

        text_m.SetActive(true);
        text_v.SetActive(true);
        text_c.SetActive(true);

        //撮影、キャンセルボタン非表示
        buttonShot.SetActive(false);
        buttonCancel.SetActive(false);
    }

    private IEnumerator ExitCamera()
    {
        waitText.SetActive(true);

        yield return new WaitForSeconds(3.0f);

        //ボタン全表示
        buttonCamera.SetActive(true);
        buttonHome.SetActive(true);
        buttonGoal.SetActive(true);
        buttonCooking.SetActive(true);
        buttonCharacter.SetActive(true);
        buttonSelect.SetActive(true);

        inputFieldGameObject.SetActive(true);
        buttonsave.SetActive(true);
        buttonNowCooking.SetActive(true);
        buttonPastCooking.SetActive(true);

        RawImage.enabled = false;
        Image.enabled = true;

        slider_m.gameObject.SetActive(true);
        slider_v.gameObject.SetActive(true);
        slider_c.gameObject.SetActive(true);

        text_m.SetActive(true);
        text_v.SetActive(true);
        text_c.SetActive(true);

        //撮影、キャンセルボタン非表示
        buttonShot.SetActive(false);
        buttonCancel.SetActive(false);
        waitText.SetActive(false);
    }

}
