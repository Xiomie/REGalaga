using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Exitgame()
    {
        Application.Quit();
    }
   public void Loadlevel(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
