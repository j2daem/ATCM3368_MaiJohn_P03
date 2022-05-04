using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatBubbleManager : MonoBehaviour
{
    /*[SerializeField] ChatBubbleDisplay chatBubbleDisplay = null;

    private Queue<ChatBubble> bubbleQueue;

    private void Start()
    {
        bubbleQueue = new Queue<ChatBubble>();
    }

    public void StartChat(ChatBubble[] _chatBubbleList)
    {
        Debug.Log("Start of chat.");

        bubbleQueue.Clear();

        foreach (ChatBubble _chatBubble in _chatBubbleList)
        {
            bubbleQueue.Enqueue(_chatBubble);
        }

        DisplayNextBubble();
    }

    public void DisplayNextBubble()
    {
        if (bubbleQueue.Count == 0)
        {
            EndChat();
            return;
        }

        ChatBubble _chatBubble = bubbleQueue.Dequeue();
        chatBubbleDisplay.AssignBubble(_chatBubble);
    }

    public void EndChat()
    {
        Debug.Log("End of chat.");
    }*/
}
