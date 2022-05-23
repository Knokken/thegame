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

    public void OpenItemImage()
    {
        isActive = true;
        blackness.LeanScale(Vector3.one, 0.5f).setEaseInOutExpo();
        itemSound.Play();
        Destroy(gameObject.GetComponent<BoxCollider2D>());
        isDestroyed = true;
    }

    void Start()
    {
        blackness.transform.localScale = Vector3.zero;
        itemSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isActive == true)
        {
            blackness.transform.localScale = Vector3.zero;
            itemSound.Stop();
        }
    }

}
