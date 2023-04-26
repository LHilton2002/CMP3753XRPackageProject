using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerButtonScript : MonoBehaviour
{
    public Slider slider;

    public void SetTimer()
    {
        float timerValue = slider.value;
        Debug.Log(timerValue + " minutes");
    }
}
