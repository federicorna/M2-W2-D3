using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio8 : MonoBehaviour
{
    [SerializeField] float voto = 0f;


    void Start()
    {
        if (voto >= 0 && voto <= 10) {


            if (voto == 10)
            {
                Debug.Log("A+");
            }
            else if (voto >= 9 && voto < 10)
            {
                Debug.Log("A");
            }
            else if (voto >= 8.7 && voto < 9)
            {
                Debug.Log("B");
            }
            else if (voto >= 6 && voto < 8.7)
            {
                Debug.Log("C");
            }
            else if (voto >= 5 && voto < 6)
            {
                Debug.Log("D");
            }
            else if (voto >= 0 && voto < 5)
            {
                Debug.Log("F");
            }

        } else {
            Debug.Log("Il voto deve essere compreso tra 0 e 10");
        }
    }

}
