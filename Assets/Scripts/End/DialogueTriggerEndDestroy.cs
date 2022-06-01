using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerEndDestroy : MonoBehaviour
{
    public DialogueTrigger trigger;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true && TimelineManager.timelineActive == false)
        {
            trigger.StartDialogue();
            Destroy(gameObject.GetComponent<BoxCollider2D>());
        }
    }
}
