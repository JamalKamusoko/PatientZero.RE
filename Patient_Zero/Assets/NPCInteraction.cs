using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPCInteraction : MonoBehaviour
{
    public GameObject UIforDialogue;
    public NPCConversation missions;
    private int gameStage;
    

    private void Start()
    {
        UIforDialogue.SetActive(false);
        int compStage = ConversationManager.Instance.GetInt("GameStage");
        gameStage = PlayerPrefs.GetInt("MissionsDone");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UIforDialogue.SetActive(true);
            ConversationManager.Instance.StartConversation(missions);
            ConversationManager.Instance.SetInt("GameStage", gameStage);
        }
    }
}
