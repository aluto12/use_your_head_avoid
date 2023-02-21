using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstalcevmove : MonoBehaviour
{
    public float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 v = this.transform.position;
        v.y += speed * 0.001f;
        if (v.y > 5 || v.y <= 1) {
            speed = speed * (-1);
        }
        this.transform.position = v;

    }

}
