using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Xml;
using System;

public class SaveData : MonoBehaviour
{
    GameObject currentButton;
    string milesIP, gabriellaIP, currentIP;

    // Start is called before the first frame update
    void Start()
    {
        milesIP = "192.168.0.1";
        gabriellaIP = "192.168.0.1";
    }

    /*
        saveIP() runs when a button is pressed on the Computer Select menu.
        If either the "Miles' Computer" or "Gabriella's Computer" button is pressed, 
        the corresponding saved IP addresses are pulled and passed through to be saved 
        as the current controller's IP address. 
        When "Other Computer" is selected, the IP address is pulled from a pre-generated 
        XML file. 
    */
    public void saveIP()
    {
        currentButton = gameObject;
        string objName = gameObject.name.ToLower();

        if(objName.Contains("miles"))
        {
            //Debug.Log("Miles Selected");
            PlayerPrefs.SetString("currentControllerIP", milesIP);
            //Debug.Log("Controller IP: " + milesIP.ToString());
        }
        else if(objName.Contains("gabriella"))
        {
            //Debug.Log("Miles Selected");
            PlayerPrefs.SetString("currentControllerIP", gabriellaIP);
            //Debug.Log("Controller IP: " + gabriellaIP.ToString());
        }
        else
        {
            Debug.Log("Other Selected");
            
            // READ IP from XML File "ControllerInfo.XML"
            XmlDocument data = new XmlDocument();

            // TODO: Get the path to ControllerInfo.xml on Hololens
            // Note: Visual Studio 2019 generates the file pre-build at the following location:
            // "C:\Users\hpcpe\Documents\MR\Mista\build\Mista\ControllerInfo.xml"
            data.Load("C:\\Users\\hpcpe\\Documents\\MR\\Mista\\Assets\\Scripts\\ControllerInfo.xml");

            XmlNode ipNode = data.FirstChild.NextSibling;

            Debug.Log("Controller IP: " + ipNode.InnerText);
            
            PlayerPrefs.SetString("currentControllerIP", ipNode.InnerText);
        }

        SceneManager.LoadScene("Vectors", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
