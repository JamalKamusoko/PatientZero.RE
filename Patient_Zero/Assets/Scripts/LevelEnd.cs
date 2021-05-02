using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DialogueEditor;

public class LevelEnd : MonoBehaviour
{
    public int changeStage;
    public int nextSceneIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("GameStage", changeStage);
            ReturntoHub(nextSceneIndex);
        }    
    }

    public void ReturntoHub(int sceneName)
    {
        SceneManager.LoadScene(sceneName);
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(sceneName));
    }

}

