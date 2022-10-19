using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenuScript : MonoBehaviour
{
    public GameObject menu;
    public TextMeshProUGUI testingText;
    public KeyCode testingKey;
    public bool isPaused = false;

    void Start()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(testingKey))
        {
            testingText.text = "Down";
        }
        else if (Input.GetKey(testingKey))
        {
            testingText.text = "Hold";
        }
        else if (Input.GetKeyUp(testingKey))
        {
            testingText.text = "Up";
        }
        else
        {
        }

        if (Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
    }

    public void TogglePauseGame()
    {
        isPaused = !isPaused;
        menu.SetActive(isPaused);
        if (isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
