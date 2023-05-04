using UnityEngine;
using UnityEngine.UI;

public class ToggleRainControl : MonoBehaviour
{
    public ParticleSystem rainParticles; // Assign the rain particle system in the Inspector
    public Button rainToggleButton; // Assign the rain toggle button in the Inspector

    void Start()
    {
        rainParticles.Stop();
        // Add a listener to the rain toggle button
        rainToggleButton.onClick.AddListener(ToggleRainParticles);
    }

    void ToggleRainParticles()
    {
        // Toggle the rain particle system on or off depending on its current state
        if (rainParticles.isPlaying)
        {
            rainParticles.Stop();
        }
        else
        {
            rainParticles.Play();
        }
    }
}