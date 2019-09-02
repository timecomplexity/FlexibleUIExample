using UnityEngine;
using UnityEditor;

public class FlexibleUIInstance : Editor
{
    static GameObject clickedObject;

    [MenuItem("GameObject/Flexible UI/Button", priority = 0)]
    public static void AddButton()
    {
        Create("UI/Button/Button");
    }

    [MenuItem("GameObject/Flexible UI/TextBox", priority = 1)]
    public static void AddTextBox()
    {
        Create("UI/TextBox/TextBox");
    }


    private static GameObject Create(string objectName)
    {
        GameObject instance = Instantiate(Resources.Load<GameObject>(objectName));
        instance.name = objectName;
        clickedObject = UnityEditor.Selection.activeObject as GameObject;

        if (clickedObject != null)
        {
            instance.transform.SetParent(clickedObject.transform, false);
        }

        return instance;
    }
}
