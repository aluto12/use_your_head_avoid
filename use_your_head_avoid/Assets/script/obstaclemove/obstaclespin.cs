using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclespin : MonoBehaviour
{
    public float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(new Vector3(0, speed * 0.01f, 0)); 　　　//オブジェクトを回転させる
    }
}
