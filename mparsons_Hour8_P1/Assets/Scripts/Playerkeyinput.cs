using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerkeyinput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.M))
            print("The 'M' key is pressed down");
        if(Input.GetKeyDown(KeyCode.O))
            print("The 'O' key was pressed down");
    }
}
