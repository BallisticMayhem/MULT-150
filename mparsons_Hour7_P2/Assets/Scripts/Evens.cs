using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number;
        number = 22;

        while (number <= 100)
        {
            Debug.Log(number);
            number += 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
