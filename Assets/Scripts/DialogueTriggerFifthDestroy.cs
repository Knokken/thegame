using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerFifthDestroy : MonoBehaviour
{
    public DialogueTriggerFigure trigger;
    public Animator camAnim;
    //public static bool stopMoving = false;

    private void Start()
    {

    }

    IEnumerator WaitForDialogue()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject.GetComponent<BoxCollider2D>());
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true && WalkingTrigger.timelineActive == false)
        {
            camAnim.SetBool("cameraChange", true);
            trigger.StartDialogueFigure();
            StartCoroutine(WaitForDialogue());
            return;
        }
    }
}
