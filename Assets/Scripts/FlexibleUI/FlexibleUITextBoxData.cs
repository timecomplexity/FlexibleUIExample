using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Flexible UI/Text Box Data")]
public class FlexibleUITextBoxData : ScriptableObject
{
    [Header("Text Box Settings")]
    public Sprite backgroundSprite;
    public string text;
}
