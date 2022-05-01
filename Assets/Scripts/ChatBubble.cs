using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum direction { Left, Right };

[CreateAssetMenu(fileName = "NewChatBubble", menuName = "Chat Bubble")]
public class ChatBubble : ScriptableObject
{
    

    [SerializeField] string Text;
    [SerializeField] int fontSize = 80;
    [SerializeField] float Duration;
    [SerializeField] bool Shake;

    [SerializeField] direction TailDirection;
    [SerializeField] Color Color = Color.black;

    [SerializeField] Sprite Shape;
    [SerializeField] AudioClip SFX;
    [SerializeField] TMP_FontAsset Font;
    

    /* Getters */
    public string GetText => Text;
    public int GetFontSize => fontSize;
    public float GetDuration => Duration;
    public bool GetShake => Shake;
    public direction GetDirection => TailDirection;
    public Color GetColor => Color;
    public Sprite GetShape => Shape;
    public AudioClip GetSFX => SFX;
    public TMP_FontAsset GetFont => Font;
}
