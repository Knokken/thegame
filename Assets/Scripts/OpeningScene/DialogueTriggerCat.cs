using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerCat : MonoBehaviour
{
    public Message[] messagesCat;
    public Actor[] actorsCat;

    public void StartDialogueCat()
    {
        FindObjectOfType<DialogueManagerCat>().OpenDialogue(messagesCat, actorsCat);
    }

}

//You can write actorID, message and sprite in specific place in Unity
[System.Serializable]
public class MessageCat
{
    public int actorID;
    public string message;
}

[System.Serializable]
public class ActorCat
{
    public Sprite sprite;
}
