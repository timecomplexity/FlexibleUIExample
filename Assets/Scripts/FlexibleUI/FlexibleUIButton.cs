using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class FlexibleUIButton : FlexibleUI
{
    private Image image;
    private Image icon;
    private Button button;
    [SerializeField]
    private ButtonType typeOfButton;

    public ButtonType TypeOfButton
    {
        get { return this.typeOfButton; }
        set { this.typeOfButton = value; }
    }

    protected override void OnSkinUI()
    {
        base.OnSkinUI();

        this.image = this.GetComponent<Image>();
        // Requires icon to be the title of the gameobject with the icon
        // Handled in prefab
        this.icon = this.transform.Find("Icon").GetComponent<Image>();
        this.button = this.GetComponent<Button>();

        this.button.transition = Selectable.Transition.SpriteSwap;
        this.button.targetGraphic = this.image;

        this.image.sprite = this.buttonSkinData.buttonSprite;
        this.image.type = Image.Type.Sliced;
        this.button.spriteState = this.buttonSkinData.buttonSpriteState;


        switch (this.TypeOfButton)
        {
            case ButtonType.DEFAULT:
                this.image.color = this.buttonSkinData.defaultColor;
                this.icon.sprite = this.buttonSkinData.defaultIcon;
                break;
            case ButtonType.CONFIRM:
                this.image.color = this.buttonSkinData.confirmColor;
                this.icon.sprite = this.buttonSkinData.confirmIcon;
                break;
            case ButtonType.DECLINE:
                this.image.color = this.buttonSkinData.declineColor;
                this.icon.sprite = this.buttonSkinData.declineIcon;
                break;
            case ButtonType.WARNING:
                this.image.color = this.buttonSkinData.warningColor;
                this.icon.sprite = this.buttonSkinData.warningIcon;
                break;
        }
    }


    public enum ButtonType
    {
        DEFAULT,
        CONFIRM,
        DECLINE,
        WARNING
    }
}
