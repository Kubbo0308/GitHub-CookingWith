using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class DogParameter : MonoBehaviour
{

    public static float meatTotal = 0.0f;
    public static float vegetableTotal = 0.0f;
    public static float carboTotal = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        meatTotal = PlayerPrefs.GetFloat("MEAT", 0);
        vegetableTotal = PlayerPrefs.GetFloat("VEGETABLE", 0);
        carboTotal = PlayerPrefs.GetFloat("CARBO", 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        //パラメーターを取得
        meatTotal += MeatParameter.meatValue;
        vegetableTotal += VegetableParameter.vegetableValue;
        carboTotal += CarboParameter.carboValue;
        //パラメーターを保存
        PlayerPrefs.SetFloat("MEAT", meatTotal);
        PlayerPrefs.SetFloat("VEGETABLE", vegetableTotal);
        PlayerPrefs.SetFloat("CARBO", carboTotal);
        PlayerPrefs.Save();
        //デバッグ
        Debug.Log("肉合計" + meatTotal);
        Debug.Log("野菜合計" + vegetableTotal);
        Debug.Log("炭水化物合計" + carboTotal);
    }
}
