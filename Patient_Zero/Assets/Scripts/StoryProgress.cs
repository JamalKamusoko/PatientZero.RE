using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryProgress : MonoBehaviour
{
    [Header("Story 1 Town 1")]
    public GameObject beActiveone;
    public GameObject NPCDeath1;

    [Header("Story 2 Town 2")]
    public GameObject beActivetwo;
    public GameObject NPCDeath2;

    [Header("Story 3 Town 3")]
    public GameObject beActivethree;
    public GameObject NPCDeath3;

    [Header("Story 4 Town 4")]
    public GameObject beActivefour;
    public GameObject NPCDeathFour;

    [Header("Story 5 Shopping")]
    public GameObject beActivefive;
    public GameObject NPCDeathFive;

    [Header("Story 6 Hospital")]
    public GameObject beActivesix;
    public GameObject NPCDeathSix;

    private void Start()
    {
        int stageCurrent = PlayerPrefs.GetInt("GameStage");

        if (stageCurrent == 0)
        {
            return;
        }
        else if(stageCurrent == 1)
        {
            beActiveone.SetActive(true);
            NPCDeath1.SetActive(false);
        }
        else if (stageCurrent == 2)
        {
            beActivetwo.SetActive(true);
            NPCDeath2.SetActive(false);
        }
        else if (stageCurrent == 3)
        {
            beActivethree.SetActive(true);
            NPCDeath3.SetActive(false);
        }
        else if (stageCurrent == 4)
        {
            beActivefour.SetActive(true);
            NPCDeathFour.SetActive(false);
        }
        else if (stageCurrent == 5)
        {
            beActivefive.SetActive(true);
            NPCDeathFive.SetActive(false);
        }
        else if (stageCurrent == 6)
        {
            beActivesix.SetActive(true);
            NPCDeathSix.SetActive(false);
        }
        else
        {
            PlayerPrefs.DeleteAll();
        }

    }
       
}
