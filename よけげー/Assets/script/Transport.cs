using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;



public class Transport : MonoBehaviour
{
    static UdpClient udp;
    public string sentence;
    IPEndPoint remoteEP = null;
    int i = 0;
    public float pitch = 0;
    public float yaw = 0;
    public float roll = 0;
    public float x = 0;
    public float y = 0;
    bool conect = false;

    // Use this for initialization
    void Start()
    {
        int LOCA_LPORT = 50007;
        udp = new UdpClient(LOCA_LPORT);
        udp.Client.ReceiveTimeout = 2000;
        conect = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (conect == true)
        {
            IPEndPoint remoteEP = null;
            byte[] data = udp.Receive(ref remoteEP);
            string text = Encoding.UTF8.GetString(data);
            sentence = text;


            string[] arr = sentence.Split(',');
            if (arr.Length > 4)
            {
                pitch = float.Parse(arr[0]);
                yaw = float.Parse(arr[1]);
                roll = float.Parse(arr[2]);
                x = float.Parse(arr[3]);
                y = float.Parse(arr[4]);
                Debug.Log(sentence);
            }
        }
    }

    public void OnDestroy()
    {
        udp.Close();
        conect = false;
    }

}