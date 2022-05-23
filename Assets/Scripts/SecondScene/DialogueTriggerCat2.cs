using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerCat2 : MonoBehaviour
{
    public Message[] messagesCat2;
    public Actor[] actorsCat2;

    public void StartDialogueCat2()
    {
        FindObjectOfType<DialogueManagerCat2>().OpenDialogue(messagesCat2, actorsCat2);
    }

}

//You can write actorID, message and sprite in specific place in Unity
[System.Serializable]
public class MessageCat2
{
    public int actorID;
    public string message;
}

[System.Serializable]
public class ActorCat2
{
    public Sprite sprite;
}
