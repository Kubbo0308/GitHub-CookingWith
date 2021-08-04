using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class DogParameter : MonoBehaviour
{

    public static float meatTotalDog = 0.0f;
    public static float vegetableTotalDog = 0.0f;
    public static float carboTotalDog = 0.0f;

    private string character;

    // Start is called before the first frame update
    void Start()
    {
        meatTotalDog = PlayerPrefs.GetFloat("MEATDOG", 0);
        vegetableTotalDog = PlayerPrefs.GetFloat("VEGETABLEDOG", 0);
        carboTotalDog = PlayerPrefs.GetFloat("CARBODOG", 0);

        //「CHARACTER」というキーで保存されているstring値を読み込み
        character = PlayerPrefs.GetString("CHARACTER", "DOG");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        if (character.Equals("DOG")) {
            //パラメーターを取得
            meatTotalDog += MeatParameter.meatValue;
            vegetableTotalDog += VegetableParameter.vegetableValue;
            carboTotalDog += CarboParameter.carboValue;
            //パラメーターを保存
            PlayerPrefs.SetFloat("MEATDOG", meatTotalDog);
            PlayerPrefs.SetFloat("VEGETABLEDOG", vegetableTotalDog);
            PlayerPrefs.SetFloat("CARBODOG", carboTotalDog);
            PlayerPrefs.Save();
            //デバッグ
            Debug.Log("イヌの肉合計" + meatTotalDog);
            Debug.Log("イヌの野菜合計" + vegetableTotalDog);
            Debug.Log("イヌの炭水化物合計" + carboTotalDog);
        }
    }
}
