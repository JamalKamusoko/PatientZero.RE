using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBehaviour : MonoBehaviour
{
    public int health;
    public float speed;
    private float dazedTime;
    public float startDazedTime;
    public Text HP;
    void Start()
    {
        HP = GameObject.Find("health").GetComponent<Text>();
        HP.text = "";
    }
    void Update()

    {
        if (dazedTime <= 0)
        {
            speed = 5;
        }
        else
        {
            speed = 0;
            dazedTime -= Time.deltaTime;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        HP.text = "HP:" + health.ToString();
    }

    public void TakeDamage(int damage)
    {
        dazedTime = startDazedTime;
        //play a hurt sound
        health -= damage;
        Debug.Log("damage TAKEN!!");
    }
    
}
