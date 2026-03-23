using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int birthday;
        int day;
        birthday = 4;
        day = 1;

        while (day <= 31)
        {
            if (day == birthday)
            {
                Debug.Log("It's my Birthday!");
            }
            else
            {
                Debug.Log(day);
            }
            day++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
