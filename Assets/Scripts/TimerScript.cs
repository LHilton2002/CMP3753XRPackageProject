using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField] public Slider slider;
    [SerializeField] public TextMeshProUGUI durationText;
    [SerializeField] public TextMeshProUGUI timerText;
    [SerializeField] public bool timerSet = false;

    public float selectedTime = 0f;
    public float remainingTime = 0f;

    void Start()
    {
        slider.onValueChanged.AddListener((time) =>
        {
            //durationText.text = Mathf.FloorToInt(time * 60f).ToString() + "s";
            durationText.text = time.ToString("0.00");
        });
    }

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            timerText.text = "Time Left: " + Mathf.FloorToInt(remainingTime / 60f).ToString() + "m " + Mathf.FloorToInt(remainingTime % 60f).ToString() + "s";
        }
        else if (timerSet)
        {
            timerText.text = "Time's Up!";
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioSource.clip);
            StartCoroutine(StopAudio(audioSource.clip.length));
        }
    }

    public IEnumerator StopAudio(float delay)
    {
        yield return new WaitForSeconds(delay);
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
    }

    public void DisplaySelectedTime()
    {
        selectedTime = slider.value;
        remainingTime = selectedTime * 60f;
        Debug.Log(selectedTime.ToString("0:00"));
        timerSet = true;
    }
}
