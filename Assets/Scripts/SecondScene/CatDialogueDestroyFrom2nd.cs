using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatDialogueDestroyFrom2nd : MonoBehaviour
{
    public DialogueTriggerCat2 trigger;

    private void Start()
    {

    }
    IEnumerator WaitForDialogue()
    {
        yield return new WaitForSeconds(8);
        trigger.StartDialogueCat2();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true && PickUpItem.isDestroyed == true)
        {
            StartCoroutine(WaitForDialogue());
            Destroy(gameObject.GetComponent<BoxCollider2D>());
            return;
        }
    }
}
