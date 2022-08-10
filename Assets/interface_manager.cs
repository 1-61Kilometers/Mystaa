using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interface_manager : MonoBehaviour
{
    //public GameObject button_interface;
   // public GameObject slider_interface;
  //  public GameObject object_manipulator;
  //  public GameObject bounding_box;
  //  public GameObject joystick_interface;
    public GameObject myinterface;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void toggleInterface(){
        if(myinterface.activeSelf){
            myinterface.SetActive(false);
        } else {
            myinterface.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
