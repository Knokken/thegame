using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerFigure : MonoBehaviour
{
    public Message[] messagesFigure;
    public Actor[] actorsFigure;

    public void StartDialogueFigure()
    {
        FindObjectOfType<DialogueManagerFigure>().OpenDialogue(messagesFigure, actorsFigure);
    }

}

//You can write actorID, message and sprite in specific place in Unity
[System.Serializable]
public class MessageFigure
{
    public int actorID;
    public string message;
}

[System.Serializable]
public class ActorFigure
{
    public Sprite sprite;
}
