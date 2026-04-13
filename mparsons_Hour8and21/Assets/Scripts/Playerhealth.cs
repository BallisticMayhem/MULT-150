using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhealth : MonoBehaviour
{
    int healthpoints = 3992;
    // Start is called before the first frame update
    void Start()
    {
        healthpoints = UsePotion(healthpoints);
        Debug.Log("Player health is " + healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log("Player health is " + healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log("Player health is " + healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log("Player health is " + healthpoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int UsePotion(int health)
    {
        health += 400;
        return health;
    }
}
