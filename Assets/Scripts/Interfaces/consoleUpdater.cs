using UnityEngine;
using TMPro;
using System;

public class consoleUpdater : MonoBehaviour
{
    public GameObject trackableObject;

    public double translateX;
    public double translateY;
    public double translateZ;

    public double rotateX;
    public double rotateY;
    public double rotateZ;

    public Vector3 initialTranslation;

    public TextMeshPro translateXLabel;
    public TextMeshPro translateYLabel;
    public TextMeshPro translateZLabel;

    public TextMeshPro rotateXLabel;
    public TextMeshPro rotateYLabel;
    public TextMeshPro rotateZLabel;

    void Start()
    {
        initialTranslation = trackableObject.transform.position;
    }

    void Update()
    {
        updateValues();
        updateLabels();
        validateResults();
    }

    public void updateValues()
    {
        translateX = (int)Math.Round(100 * (trackableObject.transform.position.x - initialTranslation.x));
        translateY = (int)Math.Round(100 * (trackableObject.transform.position.y - initialTranslation.y));
        translateZ = (int)Math.Round(100 * (trackableObject.transform.position.z - initialTranslation.z));

        rotateX = (int)Math.Round(trackableObject.transform.rotation.eulerAngles.x);
        rotateY = (int)Math.Round(trackableObject.transform.rotation.eulerAngles.y);
        rotateZ = (int)Math.Round(trackableObject.transform.rotation.eulerAngles.z);
    }

    public void updateLabels()
    {
        translateXLabel.text = translateX.ToString();
        translateYLabel.text = translateY.ToString();
        translateZLabel.text = translateZ.ToString();

        rotateXLabel.text = rotateX.ToString();
        rotateYLabel.text = rotateY.ToString();
        rotateZLabel.text = rotateZ.ToString();
    }

    public void validateResults()
    {
        if (translateX <= -4 && translateX >= -6)
        {
            translateXLabel.color = Color.green;
        }
        else
        {
            translateXLabel.color = Color.white;
        }

        if (translateY <= -34 && translateY >= -36)
        {
            translateYLabel.color = Color.green;
        }
        else
        {
            translateYLabel.color = Color.white;
        }

        if (translateZ <= -9 && translateZ >= -11)
        {
            translateZLabel.color = Color.green;
        }
        else
        {
            translateZLabel.color = Color.white;
        }

        if (rotateX <= 1 || rotateX >= 360)
        {
            rotateXLabel.color = Color.green;
        }
        else
        {
            rotateXLabel.color = Color.white;
        }

        if (rotateY <= 1 || rotateY >= 360)
        {
            rotateYLabel.color = Color.green;
        }
        else
        {
            rotateYLabel.color = Color.white;
        }

        if (rotateZ <= 1 || rotateZ >= 360)
        {
            rotateZLabel.color = Color.green;
        }
        else
        {
            rotateZLabel.color = Color.white;
        }
    }
}
