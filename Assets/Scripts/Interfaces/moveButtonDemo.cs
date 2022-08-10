//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using communication;

public class moveButtonDemo : MonoBehaviour
{
   // public UDPCommunication myserver;
    public GameObject cube;
    private Vector3 VecT;
    private Vector3 VecR;



    void Start()
    {}
    void Update()
    {}

    void moveTo(float a,float b, float c)
    {
        VecT = cube.transform.position;
        VecT.x += a;
        VecT.y += b;
        VecT.z += c;
        cube.transform.position = VecT;

    }

    void rotateTo(float a,float b, float c)
    {
        VecR = cube.transform.eulerAngles;
        VecR.x += a;
        VecR.y += b;
        VecR.z += c;
        cube.transform.eulerAngles = VecR;

    }

    public void cubeTransformRight()
    {
       
        moveTo(0.009f,0,0);

    }
    public void cubeTransformLeft()
    {

         moveTo(-0.009f,0,0);

    }
    public void cubeTransformUp()
    {

        moveTo(0,0.009f,0);

    }
     public void cubeTransformDown()
    {

          moveTo(0,-0.009f,0);

    }

     public void cubeTransformForward()
    {

        moveTo(0,0,-0.009f);

    }
     public void cubeTransformBack()
    {

          moveTo(0,0,0.009f);

    }
     public void cubeRotateRight() 
    {
        rotateTo(0,-3f,0);


    }
     public void cubeRotateLeft() 
    {
        rotateTo(0,3f,0);


    }
     public void cubeRotateUp()
    {
        rotateTo(0,0,-3f);
 

    }
     public void cubeRotateDown() 
    {
        rotateTo(0,0,3f);


    }
     public void cubeRotateClockwise()
    {
        rotateTo(-3f,0,0);
 

    }
     public void cubeRotateCClockwise() 
    {

        rotateTo(3f,0,0);


    }
  

}
