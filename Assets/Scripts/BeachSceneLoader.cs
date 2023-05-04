using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeachSceneLoader : MonoBehaviour
{
    public void LoadBeachScene()
    {
        SceneManager.LoadScene("BeachScene");
    }
}
