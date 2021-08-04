using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PhotoImage : MonoBehaviour
{

    //imageはスプライトを使って描画しているので
    Sprite sprite;
    //画像リンクから画像をテクスチャにする
    Texture2D texture;
    public GameObject selectButton;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PhotoUpload()
    {
        //var texture = Resources.Load<Texture2D>("cooktest");
        Texture2D texture = Resources.Load("cooktest") as Texture2D;
        //textureからspriteに変換
        sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), Vector2.zero);
        //Imageにspriteを張り付ける
        gameObject.GetComponent<Image>().sprite = sprite;
        selectButton.SetActive(false);
    }

    //テクスチャを読み込む
    IEnumerator Connect()
    {

        //画像リンク
        string url = "Assets/cooktest.jpg";


        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);

        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
        }
        else
        {
            //textureに画像格納
            texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
            //textureからspriteに変換
            sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), Vector2.zero);
            //Imageにspriteを張り付ける
            gameObject.GetComponent<Image>().sprite = sprite;
        }
    }

}
