using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Flexible UI/Button Data")]
public class FlexibleUIButtonData : ScriptableObject
{
    [Header("Button Settings")]
    public Sprite buttonSprite;
    public SpriteState buttonSpriteState;

    [Header("Color and Icon Settings")]
    public Color defaultColor;
    public Sprite defaultIcon;
    public Color confirmColor;
    public Sprite confirmIcon;
    public Color declineColor;
    public Sprite declineIcon;
    public Color warningColor;
    public Sprite warningIcon;
}
