using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;     // The time in seconds between each attack.
    public int attackDamage;               // The amount of health taken away per attack.
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;


    Animator anim;                              // Reference to the animator component.
    GameObject player;                          // Reference to the player GameObject.
    // Reference to the player's health.
    EnemyBehaviour enemyHealth;                 // Reference to this enemy's health.
    bool playerInRange;                         // Whether player is within the trigger collider and can be attacked.
    float timer;                                // Timer for counting up to the next attack.


    void Awake()
    {
        // Setting up the references.
        player = GameObject.FindGameObjectWithTag("Player");
       //playerHealth = player.GetComponent<JammoHP>();
        enemyHealth = GetComponent<EnemyBehaviour>();
    }
 

    void Update()
    {
        // Add the time since Update was last called to the timer.
        timer += Time.deltaTime;

        // If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
        if (timer >= timeBetweenAttacks)
        {
            Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
            for (int i = 0; i < enemiesToDamage.Length; i++)
            {
               // enemiesToDamage[i].GetComponent<>().TakeDamage(attackDamage);
               
            }

        }
        else
        {
            
            return;
        }
    }


    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}

