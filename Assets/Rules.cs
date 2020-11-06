using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour
{
    public bool turn;
    void Start()
    {
        turn = false;
    }

    void Update()
    {
        
    }

    public void ChangeTurn(bool b)
    {
        Debug.Log("changing b from "+turn+" to "+b);
        turn = b;
    }
}
