using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FlexibleUI : MonoBehaviour
{
    public FlexibleUIButtonData buttonSkinData;
    public FlexibleUITextBoxData textBoxSkinData;

    public virtual void Awake()
    {
        this.OnSkinUI();
    }

    protected virtual void OnSkinUI()
    {

    }

    public virtual void Update()
    {
        if (Application.isEditor)
        {
            this.OnSkinUI();
        }
    }
}
