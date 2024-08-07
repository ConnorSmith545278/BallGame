using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        if (sceneName == "Level1")
        {
            Destroy(GameObject.FindWithTag("GameManager"));
        }
        SceneManager.LoadScene(sceneName);
    }
}
