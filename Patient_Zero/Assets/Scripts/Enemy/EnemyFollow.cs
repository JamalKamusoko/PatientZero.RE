using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;

    public Transform target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update() {

        if (Vector3.Distance(transform.position, target.position) >1)
        {

            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }
    }
}
