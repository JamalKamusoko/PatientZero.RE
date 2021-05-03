using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoLevel : MonoBehaviour
{
    public void HeadtoLevel()
    {
        int levelCheck = PlayerPrefs.GetInt("GameStage");
        
        if (levelCheck <= 3)
        {
            SceneManager.LoadScene(3);
            SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(3));
        }
        if (levelCheck == 4)
        {
            SceneManager.LoadScene(4);
            SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(4));
        }
        if (levelCheck == 5)
        {
            SceneManager.LoadScene(5);
            SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(5));
        }
        if (levelCheck == 6)
        {
            SceneManager.LoadScene(6);
            SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(6));
        }
        
    }
}
