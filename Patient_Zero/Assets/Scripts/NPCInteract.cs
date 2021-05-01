using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPCInteract : MonoBehaviour
{
    public NPCConversation TestConvo;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
       
            ConversationManager.Instance.StartConversation(TestConvo);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ConversationManager.Instance.EndConversation();
            
        }
    }
}
