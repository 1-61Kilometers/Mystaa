using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class sliderTransformer : MonoBehaviour
{
    public GameObject interactableObject;
    public PinchSlider sliderTranslateX;
    public PinchSlider sliderTranslateY;
    public PinchSlider sliderTranslateZ;
    public PinchSlider sliderRotateX;
    public PinchSlider sliderRotateY;
    public PinchSlider sliderRotateZ;

    void Start()
    {
    }

    void Update()
    {
    }

    public void translateX(float units)
    {
        float sliderPosition = sliderTranslateX.SliderValue;
        Vector3 increment = new Vector3(units, 0, 0);
        interactableObject.transform.position += increment * (sliderPosition - 0.5f);
    }

    public void translateY(float units)
    {
        float sliderPosition = sliderTranslateY.SliderValue;
        Vector3 increment = new Vector3(0, units, 0);
        interactableObject.transform.position += increment * (sliderPosition - 0.5f);
    }

    public void translateZ(float units)
    {
        float sliderPosition = sliderTranslateZ.SliderValue;
        Vector3 increment = new Vector3(0, 0, units);
        interactableObject.transform.position += increment * (sliderPosition - 0.5f);
    }

    public void rotateX(float degrees)
    {
        float sliderPosition = sliderRotateX.SliderValue;

        interactableObject.transform.Rotate(degrees * (sliderPosition - 0.5f), 0, 0, Space.World);
    }

    public void rotateY(float degrees)
    {
        float sliderPosition = sliderRotateY.SliderValue;
        interactableObject.transform.Rotate(0, degrees * (sliderPosition - 0.5f), 0, Space.World);
    }

    public void rotateZ(float degrees)
    {
        float sliderPosition = sliderRotateZ.SliderValue;
        interactableObject.transform.Rotate(0, 0, degrees * (sliderPosition - 0.5f), Space.World);
    }
}
