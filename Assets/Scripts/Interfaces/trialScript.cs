using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class trialScript : MonoBehaviour
{
    public GameObject resizableCube;
    public PinchSlider resizerSlider;
    public GameObject resizableSphere;
    public GameObject resizableCylinder;
    public GameObject resizableCube2;
    public Vector3 originalCube2Scale;
    public Vector3 originalCube2Position;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void colorCube()
    {
        float sliderPosition = resizerSlider.SliderValue * 0.1f;
        resizableCube.transform.localScale = new Vector3(sliderPosition + 0.01f, sliderPosition + 0.01f, sliderPosition + 0.01f);
    }

    public void increaseSphereSize()
    {
        if (resizableSphere.transform.localScale.magnitude < 0.2)
        {
            resizableSphere.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        }
    }

    public void decreaseSphereSize()
    {
        if (resizableSphere.transform.localScale.magnitude > 0.05)
        {
            resizableSphere.transform.localScale += new Vector3(-0.01f, -0.01f, -0.01f);
        }
    }

    public void returnCylinderSize()
    {
        if (resizableCylinder.transform.localScale.magnitude < 0.05 || resizableCylinder.transform.localScale.magnitude > 0.25)
        {
            resizableCylinder.transform.localScale = new Vector3(0.05f, 0.025f, 0.05f);
        }

    }

    public void getCubePosition()
    {
        originalCube2Position = resizableCube2.transform.position;
    }

    public void returnCubeSize()
    {
        //  resizableCube2.transform.position = originalCube2Position;

        if (resizableCube2.transform.localScale.magnitude < 0.05 || resizableCube2.transform.localScale.magnitude > 0.25)
        {
            resizableCube2.transform.localScale = originalCube2Scale;
        }

    }
}
