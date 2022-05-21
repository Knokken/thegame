using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TookItem : MonoBehaviour
{
    public Image item;
    public RectTransform blackness;
    private AudioSource itemSound;

    public static bool isActive = false;
    public static bool isDestroyed = false;

    // Start is called before the first frame update
    void Start()
    {
        blackness.transform.localScale = Vector3.zero;
        itemSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (isDestroyed == true)
        {
            itemSound.Stop();
            isActive = false;
        }*/
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true && Input.GetKey(KeyCode.E))
        {
            isActive = true;
            blackness.LeanScale(Vector3.one, 0.5f).setEaseInOutExpo();
            itemSound.Play();
            Destroy(gameObject.GetComponent<BoxCollider2D>());
            isDestroyed = true;
        }
    }

}
