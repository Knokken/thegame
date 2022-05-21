using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerColliderForDialogue : MonoBehaviour
{
    public DialogueTrigger trigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true && TimelineManager.timelineActive == false)
        {
            trigger.StartDialogue();
        }
    }
    
}
