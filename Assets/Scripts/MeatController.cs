using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatController : MonoBehaviour
{
    //ポインター
    public GameObject pointer;

    private PointerController point;

    private Transform trans;

    //ポインターの座標
    Vector3 tmp;

    // Start is called before the first frame update
    void Start()
    {
        trans = this.transform.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tmp = pointer.transform.position;

        //if(point.mouse)
        //{
        trans.localScale = new Vector2(trans.localScale.x + tmp.x, trans.localScale.y);
        //}

    }
}
