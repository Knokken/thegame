using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManagerCat2 : MonoBehaviour
{
    public Image actorImage;
    public TMP_Text messageText;
    public RectTransform backgroundBox;
    private AudioSource dialogueSound;
    private Animator anim;

    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0;
    public static bool isActive = false;
    public static bool cannotGo = true;
    public static bool girlMoves = false;
    public static bool dialogueEnded = false;

    public void OpenDialogue(Message[] messages, Actor[] actors)
    {
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;
        Debug.Log("Start! Loaded messages: " + messages.Length);
        DisplayMessage();
        backgroundBox.LeanScale(Vector3.one, 0.5f).setEaseInOutExpo();
        dialogueSound.Play();
        cannotGo = true;
        girlMoves = false;
    }

    void DisplayMessage()
    {
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;

        Actor actorToDisplay = currentActors[messageToDisplay.actorID];
        actorImage.sprite = actorToDisplay.sprite;
    }

    public void NextMessage()
    {
        activeMessage++;
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else
        {
            Debug.Log("Conversation ended.");
            backgroundBox.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo();
            isActive = false;
            dialogueSound.Stop();
            cannotGo = false;
            girlMoves = true;
            dialogueEnded = true;
        }
    }

    void Start()
    {
        backgroundBox.transform.localScale = Vector3.zero;
        dialogueSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isActive == true)
        {
            NextMessage();
        }
    }
}
