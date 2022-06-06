using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineManagerHoldHands : MonoBehaviour
{
    private bool fix = false;
    public PlayableDirector director;
    public static bool timelineActive = false;

    // Start is called before the first frame update
    void OnEnable()
    {
        director = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (director.state != PlayState.Playing && !fix)
        {
            fix = true;
        }
        if (director.state == PlayState.Playing)
        {
            timelineActive = true;
        }
        else if (director.state != PlayState.Playing)
        {
            timelineActive = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            director.Play();
            Destroy(gameObject.GetComponent<BoxCollider2D>());
        }
           
    }

}
