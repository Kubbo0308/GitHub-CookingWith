using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class BardParameter : MonoBehaviour
{
    public static float meatTotalBard = 0.0f;
    public static float vegetableTotalBard = 0.0f;
    public static float carboTotalBard = 0.0f;

    private string character;

    // Start is called before the first frame update
    void Start()
    {
        meatTotalBard = PlayerPrefs.GetFloat("MEATBARD", 0);
        vegetableTotalBard = PlayerPrefs.GetFloat("VEGETABLEBARD", 0);
        carboTotalBard = PlayerPrefs.GetFloat("CARBOBARD", 0);

        //「CHARACTER」というキーで保存されているstring値を読み込み
        character = PlayerPrefs.GetString("CHARACTER", "DOG");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        if (character.Equals("BARD")) {
            //パラメーターを取得
            meatTotalBard += MeatParameter.meatValue;
            vegetableTotalBard += VegetableParameter.vegetableValue;
            carboTotalBard += CarboParameter.carboValue;
            //パラメーターを保存
            PlayerPrefs.SetFloat("MEATBARD", meatTotalBard);
            PlayerPrefs.SetFloat("VEGETABLEBARD", vegetableTotalBard);
            PlayerPrefs.SetFloat("CARBOBARD", carboTotalBard);
            PlayerPrefs.Save();
            //デバッグ
            Debug.Log("トリの肉合計" + meatTotalBard);
            Debug.Log("トリの野菜合計" + vegetableTotalBard);
            Debug.Log("トリの炭水化物合計" + carboTotalBard);
        }
    }
}
