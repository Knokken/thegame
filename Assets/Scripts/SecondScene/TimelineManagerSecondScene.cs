using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineManagerSecondScene : MonoBehaviour
{
    private bool fix = false;
    public PlayableDirector director;
    public static bool timelineActive = false;
    public Animator figure;
    private Animator cameraChange;

    // Start is called before the first frame update
    void OnEnable()
    {
        director = GetComponent<PlayableDirector>();
        cameraChange = GetComponent<Animator>();
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
            cameraChange.SetBool("Cutscene1", true);
            timelineActive = true;
            figure.SetTrigger("dissapear");
            return;
        }
        else if (director.state != PlayState.Playing)
        {
            cameraChange.SetBool("Cutscene1", false);
            timelineActive = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        director.Play();
        Destroy(gameObject.GetComponent<BoxCollider2D>());
        
    }
}
