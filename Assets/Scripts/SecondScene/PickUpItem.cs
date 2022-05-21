using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public static bool isDestroyed = false;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true && Input.GetKey(KeyCode.E))
        {
            Destroy(gameObject.GetComponent<BoxCollider2D>());
            Destroy(gameObject, 1);
            isDestroyed = true;
        }
    }
}
