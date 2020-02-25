using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newscene : MonoBehaviour
{

    public void SceneTransition(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("LoadScene");
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}