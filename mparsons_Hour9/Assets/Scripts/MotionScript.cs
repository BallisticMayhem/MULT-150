using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // use the arrow keys to move the object in the x and y directions
        float h = Input.GetAxis("Horizontal") / 10;
        float v = Input.GetAxis("Vertical") / 10;
        transform.Translate(h, v, 0);
    }
}
