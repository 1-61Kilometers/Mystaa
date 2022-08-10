using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public GameObject Gripper;
    List<GameObject> SaftyPoints;
    public GameObject Point;
    public
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SetSafeZone(){
        SaftyPoints = new List<GameObject>();
        SaftyPoints.Add((GameObject)Instantiate(Point, new Vector3(Gripper.transform.position.x - 1, Gripper.transform.position.y-.58798f, (Gripper.transform.position.z - .23605f) - .5f), Quaternion.LookRotation(Camera.main.transform.forward)));
        SaftyPoints.Add((GameObject)Instantiate(Point, new Vector3(Gripper.transform.position.x - 1, Gripper.transform.position.y-.58798f, (Gripper.transform.position.z - .23605f) + 1), Quaternion.LookRotation(Camera.main.transform.forward)));
        SaftyPoints.Add((GameObject)Instantiate(Point, new Vector3(Gripper.transform.position.x + 1, Gripper.transform.position.y-.58798f, (Gripper.transform.position.z - .23605f) + 1), Quaternion.LookRotation(Camera.main.transform.forward)));
        SaftyPoints.Add((GameObject)Instantiate(Point, new Vector3(Gripper.transform.position.x + 1, Gripper.transform.position.y-.58798f, (Gripper.transform.position.z - .23605f) -.5f), Quaternion.LookRotation(Camera.main.transform.forward)));
        
        SaftyPoints.Add((GameObject)Instantiate(Point, new Vector3(Gripper.transform.position.x - 1, Gripper.transform.position.y-.58798f + 1, (Gripper.transform.position.z - .23605f) - .5f), Quaternion.LookRotation(Camera.main.transform.forward)));
        SaftyPoints.Add((GameObject)Instantiate(Point, new Vector3(Gripper.transform.position.x - 1, Gripper.transform.position.y-.58798f + 1, (Gripper.transform.position.z - .23605f) + 1), Quaternion.LookRotation(Camera.main.transform.forward)));
        SaftyPoints.Add((GameObject)Instantiate(Point, new Vector3(Gripper.transform.position.x + 1, Gripper.transform.position.y-.58798f + 1, (Gripper.transform.position.z - .23605f) + 1), Quaternion.LookRotation(Camera.main.transform.forward)));
        SaftyPoints.Add((GameObject)Instantiate(Point, new Vector3(Gripper.transform.position.x + 1, Gripper.transform.position.y-.58798f + 1, (Gripper.transform.position.z - .23605f) -.5f), Quaternion.LookRotation(Camera.main.transform.forward)));
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
