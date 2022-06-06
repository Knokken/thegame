using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningDialogueTriggerDestroy : MonoBehaviour
{
    public DialogueTrigger trigger;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true && TimelineManager.timelineActive == false)
        {
            trigger.StartDialogue();
            Destroy(gameObject.GetComponent<BoxCollider2D>());
        }
    }
}
