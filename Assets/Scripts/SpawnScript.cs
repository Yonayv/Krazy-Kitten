using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
   
    public GameObject[] objectsToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)]);
    }

   
}
