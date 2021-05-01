using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class LevelEnd : MonoBehaviour
{
    public int changeStage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("GameStage", changeStage);
        }
    }
}

