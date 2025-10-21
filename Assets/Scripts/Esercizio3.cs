using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{

    [SerializeField] int a = 0;
    
    void Start()
    {

        if (a % 2 == 0) {
            Debug.Log(a);
        }


    }

}
