using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerFifthDestroy : MonoBehaviour
{
    public DialogueTriggerCat2 trigger;
    //public static bool stopMoving = false;

    private void Start()
    {

    }

    IEnumerator WaitForDialogue()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject.GetComponent<BoxCollider2D>());
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true && WalkingTrigger.timelineActive == false)
        {
            trigger.StartDialogueCat2();
            StartCoroutine(WaitForDialogue());
            return;
        }
    }*/
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true && WalkingTrigger.timelineActive == false)
        {
            trigger.StartDialogueCat2();
            StartCoroutine(WaitForDialogue());
            return;
        }
    }
}
