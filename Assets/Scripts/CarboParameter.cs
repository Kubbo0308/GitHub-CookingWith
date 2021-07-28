using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class CarboParameter : MonoBehaviour
{

    Slider carboSlider;

    public static float carboValue = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        carboSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Carbo()
    {
        carboValue = carboSlider.value;
        Debug.Log("炭水化物の値" + carboValue);
        /*
        Debug.Log("イヌ" + ButtonManager.dog);
        Debug.Log("ネコ" + ButtonManager.cat);
        Debug.Log("トリ" + ButtonManager.bard);
        Debug.Log("ウサギ" + ButtonManager.rabbit);
        */
    }

}
