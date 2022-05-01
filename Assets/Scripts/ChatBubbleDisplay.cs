using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChatBubbleDisplay : MonoBehaviour
{
    [SerializeField] ChatBubble chatBubble;

    [SerializeField] TextMeshProUGUI bubbleText;
    [SerializeField] Image bubbleShape;
    [SerializeField] AudioSource bubbleSFX;
    [SerializeField] Animator bubbleAnimator;

    void Start()
    {
        /* Text properties */
        bubbleText.text = chatBubble.GetText;
        bubbleText.font = chatBubble.GetFont;
        bubbleText.fontSize = chatBubble.GetFontSize;
        bubbleText.color = chatBubble.GetColor;

        bubbleShape.sprite = chatBubble.GetShape;
        bubbleSFX.clip = chatBubble.GetSFX;

        StartCoroutine(PlayAnimation());
        bubbleSFX.Play();
    }

    IEnumerator PlayAnimation()
    {
        
        if (chatBubble.GetShake)
        {
            bubbleAnimator.SetBool("shake", true);
        }

        yield return new WaitForSeconds(chatBubble.GetDuration);

        bubbleAnimator.SetBool("completed", true);
    }
}
