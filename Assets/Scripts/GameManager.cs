using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    private GameObject pauseMenu = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Delete the pause menu if it's already open
            if (this.pauseMenu != null)
            {
                Destroy(this.pauseMenu);
                return;
            }

            GameObject canvas = GameObject.FindGameObjectWithTag("Canvas");
            this.pauseMenu = (GameObject)Instantiate(Resources.Load("UI/TextBox/PauseMenu_TextBox"), canvas.transform, false);
        }
    }

    public void GoToNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoToPreviousLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
