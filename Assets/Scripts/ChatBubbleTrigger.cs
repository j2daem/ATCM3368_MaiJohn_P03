using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatBubbleTrigger : MonoBehaviour
{
    [SerializeField] ChatBubbleDisplay chatBubbleDisplay = null;
    //[SerializeField] ChatBubbleManager chatBubbleManager = null;
    public ChatBubble[] chatBubbleList;

    int index = 0;

        private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //chatBubbleManager.StartChat(chatBubbleList);
            if (index != chatBubbleList.Length)
            {
                chatBubbleDisplay.AssignBubble(chatBubbleList[index]);
                chatBubbleDisplay.AssignBubbleValues();

                index++;
            }
        }
    }
}
