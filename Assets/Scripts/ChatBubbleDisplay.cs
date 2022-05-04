using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/* Assigns values of ChatBubble scriptable object to appear on UI*/
public class ChatBubbleDisplay : MonoBehaviour
{
    [SerializeField] ChatBubble chatBubble;

    [SerializeField] Transform bubbleScale;
    [SerializeField] TextMeshProUGUI bubbleText;
    [SerializeField] Image bubbleShape;
    [SerializeField] AudioSource bubbleSFX;
    [SerializeField] Animator bubbleAnimator;

    public void AssignBubble()
    {
        /* Text properties */
        bubbleText.text = chatBubble.GetText;

        if (chatBubble.GetFont != null)
        {
            bubbleText.font = chatBubble.GetFont;
        }
        
        bubbleText.fontStyle = chatBubble.GetFontStyle;
        bubbleText.fontSize = chatBubble.GetFontSize;
        bubbleText.color = chatBubble.GetColor;
        bubbleScale.localScale = new Vector3(chatBubble.GetScaleX, chatBubble.GetScaleY, 1);

        bubbleShape.sprite = chatBubble.GetShape;
        bubbleSFX.clip = chatBubble.GetSFX;

        bubbleSFX.Play();
        StartCoroutine(OpenBubble());
    }

    IEnumerator OpenBubble()
    {
        bubbleAnimator.SetBool("open", true);

        if (chatBubble.GetShake)
        {
            bubbleAnimator.SetBool("shake", true);
        }

        yield return new WaitForSeconds(chatBubble.GetDuration);

        bubbleAnimator.SetBool("open", false);
    }
}
