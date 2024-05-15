using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
   
    public int health;
    public int numOfHearts;

   

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite halfHeart;
    public Sprite emptyHeart;
    public int maxHealth = 6;
    public GameManagerScript gameManager;
    private bool isDead;


 

    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage( int damage)
    {
        health -= damage;
        if (health <= 0 && !isDead)
        {
            isDead = true;
            Destroy(gameObject);
            gameManager.gameOver();
            LevelManager.instance.Respawn();
            Debug.Log("Dead");
        }
    }
    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {

            if(i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;  
            }


            if (health > numOfHearts)
            {
                health = numOfHearts;
            }



            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }


        }

    }

}
