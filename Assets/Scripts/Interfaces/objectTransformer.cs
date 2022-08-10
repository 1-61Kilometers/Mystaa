using UnityEngine;

public class objectTransformer : MonoBehaviour
{
    public GameObject interactableObject;

    void Start()
    {
    }

    void Update()
    {
    }

    public void rotateX(float amount)
    {
        Vector3 increment = new Vector3(amount, 0, 0);
        interactableObject.transform.eulerAngles += increment;
    }

    public void rotateY(float amount)
    {
        Vector3 increment = new Vector3(0, amount, 0);
        interactableObject.transform.eulerAngles += increment;
    }

    public void rotateZ(float amount)
    {
        Vector3 increment = new Vector3(0, 0, amount);
        interactableObject.transform.eulerAngles += increment;
    }

    public void translateX(float amount)
    {
        Vector3 increment = new Vector3(amount, 0, 0);
        interactableObject.transform.position += increment;
    }

    public void translateY(float amount)
    {
        Vector3 increment = new Vector3(0, amount, 0);
        interactableObject.transform.position += increment;
    }

    public void translateZ(float amount)
    {
        Vector3 increment = new Vector3(0, 0, amount);
        interactableObject.transform.position += increment;
    }
}
