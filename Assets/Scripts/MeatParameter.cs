using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class MeatParameter : MonoBehaviour
{

    Slider meatSlider;

    public static float meatValue = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        meatSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //肉・魚類のパラメーターを決定する
    public void Meat()
    {
        meatValue = meatSlider.value;
        Debug.Log("肉・魚類の値" + meatValue);
    }

}
