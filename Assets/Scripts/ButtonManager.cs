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
    //�J�����{�^��
    public GameObject buttonCamera;
    //���̃{�^���B
    public GameObject buttonHome;
    public GameObject buttonGoal;
    public GameObject buttonCooking;
    public GameObject buttonCharacter;
    public GameObject buttonFreindship;
    //�B�e���Ɍ����{�^��
    public GameObject buttonShot;
    public GameObject buttonCancel;

    //�҂�����e�L�X�g
    public GameObject waitText;

    WebCamTexture webCam;

    // Start is called before the first frame update
    void Start()
    {
        // WebCamTexture�̃C���X�^���X�𐶐�
        webCam = new WebCamTexture();

        //RawImage�̃e�N�X�`����WebCamTexture�̃C���X�^���X��ݒ�
        RawImage.texture = webCam;


        //�c���̃T�C�Y��v��
        webCam.requestedWidth = 3024;
        webCam.requestedHeight = 4032;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�J�����{�^���^�b�`
    public void OnCameraClick()
    {
        RawImage.enabled = true;
        //�J�����\���J�n
        webCam.Play();

        //�{�^���S��\��
        buttonCamera.SetActive(false);
        buttonHome.SetActive(false);
        buttonGoal.SetActive(false);
        buttonCooking.SetActive(false);
        buttonCharacter.SetActive(false);
        buttonFreindship.SetActive(false);

        //�B�e�A�L�����Z���{�^���\��
        buttonShot.SetActive(true);
        buttonCancel.SetActive(true);
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

    public void OnSaveClick()
    {
        // �J�������~
        webCam.Pause();
        // �C���X�^���X�擾
        webCam = this.GetComponent<ButtonManager>().webCam;
        // Texture2D��V�K�쐬
        Texture2D texture = new Texture2D(webCam.width, webCam.height, TextureFormat.ARGB32, false);
        // �J�����̃s�N�Z���f�[�^��ݒ�
        texture.SetPixels(webCam.GetPixels());
        // Texture��Apply
        texture.Apply();

        // Encode
        byte[] bin = texture.EncodeToJPG();
        // Encode���I�������폜
        Object.Destroy(texture);

        Debug.Log("�B�e����");

#if UNITY_ANDROID
        File.WriteAllBytes(Application.persistentDataPath + "/test.jpg", bin);
#else
        File.WriteAllBytes(Application.dataPath + "/cooktest.jpg", bin);
#endif

        StartCoroutine("ExitCamera");

    }

    public void OnCancelClick()
    {
        //�{�^���S��\��
        buttonCamera.SetActive(true);
        buttonHome.SetActive(true);
        buttonGoal.SetActive(true);
        buttonCooking.SetActive(true);
        buttonCharacter.SetActive(true);
        buttonFreindship.SetActive(true);
        RawImage.enabled = false;

        //�B�e�A�L�����Z���{�^���\��
        buttonShot.SetActive(false);
        buttonCancel.SetActive(false);
    }

    private IEnumerator ExitCamera()
    {
        waitText.SetActive(true);

        yield return new WaitForSeconds(3.0f);

        //�{�^���S��\��
        buttonCamera.SetActive(true);
        buttonHome.SetActive(true);
        buttonGoal.SetActive(true);
        buttonCooking.SetActive(true);
        buttonCharacter.SetActive(true);
        buttonFreindship.SetActive(true);
        RawImage.enabled = false;

        //�B�e�A�L�����Z���{�^���\��
        buttonShot.SetActive(false);
        buttonCancel.SetActive(false);
        waitText.SetActive(false);
    }

}
