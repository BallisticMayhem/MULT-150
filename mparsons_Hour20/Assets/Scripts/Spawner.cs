using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject powerupPrefab;
    public GameObject obstaclePrefab;
    public GameObject obstacle2Prefab;
    public GameObject obstacle3Prefab;
    public float spawnCycle = .5f;

    GameManager manager;
    float elapsedTime;
    bool spawnPowerup = true;

    void Start()
    {
        manager = GetComponent<GameManager>();
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spawnCycle)
        {
            GameObject temp;

            if (spawnPowerup)
                temp = Instantiate(powerupPrefab) as GameObject;
            else if (Random.value > .5f)
                temp = Instantiate(obstaclePrefab) as GameObject;
            else if (Random.value > .5f)
                temp = Instantiate(obstacle2Prefab) as GameObject;
            else 
                temp = Instantiate(obstacle3Prefab) as GameObject;

            Vector3 position = temp.transform.position;
            position.x = Random.Range(-3f, 3f);
            temp.transform.position = position;

            Collidable col = temp.GetComponent<Collidable>();
            col.manager = manager;

            elapsedTime = 0;
            spawnPowerup = !spawnPowerup;
        }
    }
}
