﻿using UnityEngine;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    GameObject prompt = null;
    void OnTriggerEnter(Collider other)
    {
        GameObject canvas = GameObject.FindGameObjectWithTag("Canvas");
        this.prompt = (GameObject)Instantiate(Resources.Load("UI/Prompt/Prompt_NextLevel"), canvas.transform, false);
        Button[] buttons = this.prompt.GetComponentsInChildren<Button>();

        foreach (Button b in buttons)
        {
            switch (b.name)
            {
                case "Accept":
                    b.onClick.AddListener(() => Accept());
                    break;
                case "Decline":
                    b.onClick.AddListener(() => Decline());
                    break;
                default:
                    break;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.Decline();
    }

    public void Accept()
    {
        GameManager.instance.GoToNextLevel();
    }

    public void Decline()
    {
        if (this.prompt != null)
        {
            Destroy(this.prompt);
            this.prompt = null;
        }
    }
}
