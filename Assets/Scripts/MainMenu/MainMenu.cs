using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public Animator fade;

    public void PlayGame ()
    {
        //fade.SetBool("Start", true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        //fade.SetTrigger("Start");
        Application.Quit();
        Debug.Log("Ended");
    }

    
}
