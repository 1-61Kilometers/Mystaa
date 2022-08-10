using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using communication;
using TMPro;
public class moveCube : MonoBehaviour
{
    public UDPCommunication myserver;
    public GameObject cube;
    public GameObject button;
    Vector3 Set;
    Vector3 angles;
    public Material mesh;
    string port = "6511";
    public string controllerip;
    bool server = false;

    //Sets the offset of  the bounding box ,,, could replace with QR
    public void Setpos(){
        Set = cube.transform.position;
        angles = cube.transform.eulerAngles;
        server = true;
        button.SetActive(false);
    }
    
    #if !UNITY_EDITOR
    

    
    // Start is called before the first frame update
    void Start()
    {
      
      
    }
    
    // Update is called once per frame
    void Update()
    {
        //Waits for button to be pressed
        if(server == true){
            //Connects to server
            myserver = new UDPCommunication(controllerip,port);
            server = false;
        }

        //Offset positions of cube
        double cz = -cube.transform.position.z + Set.z ; //initialize variables above
        double cx = cube.transform.position.x - Set.x;
        double cy = cube.transform.position.y - Set.y;
        
        //Safty Zone
        if(Vector3.Distance(Set, cube.transform.position) < .55 && cy >= -.29){          
            mesh.color = new Color(255,255,255,0);
            myserver.cubeMove(cx, cy, cz, (-cube.transform.eulerAngles.z - 180) + angles.z, cube.transform.eulerAngles.x - angles.x, (-cube.transform.eulerAngles.y - 180) - angles.y);
        } else {
            mesh.color = new Color(255,0,0,1);
        }
    }

    #else
    
    void Start()
    {}
    void Update()
    {}

    #endif
    //this is miles making a comment
    //this is gabriella making a comment
}
