using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTarget : MonoBehaviour
{

    public float speed;
    private Transform target;

    void Start()
    {

    }



    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Target").GetComponent<Transform>();

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

    }

}