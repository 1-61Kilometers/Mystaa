using UnityEngine;

public class joystickRotate : MonoBehaviour
{
    public GameObject manipulator;
    public GameObject interactableObject;
    public float degrees;

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
        updateInteractableRotation();
    }

    private void updateInteractableRotation()
    {
        manipulatorTranslationX = manipulator.transform.position.x - initialPosition.x;
        manipulatorTranslationY = manipulator.transform.position.y - initialPosition.y;
        manipulatorRotationX = manipulator.transform.rotation.x - initialRotation.x;

        interactableObject.transform.Rotate((float) (degrees * manipulatorTranslationX), (float) (degrees * manipulatorTranslationY), (float) (degrees * manipulatorRotationX));
    }

    public void clearValues()
    {
        manipulator.transform.position = initialPosition;
        manipulator.transform.rotation = initialRotation;
    }
}
