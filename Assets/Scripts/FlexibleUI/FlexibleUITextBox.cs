using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FlexibleUITextBox : FlexibleUI
{
    private TextMeshProUGUI text;
    private Image background;

    protected override void OnSkinUI()
    {
        base.OnSkinUI();

        this.background = this.GetComponent<Image>();
        this.text = this.transform.Find("Text").GetComponent<TextMeshProUGUI>();

        this.background.sprite = this.textBoxSkinData.backgroundSprite;
        this.text.text = this.textBoxSkinData.text;
    }
}
