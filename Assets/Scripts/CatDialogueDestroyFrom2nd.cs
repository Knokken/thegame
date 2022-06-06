using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatDialogueDestroyFrom2nd : MonoBehaviour
{
    public DialogueTriggerCat2 trigger;

    public static bool cannotGo = true;

    private void Start()
    {

    }
    IEnumerator WaitForDialogue()
    {
        yield return new WaitForSeconds(8);
        trigger.StartDialogueCat2();
        cannotGo = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true && PickUpItem.isDestroyed == true && cannotGo == true)
        {
            StartCoroutine(WaitForDialogue());
            Destroy(gameObject.GetComponent<BoxCollider2D>());
            return;
        }
    }

    private void Update()
    {
        if (cannotGo == false)
        {
            cannotGo = true;
        }
    }
}
