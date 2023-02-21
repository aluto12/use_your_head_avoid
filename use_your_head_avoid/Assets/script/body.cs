using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body : MonoBehaviour
{

    Rigidbody rb;
    public gamemaneger myManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            myManager.Gameover();
            Destroy(this.gameObject);
        }

        else if (collision.gameObject.tag == "Finish")
        {
            myManager.Gameclear();
           
        }
    }
}
