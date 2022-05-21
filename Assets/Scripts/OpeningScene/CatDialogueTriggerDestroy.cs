using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatDialogueTriggerDestroy : MonoBehaviour
{
    public DialogueTriggerCat trigger;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true && TimelineManagerCat.timelineActive == false)
        {
            trigger.StartDialogueCat();
            Destroy(gameObject.GetComponent<BoxCollider2D>());
        }
    }
}
