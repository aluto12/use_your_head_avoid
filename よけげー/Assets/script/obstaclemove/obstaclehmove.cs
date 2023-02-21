using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclehmove : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 v = this.transform.position;
        v.x += speed * 0.001f;
        this.transform.position = v;

    }

    private void OnCollisionEnter(Collision collision)
    {
        speed = speed * (-1);
    }
}
