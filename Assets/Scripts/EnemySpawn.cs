using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour


{

    public float timeToSpawn, spawnCountDown;

    public GameObject spawnedEnemy;


    // Start is called before the first frame update
    void Start()
    {
        spawnCountDown = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        spawnCountDown -= Time.deltaTime;

        if(spawnCountDown <= 0 )
        {
            spawnCountDown = timeToSpawn;
        }
    }
}
