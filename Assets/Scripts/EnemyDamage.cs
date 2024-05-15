using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamage : MonoBehaviour
{
    public Health health;
    public int damage;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.transform.name);
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Playerdamage");
            health.TakeDamage(damage);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }




}
