using UnityEngine;
using UnityEditor;

public class FlexibleUIInstance : Editor
{
    static GameObject clickedObject;

    [MenuItem("GameObject/Flelxible UI/Button", priority = 0)]
    public static void AddButton()
    {
        Create("UI/Button/Button");
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
