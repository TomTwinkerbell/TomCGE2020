using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour
{

    public Material green;
    public Material yellow;
    public Material red;
    public float minwait = 5.0f;
    public float maxwait = 10.0f;
    public float G = 1.0f;
    public float R = 5.5f;

    void Start()
    {

        //float timer = Random.Range(minwait, maxwait);
        Invoke("m4", 0);
        //GetComponent<Renderer>().material = Random(green, yellow, red);


    }


    void m4()
    {
        float starter = Random.Range(G, R);

        if (starter >= 4)
        {

            Invoke("m3", 0);
        }

        else if (starter < 4 && starter >= 2.5f)
        {
            
            Invoke("m1", 0);
        }

        else if (starter < 2.5f)
        {

            Invoke("m2", 0);

        }
    }

    void m1()
    {
            float timer1 = Random.Range(minwait, maxwait);
            GetComponent<Renderer>().material = green;
            gameObject.tag = "Target";
            Invoke("m2", timer1);
    }
    void m2()
    {
        GetComponent<Renderer>().material = yellow;
        gameObject.tag = "Untagged";
        Invoke("m3", 4.0f);
    }
    void m3()
    {
        float timer2 = Random.Range(minwait, maxwait);
        gameObject.tag = "Untagged";
        GetComponent<Renderer>().material = red;
        Invoke("m1", timer2);
    }


}


