using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 3f;
    float moveX = 0f;
    float moveZ = 0f;
    Rigidbody rb;
    float r2 = 1 / Mathf.Sqrt(2);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 v = this.transform.position;
        v.x += x * 0.02f;
        v.z += 0.005f;
        this.transform.position = v;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            Destroy(this.gameObject);
            //myManager.Gameover();
        }
        else if (collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
            //myManager.Gameover();
        }
    }
}
