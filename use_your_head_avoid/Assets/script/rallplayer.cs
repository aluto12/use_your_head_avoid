using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rallplayer : MonoBehaviour
{
    public Transport maneger;
    public float speedpointv = 0f;
    public float speedpointh = 0f;
    private float speedv = 0f;
    private float speedh = 0f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = this.transform.position;
        v.x -= speedh * maneger.roll * 0.005f;
        v.z += speedv * 0.05f;
        if (v.x < -9 || v.x > 9)
        {
            v.x += speedh * maneger.roll * 0.005f;
        }
        
        this.transform.position = v;
        
    }
    public void Activeplayer()
    {
        speedv = speedpointv;
        speedh = speedpointh;
    }
    public void stopplayer()
    {
        speedv = 0f;
        speedh = 0f;
    }
}