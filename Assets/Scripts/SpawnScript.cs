using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
   
    public GameObject[] objectsToSpawn;
    public Transform[] SpawnLocations; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, 10f);
        
    }
    /// Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)], SpawnLocations[Random.Range(0,SpawnLocations.Length)]);

    private void Spawn()
    {
        for (int i = 0; i < objectsToSpawn.Length; i++)
        {
            Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)], SpawnLocations[Random.Range(0, SpawnLocations.Length)]);
        }
    }

}
