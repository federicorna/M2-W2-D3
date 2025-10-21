using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{ 
        [SerializeField] int a = 5;
        [SerializeField] int b = 2;
        [SerializeField] int c = 3;
        [SerializeField] int d = 10;

   
    void Start()
    {
       
        Debug.Log("Somma: " + (a + b + c + d));
        Debug.Log("Prodotto: " + (a * b * c * d));
        Debug.Log("Media: " + (a + b + c + d) / 4); 
    }

}
