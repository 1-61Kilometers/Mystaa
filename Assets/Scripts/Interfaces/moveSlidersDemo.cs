//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using communication;
using Microsoft.MixedReality.Toolkit.UI;

public class moveSlidersDemo : MonoBehaviour
{
    public GameObject cube;
    public PinchSlider Horizontal_Slider;
    public PinchSlider Vertical_Slider;
    public PinchSlider Depth_Slider;
    public PinchSlider Rotate_Horizontal_Slider;
    public PinchSlider Rotate_Vertical_Slider;
    public PinchSlider Rotate_Clockwise_Slider;
    private Vector3 VecT;
    private Vector3 VecR;
    public double value;


    // Start is called before the first frame update
    void Start()
    {
      
      //  string keyboardText = keybaord.text;
    }

    // Update is called once per frame
    void Update()
    {
         //positions of cube
    //    double cz = -cube.transform.position.z + .5 ; //initialize variables above
    //    double cx = cube.transform.position.x ;
     //   double cy = cube.transform.position.y ;  
        
    }

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
    public void moveHorizontal()
    {
        value = (double)Horizontal_Slider.SliderValue;
        //Debug.Log(Horizontal_Slider.SliderValue);
        if (value > 0.5) 
        {
             moveTo(0.003f,0,0);
        }
        else if (value< 0.5)
         {
             moveTo(-0.003f,0,0);
         }
        else if (value == 0.5)
         {
             moveTo(0,0,0);

         } 

    }

    public void moveVertical()
    {
        value = (double)Vertical_Slider.SliderValue;
       // Debug.Log(Vertical_Slider.SliderValue);
        if (value > 0.5) 
        {
             moveTo(0,0.003f,0);
        }
        else if (value< 0.5)
         {
             moveTo(0,-0.003f,0);
         }
        else if (value == 0.5)
         {
             moveTo(0,0,0);

         } 

    }

      public void moveDepth()
    {
        value = (double)Depth_Slider.SliderValue;
      //  Debug.Log(Depth_Slider.SliderValue);
        if (value > 0.5) 
        {
             moveTo(0,0,-0.003f);
        }
        else if (value< 0.5)
         {
            moveTo(0,0,0.003f);
         }
        else if (value == 0.5)
         {
             moveTo(0,0,0);

         } 

    }
    
    public void rotateVertical()
    {
        value = (double)Rotate_Vertical_Slider.SliderValue;
      //  Debug.Log(Rotate_Horizontal_Slider.SliderValue);
        if (value > 0.5) 
        {
             rotateTo(0,0,-0.8f);
        }
        else if (value< 0.5)
         {
             rotateTo(0,0,0.8f);
         }
        else if (value == 0.5)
         {
             rotateTo(0,0,0);

         } 

    }

    public void rotateClockwise()
    {
       value = (double)Rotate_Clockwise_Slider.SliderValue;
      //  Debug.Log(Rotate_Vertical_Slider.SliderValue);
        if (value > 0.5) 
        {
             rotateTo(0.8f,0,0);
        }
        else if (value< 0.5)
         {
             rotateTo(-0.8f,0,0);
         }
        else if (value == 0.5)
         {
             rotateTo(0,0,0);

         } 

    }

     public void rotateHorizontal()
    {
        value = (double)Rotate_Horizontal_Slider.SliderValue;
       // Debug.Log(Rotate_Horizontal_Slider.SliderValue);
        if (value > 0.5) 
        {
             rotateTo(0,-0.8f,0);
        }
        else if (value< 0.5)
         {
             rotateTo(0,0.8f,0);
         }
        else if (value == 0.5)
         {
             rotateTo(0,0,0);

         } 

    }
    }
