using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForestSceneLoader : MonoBehaviour
{
    public void LoadForestScene()
    {
        SceneManager.LoadScene("ForestScene", LoadSceneMode.Single);
    }
}

