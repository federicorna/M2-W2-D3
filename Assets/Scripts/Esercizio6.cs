using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio6 : MonoBehaviour
{

    [SerializeField] int a;
    [SerializeField] int b;

    void Start()
    {
        if (a > b)
        {

            Debug.Log(a);

        }
        else if (b > a)
        {

            Debug.Log(b);
        }
    }
}