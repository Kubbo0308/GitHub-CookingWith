using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerController : MonoBehaviour
{

    private Vector3 screenPoint;
    private Vector3 offset;

    public bool mouse = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        //マウスの、メインカメラから見た座標を取得
        this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 0));
        //マウスが押されている間true
        mouse = true;
    }

    void OnMouseDrag()
    {
        //ドラッグしたx方向に移動
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, 0, 0);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
        transform.position = currentPosition;
        Debug.Log(transform.position);
    }

    void OnMouseExit()
    {
        mouse = false;
    }

}
