using UnityEngine;
using UnityEngine.UI;

public class ToggleMusicScript : MonoBehaviour
{
    public AudioSource backgroundMusic;
    public Button toggleButton;

    private bool isPlaying = true;

    void Start()
    {
        toggleButton.onClick.AddListener(ToggleMusic);
    }

    void ToggleMusic()
    {
        if (isPlaying)
        {
            backgroundMusic.Pause();
            isPlaying = false;
        }
        else
        {
            backgroundMusic.Play();
            isPlaying = true;
        }
    }
}
