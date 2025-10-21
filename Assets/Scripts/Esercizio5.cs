using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{

    [SerializeField] int StartingNumber = 1;


    void Start()
    {
        Debug.Log(StartingNumber);
        Debug.Log(--StartingNumber);
        Debug.Log(--StartingNumber);
    }

}