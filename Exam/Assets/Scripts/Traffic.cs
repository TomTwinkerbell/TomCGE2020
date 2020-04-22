using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic : MonoBehaviour

    
{
    public GameObject tlight;
    float numObjects = 10f;
    float radius = 10f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numObjects; i++)
        {
            float theta = i * 2 * Mathf.PI / numObjects;
            float x = Mathf.Sin(theta) * radius;
            float y = Mathf.Cos(theta) * radius;

            Instantiate(tlight, new Vector3(x, 0, y), Quaternion.identity);
            
        }

    }
}
