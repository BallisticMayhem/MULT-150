using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    int bounceCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        bounceCount++;
        Debug.Log("Bounce count: " + bounceCount);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
