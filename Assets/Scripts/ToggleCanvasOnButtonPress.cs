using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleCanvasOnButtonPress : MonoBehaviour
{
    public XRNode leftController;
    public GameObject canvas;

    private bool canvasVisible = false;
    private bool buttonPressed = false;

    void Start()
    {
        if (InputDevices.GetDeviceAtXRNode(leftController).TryGetFeatureValue(CommonUsages.menuButton, out bool primaryButtonValue))
        {
            canvasVisible = true;
            canvas.SetActive(true);
        }
    }

    void Update()
    {
        if (InputDevices.GetDeviceAtXRNode(leftController).TryGetFeatureValue(CommonUsages.menuButton, out bool primaryButtonValue))
        {
            if (primaryButtonValue && !buttonPressed)
            {
                buttonPressed = true;
                canvasVisible = !canvasVisible;
                canvas.SetActive(canvasVisible);
            }
            else if (!primaryButtonValue && buttonPressed)
            {
                buttonPressed = false;
            }
        }
    }
}


