using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class BreathingExerciseButtonTextController : MonoBehaviour
{
    public BreathingExercise breathingExercise;
    public TextMeshProUGUI buttonText;

    void Start()
    {
        buttonText.text = "START BREATHING EXERCISE";
    }

    void Update()
    {
        if (breathingExercise.isExerciseRunning)
        {
            buttonText.text = "STOP BREATHING EXERCISE";
        }
        else
        {
            buttonText.text = "START BREATHING EXERCISE";
        }
    }

    public void OnButtonClick()
    {
        breathingExercise.ToggleExercise();
    }
}
