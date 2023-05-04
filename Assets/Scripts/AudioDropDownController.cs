using UnityEngine;
using UnityEngine.UI;

public class AudioDropDownController : MonoBehaviour
{
    public AudioSource audioSource; // Assign the audio source in the Inspector
    public Dropdown soundDropdown; // Assign the sound dropdown menu in the Inspector

    public AudioClip[] sounds; // Assign the available sounds in the Inspector

    void Start()
    {
        // Add options to the sound dropdown menu
        soundDropdown.ClearOptions();
        foreach (var sound in sounds)
        {
            soundDropdown.options.Add(new Dropdown.OptionData(sound.name));
        }

        // Add a listener to the sound dropdown menu
        soundDropdown.onValueChanged.AddListener(delegate { PlaySelectedSound(); });
    }

    void PlaySelectedSound()
    {
        // Play the selected sound
        int index = soundDropdown.value;
        audioSource.clip = sounds[index];
        audioSource.Play();
    }
}
