using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class Jogging : MonoBehaviour
{
    public GameObject axis;
    public PinchSlider slider;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void rotateAxis(float degrees)
    {
        float speed = slider.SliderValue;
        axis.transform.Rotate((speed - 0.5f) * degrees, 0, 0, Space.Self);
    }

}
