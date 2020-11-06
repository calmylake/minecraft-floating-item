using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seila : MonoBehaviour
{
    public float gira;
    public float a;
    public float sinal;
    public bool aumentar;
    public Vector3 InitalPosition;
    void Start()
    {
        gira = 0.2f;
        a = 0.01f;
        aumentar = false;
        sinal = 1;
        InitalPosition = new Vector3(Random.value*6-2, 4, Random.value*6-2);
        transform.position = InitalPosition;
    }

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, gira, 0));
        transform.position += new Vector3(0, a ,0);
        if (aumentar)
        {
            a += 0.00015f*sinal;
        }
        else
        {
            a -= 0.00015f*sinal;
        }
        if (a*sinal < 0)
        {
            aumentar = true;
            sinal = -1*sinal;
        }
        if (a*sinal > 0.01f)
        {
            aumentar = false;
        }
    }

}
