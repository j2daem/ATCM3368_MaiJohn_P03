using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatBubbleTrigger : MonoBehaviour
{
    [SerializeField] ChatBubbleDisplay chatBubbleDisplay = null;
    public ChatBubble[] chatBubbleList;

        private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            chatBubbleDisplay.AssignBubble();
        }
    }
}
