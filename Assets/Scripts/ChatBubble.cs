using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum Direction { Left, Right };

[CreateAssetMenu(fileName = "NewChatBubble", menuName = "Chat Bubble")]
public class ChatBubble : ScriptableObject
{
    [TextArea(3,5)]
    [SerializeField] string text;
    [SerializeField] int fontSize = 80;
    [SerializeField] float duration;
    [SerializeField] float PosX = 0;
    [SerializeField] float PosY = 0;
    [SerializeField] float ScaleX = 1;
    [SerializeField] float ScaleY = 1;
    [SerializeField] bool shake;

    [SerializeField] Direction tailDirection;
    [SerializeField] TMPro.FontStyles fontStyle;
    [SerializeField] Color Color = Color.black;

    [SerializeField] Sprite shape;
    [SerializeField] AudioClip sFX;
    [SerializeField] TMP_FontAsset font;
    

    /* Getters */
    public string GetText => text;
    public int GetFontSize => fontSize;
    public float GetDuration => duration;
    public float GetPosX => PosX;
    public float GetPosY => PosY;
    public float GetScaleX => ScaleX;
    public float GetScaleY => ScaleY;
    public bool GetShake => shake;
    public Direction GetDirection => tailDirection;
    public TMPro.FontStyles GetFontStyle => fontStyle;
    public Color GetColor => Color;
    public Sprite GetShape => shape;
    public AudioClip GetSFX => sFX;
    public TMP_FontAsset GetFont => font;
}
