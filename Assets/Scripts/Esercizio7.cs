using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio7 : MonoBehaviour
{

    [SerializeField] int a;
    [SerializeField] int b;

    void Start()
    {
        if (a > b)
        {

            Debug.Log(b);

        }
        else if (b > a)
        {

            Debug.Log(a);
        }
    }
}