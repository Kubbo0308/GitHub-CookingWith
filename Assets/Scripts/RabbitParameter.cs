using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class RabbitParameter : MonoBehaviour
{
    public static float meatTotalRabbit = 0.0f;
    public static float vegetableTotalRabbit = 0.0f;
    public static float carboTotalRabbit = 0.0f;

    private string character;

    // Start is called before the first frame update
    void Start()
    {
        meatTotalRabbit = PlayerPrefs.GetFloat("MEATRABBIT", 0);
        vegetableTotalRabbit = PlayerPrefs.GetFloat("VEGETABLERABBIT", 0);
        carboTotalRabbit = PlayerPrefs.GetFloat("CARBORABBIT", 0);
        
        //「CHARACTER」というキーで保存されているstring値を読み込み
        character = PlayerPrefs.GetString("CHARACTER", "DOG");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        if (character.Equals("RABBIT")) {
            //パラメーターを取得
            meatTotalRabbit += MeatParameter.meatValue;
            vegetableTotalRabbit += VegetableParameter.vegetableValue;
            carboTotalRabbit += CarboParameter.carboValue;
            //パラメーターを保存
            PlayerPrefs.SetFloat("MEATRABBIT", meatTotalRabbit);
            PlayerPrefs.SetFloat("VEGETABLERABBIT", vegetableTotalRabbit);
            PlayerPrefs.SetFloat("CARBORABBIT", carboTotalRabbit);
            PlayerPrefs.Save();
            //デバッグ
            Debug.Log("ウサギの肉合計" + meatTotalRabbit);
            Debug.Log("ウサギの野菜合計" + vegetableTotalRabbit);
            Debug.Log("ウサギの炭水化物合計" + carboTotalRabbit);
        }
    }
}
