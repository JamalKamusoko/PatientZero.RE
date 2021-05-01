using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ChangeState : MonoBehaviour
{
    public void ChangeGameState()
    {
        int gamestate = PlayerPrefs.GetInt("GameStage");
        ConversationManager.Instance.SetInt("GameStage", gamestate);
    }

    public void ResetStates()
    {
        PlayerPrefs.DeleteAll();
    }
}
