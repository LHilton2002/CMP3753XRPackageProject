using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class BreathingExercise : MonoBehaviour
{
    public TextMeshProUGUI exerciseText;
    public Button startStopButton;

    public bool isExerciseRunning = false;
    private Coroutine breathingCoroutine;

    void Start()
    {
        exerciseText.text = "Press the start button to begin.";
        startStopButton.onClick.AddListener(ToggleExercise);
    }

    public void ToggleExercise()
    {
        if (isExerciseRunning)
        {
            StopCoroutine(breathingCoroutine);
            isExerciseRunning = false;
            exerciseText.text = "Press the start button to begin.";
        }
        else
        {
            breathingCoroutine = StartCoroutine(BreathingCoroutine());
            isExerciseRunning = true;
        }
    }

    IEnumerator BreathingCoroutine()
    {
        while (true) // Loop indefinitely
        {
            exerciseText.text = "Breathe in...";
            yield return new WaitForSeconds(4f);

            exerciseText.text = "Hold...";
            yield return new WaitForSeconds(4f);

            exerciseText.text = "Breathe out...";
            yield return new WaitForSeconds(4f);

            exerciseText.text = "Hold...";
            yield return new WaitForSeconds(4f);
        }
    }
}
