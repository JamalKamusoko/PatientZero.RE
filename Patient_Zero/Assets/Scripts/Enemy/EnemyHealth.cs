using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

	public int maxHealth = 10;
	public int currentHealth;

    public bool isHit = false;
	public HealthBar healthBar;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

	// Update is called once per frame
	private void Update()
	{
		if (isHit == true)
        {
			TakeDamage(5);
        }
	}

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);

		if (currentHealth <= 0)
		{
			Destroy(gameObject);
		}

	}

}