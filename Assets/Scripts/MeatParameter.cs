using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class MeatParameter : MonoBehaviour
{

    Slider meatSlider;

    public static float nowMeatValue = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        meatSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //���E���ނ̃p�����[�^�̒l�����肷��
    public void Meat()
    {
        nowMeatValue = meatSlider.value;
        Debug.Log("���E���ނ̒l" + nowMeatValue);
    }

}
