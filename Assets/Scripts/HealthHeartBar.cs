using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHeartBar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject heartPrefab;
    public PlayerHealth playerHealth;

    List<HealthHeartBar> hearts = new List<HealthHeartBar>();

    public void CreateEmptyHeart()
    {
        GameObject newHeart = Instantiate(heartPrefab); 
        newHeart.transform.SetParent(transform);

        HealthHeart1 heartComponent = newHeart.GetComponent<HealthHeart1>();
        

      
    }

    public void ClearHearts()
    {
        foreach(Transform t in transform)
        {
            Destroy(t.gameObject);
        }

        hearts = new List<HealthHeartBar>();
            
    }
}
