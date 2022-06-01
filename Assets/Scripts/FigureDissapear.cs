using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureDissapear : MonoBehaviour
{
    public Animator figure;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        figure.SetTrigger("dissapear2");
        Destroy(gameObject.GetComponent<BoxCollider2D>());
    }
}
