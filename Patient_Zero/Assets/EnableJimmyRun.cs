using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableJimmyRun : MonoBehaviour
{
    private void Start()
    {
        GetComponent<JimmyRun>().enabled = false;
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<JimmyRun>().enabled = true;
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
