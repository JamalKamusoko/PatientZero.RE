using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JammoHP : MonoBehaviour

{
    public int startingHealth;                            // The amount of health the player starts the game with.
    public int currentHealth;                                   // The current health the player has.
    public Slider healthslider;                                       // Reference to the UI's health bar.                                 
    public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.
    bool damaged;                                               // True when the player gets damaged.
    public GameObject HUD;
    public int index;

    void Awake()
    {
   
        HUD.gameObject.SetActive(true);
     
        // Set the initial health of the player.
        currentHealth = startingHealth;
    }

    void FixedUpdate()
    {
        
    }

    public void TakeDamage(int amount)
    {
        // Set the damaged flag so the screen will flash.
        damaged = true;

        // Reduce the current health by the damage amount.
        currentHealth -= amount;

        // Set the health bar's value to the current health.
        healthslider.value = currentHealth;


        // If the player has lost all it's health and the death flag hasn't been set yet...
        if (currentHealth <= 0)
        {

            // ... it should die.
            Destroy(gameObject);
            SceneManager.LoadScene(index);
            HUD.gameObject.SetActive(false);
        }
    }
}

