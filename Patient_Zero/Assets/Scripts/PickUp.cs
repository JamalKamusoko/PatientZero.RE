using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject pickedUp;
    public GameObject newActive;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pickedUp.SetActive(false);
            newActive.SetActive(true);
        }
    }
}
