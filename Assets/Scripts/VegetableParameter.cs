using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class VegetableParameter : MonoBehaviour
{

    Slider vegetableSlider;

    public static float vegetableValue = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        vegetableSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Vegetable()
    {
        vegetableValue = vegetableSlider.value;
        Debug.Log("野菜類の値" + vegetableValue);
    }

}
