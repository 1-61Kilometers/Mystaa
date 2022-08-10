using UnityEngine;

public class joystickTranslate : MonoBehaviour
{
    public GameObject manipulator;
    public GameObject interactableObject;
    public float units;

    private double manipulatorTranslationX;
    private double manipulatorTranslationY;
    private double manipulatorRotationX;

    private Vector3 initialPosition;
    private Quaternion initialRotation;

    void Start()
    {
        initialPosition = manipulator.transform.position;
        initialRotation = manipulator.transform.rotation;
    }

    void Update()
    {
        updateInteractablePosition();
    }

    public void updateInteractablePosition()
    {
        manipulatorTranslationX = manipulator.transform.position.x - initialPosition.x;
        manipulatorTranslationY = manipulator.transform.position.y - initialPosition.y;
        manipulatorRotationX = manipulator.transform.rotation.x - initialRotation.x;

        interactableObject.transform.position += new Vector3((float) manipulatorTranslationX * units, (float) manipulatorTranslationY * units, (float) manipulatorRotationX * units);
    }

    public void clearValues()
    {
        manipulator.transform.position = initialPosition;
        manipulator.transform.rotation = initialRotation;
    }
}
