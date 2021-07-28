using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class CatParameter : MonoBehaviour
{

    public static float meatTotalCat = 0.0f;
    public static float vegetableTotalCat = 0.0f;
    public static float carboTotalCat = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        meatTotalCat = PlayerPrefs.GetFloat("MEATCAT", 0);
        vegetableTotalCat = PlayerPrefs.GetFloat("VEGETABLECAT", 0);
        carboTotalCat = PlayerPrefs.GetFloat("CARBOCAT", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        if (ButtonManager.cat) {
            //パラメーターを取得
            meatTotalCat += MeatParameter.meatValue;
            vegetableTotalCat += VegetableParameter.vegetableValue;
            carboTotalCat += CarboParameter.carboValue;
            //パラメーターを保存
            PlayerPrefs.SetFloat("MEATCAT", meatTotalCat);
            PlayerPrefs.SetFloat("VEGETABLECAT", vegetableTotalCat);
            PlayerPrefs.SetFloat("CARBOCAT", carboTotalCat);
            PlayerPrefs.Save();
            //デバッグ
            Debug.Log("ネコの肉合計" + meatTotalCat);
            Debug.Log("ネコの野菜合計" + vegetableTotalCat);
            Debug.Log("ネコの炭水化物合計" + carboTotalCat);
        }
    }
}
