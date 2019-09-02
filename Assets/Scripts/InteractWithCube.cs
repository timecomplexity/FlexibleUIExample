using UnityEngine;
using UnityEngine.UI;

public class InteractWithCube : MonoBehaviour
{
    private GameObject tooltip = null;

    private void OnMouseDown()
    {
        GameObject canvas = GameObject.FindGameObjectWithTag("Canvas");
        this.tooltip = (GameObject)Instantiate(Resources.Load("UI/TextBox/TextBox"), canvas.transform, false);
        this.tooltip.GetComponent<FlexibleUITextBox>().textBoxSkinData = (FlexibleUITextBoxData)Resources.Load("Data/TextBoxes/TextBox_Tooltip_BlueBox");
        Transform trans = canvas.transform;
        trans.position = new Vector3(
            trans.position.x,
            trans.position.y,
            trans.position.z
            );
        GameObject closeButton = (GameObject)Instantiate(Resources.Load("UI/Button/Button"), canvas.transform, false);
        closeButton.GetComponent<Button>().onClick.AddListener(() => CloseToolTip(closeButton));
        closeButton.GetComponent<FlexibleUIButton>().TypeOfButton = FlexibleUIButton.ButtonType.CONFIRM;
    }


    private void CloseToolTip(GameObject closeButton)
    {
        Destroy(this.tooltip);
        this.tooltip = null;
        Destroy(closeButton);
    }
}
