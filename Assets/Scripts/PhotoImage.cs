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
        Texture2D texture = Resources.Load("cooktest") as Texture2D;
        //textureからspriteに変換
        sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), Vector2.zero);
        //Imageにspriteを張り付ける
        gameObject.GetComponent<Image>().sprite = sprite;
        selectButton.SetActive(false);
    }

}
