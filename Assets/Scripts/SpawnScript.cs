using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject[] spawnObjects;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawnObjects[Random.Range(0, spawnObjects.Length)], this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
