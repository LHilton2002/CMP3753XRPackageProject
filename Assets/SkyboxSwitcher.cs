using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyboxSwitcher : MonoBehaviour
{
    public Material daySkybox;
    public Material nightSkybox;

    private bool isDay = true;

    public void SwitchSkybox()
    {
        if (isDay)
        {
            RenderSettings.skybox = nightSkybox;
            isDay = false;
        }
        else
        {
            RenderSettings.skybox = daySkybox;
            isDay = true;
        }
    }
}