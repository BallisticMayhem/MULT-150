using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    private Light lightComponent;
    
    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();  
    }

    // Update is called once per frame
    void Update()
    {
        bool keyPressed = Input.GetKeyDown(KeyCode.L);

        if(keyPressed)
            lightComponent.enabled = !lightComponent.enabled;


    }
}
