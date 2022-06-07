using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlacknessCountdown2 : MonoBehaviour
{
    private float timer = 4f;

    private void Start()
    {

    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}